using InventarioApp.Data;
using InventarioApp.Forms;
using InventarioApp.Models;
using InventarioApp.Services;
using System.ComponentModel;
using System.Data;
using System.Drawing.Text;
using System.Net.WebSockets;
using System.Text;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InventarioApp
{
    public partial class Form1 : Form
    {
        private readonly ProductService _productService = new();
        private readonly SellService _sellService = new();
        private readonly BackupService _backupService = new();
        private List<Sale> _shoppingCart = new List<Sale>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new InventoryContext())
            {
                context.Database.EnsureCreated();
            }

            LoadProducts();
        }

        #region INVENTARIO
        private void LoadProducts(string filter = "")
        {
            var products = string.IsNullOrEmpty(filter)
                ? _productService.GetAll()
                : _productService.Search(filter);

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
            GridStyle(dgvProducts);

            #region FORMATOS DATAGRIDVIEW INVENTARIO
            dgvProducts.Columns["Id"].Visible = false;
            dgvProducts.Columns["CreationDate"].Visible = false;
            dgvProducts.Columns["MinStock"].Visible = false;

            dgvProducts.Columns["BarCode"].HeaderText = "Código de barra";
            dgvProducts.Columns["Name"].HeaderText = "Nombre";
            dgvProducts.Columns["Category"].HeaderText = "Categoría";
            dgvProducts.Columns["UnitPrice"].HeaderText = "Precio Unitario";

            dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Format = "C0";
            #endregion

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                var product = (Product)row.DataBoundItem;
                if (product.Stock <= product.MinStock)
                {
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var frm = new FRmProduct();
            var resultado = frm.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                LoadProducts();
            }
            else if (resultado == DialogResult.Retry)
            {
                // El usuario escaneó un código existente y quiere editarlo
                var productoExistente = (Product)frm.Tag;
                using var frmEditar = new FRmProduct(productoExistente);
                if (frmEditar.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is not Product selected)
            {
                MessageBox.Show("Selecciona un producto para editar.");
                return;
            }

            using var frm = new FRmProduct(selected);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is not Product selected)
            {
                MessageBox.Show("Selecciona un producto para eliminar.");
                return;
            }

            var confirmation = MessageBox.Show(
                $"¿Seguro que desea eliminar '{selected.Name}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                _productService.Delete(selected.Id);
                LoadProducts();
            }
        }
        #endregion

        #region VENTAS
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabVenta.Enabled = tabControl1.SelectedIndex == 1;
            txtBarCodeSale.Focus();
            dgvMaster.DataSource = _sellService.GetTodaySalesSummary();
            lblTotalClosing.Text = _sellService.GetTodaySalesSummary().Sum(s => s.Total).ToString("C0");

        }

        private void txtBarCodeSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtBarCodeSale.Focus();
                string barCode = txtBarCodeSale.Text.Trim();
                txtBarCodeSale.Clear();
                if (string.IsNullOrWhiteSpace(barCode)) return;
                DisplayScannedProduct(barCode);
            }
        }

        private void DisplayScannedProduct(string code)
        {
            var product = _sellService.SaleResult(code);
            if (product != null)
            {
                lblNameSell.Text = product.Name;
                lblPriceSell.Text = product.UnitPrice.ToString("C0");
                lblStockSell.Text = product.Stock.ToString();

                var existingProduct = _shoppingCart.FirstOrDefault(p => p.ProductId == product.Id);

                if (existingProduct != null)
                {
                    existingProduct.Amount += 1;
                }
                else
                {
                    _shoppingCart.Add(new Sale
                    {
                        ProductId = product.Id,
                        ProductName = product.Name,
                        UnitPrice = product.UnitPrice,
                        Amount = 1,
                    });
                }

                decimal total = _shoppingCart.Sum(s => s.Subtotal);
                lblTotal.Text = total.ToString("C0");
                ShoppingCartRefresh();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
                txtBarCodeSale.Focus();
            }
        }

        private void txtBarCodeSale_Leave(object sender, EventArgs e)
        {
            txtBarCodeSale.Focus();
        }

        private void ShoppingCartRefresh()
        {
            dgvShoppingCart.DataSource = null;
            dgvShoppingCart.DataSource = _shoppingCart;

            #region FORMATOS DATAGRIDVIEW CARRITO DE COMPRAS
            dgvShoppingCart.Columns["Id"].Visible = false;
            dgvShoppingCart.Columns["ProductId"].Visible = false;
            dgvShoppingCart.Columns["Product"].Visible = false;
            dgvShoppingCart.Columns["SaleTransactionId"].Visible = false;

            dgvShoppingCart.Columns["ProductName"].HeaderText = "Producto";
            dgvShoppingCart.Columns["Amount"].HeaderText = "Cantidad";
            dgvShoppingCart.Columns["UnitPrice"].HeaderText = "Precio Unitario";
            dgvShoppingCart.Columns["Date"].HeaderText = "Fecha";

            dgvShoppingCart.Columns["UnitPrice"].DefaultCellStyle.Format = "C0";
            dgvShoppingCart.Columns["Subtotal"].DefaultCellStyle.Format = "C0";
            #endregion
        }



        #endregion

        #region BOTONES
        private void btnAccept_Click(object sender, EventArgs e)
        {

            if (_shoppingCart.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito de compras.");
                return;
            }

            int newIdTransaction = _sellService.GetNextTransactionId();

            foreach (Sale s in _shoppingCart)
            {
                s.SaleTransactionId = newIdTransaction;
            }

            bool response = _sellService.SaveSales(_shoppingCart);

            if (response == false)
            {
                MessageBox.Show($"No hay suficiente stock para algún producto seleccionado");
                return;
            }

            MessageBox.Show("Venta realizada con éxito.");
            _shoppingCart.Clear();
            dgvShoppingCart.DataSource = null;
            LoadProducts();
            lblTotal.Text = (0m).ToString("c0");
            lblNameSell.Text = "-";
            lblPriceSell.Text = "-";
            lblStockSell.Text = "-";
        }
        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            _shoppingCart.Clear();
            dgvShoppingCart.DataSource = null;
            LoadProducts();
            lblTotal.Text = (0m).ToString("c0");
            lblNameSell.Text = "-";
            lblPriceSell.Text = "-";
            lblStockSell.Text = "-";
            txtBarCodeSale.Focus();
        }

        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            if (dgvShoppingCart.CurrentRow != null || dgvShoppingCart.CurrentRow.DataBoundItem is not Sale selectedItem)
            {
                MessageBox.Show("Selecciona un producto para cancelar.");
                return;
            }

            var confirmation = MessageBox.Show(
                $"¿Seguro que desea eliminar '{selectedItem.ProductName}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                _shoppingCart.Remove(selectedItem);
                decimal total = _shoppingCart.Sum(s => s.Subtotal);
                lblTotal.Text = total.ToString("C0");
                ShoppingCartRefresh();
                txtBarCodeSale.Focus();

            }
        }
        private void btnRegisterClosing_Click(object sender, EventArgs e)
        {

            if (dgvMaster.Rows.Count == 0)
            {
                MessageBox.Show("No hay ventas registradas para el día de hoy.");
                return;
            }

            var confirmation = MessageBox.Show(
                $"¿Seguro que desea hacer el cierre de caja?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            var salesSummary = _sellService.GetTodaySalesSummary();
            var selledProducts = _sellService.GetTodaySalesDetails();

            var content = new StringBuilder();
            content.AppendLine($"CIERRE DE CAJA - {DateTime.Today:dd/MM/yyyy}");
            content.AppendLine(new string('=', 40));
            content.AppendLine();

            foreach (var sale in salesSummary)
            {
                content.AppendLine($"Venta #{sale.SaleTransactionId} - {sale.Date:hh:mm tt}");

                var productsFromThisSale = selledProducts
                    .Where(d => d.SaleTransactionId == sale.SaleTransactionId);

                foreach (var product in productsFromThisSale)
                {
                    content.AppendLine($"  {product.ProductName} x{product.Amount} - {product.Subtotal:C0}");
                }

                content.AppendLine($"  Subtotal venta: {sale.Total:C0}");
                content.AppendLine();
            }

            content.AppendLine(new string('=', 40));
            content.AppendLine($"TOTAL DEL DÍA: {salesSummary.Sum(v => v.Total):C0}");

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivo de texto (*.txt)|*.txt";
            saveDialog.FileName = $"CierreCaja_{DateTime.Today:yyyy-MM-dd}.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName, content.ToString());
                _backupService.CreateBackup();
                MessageBox.Show("Cierre de caja generado correctamente.");

            }
        }

        #endregion

        #region HISTÓRICO DE VENTA
        private void dgvMaster_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMaster.CurrentRow == null || dgvMaster.CurrentRow.DataBoundItem is not SaleSummary selectedSale)
            {
                return;
            }

            var details = _sellService.GetSaleDetails(selectedSale.SaleTransactionId);

            dgvDetails.DataSource = null;
            dgvDetails.DataSource = details;

            #region FORMATO DATAGRIDVIEWS

            //DATAGRIDVIEW DETAILS
            dgvDetails.Columns["Id"].Visible = false;
            dgvDetails.Columns["ProductId"].Visible = false;
            dgvDetails.Columns["Product"].Visible = false;

            dgvDetails.Columns["SaleTransactionId"].DisplayIndex = 0;

            dgvDetails.Columns["ProductName"].HeaderText = "Producto";
            dgvDetails.Columns["Amount"].HeaderText = "Cantidad";
            dgvDetails.Columns["UnitPrice"].HeaderText = "Precio Unitario";
            dgvDetails.Columns["Date"].HeaderText = "Fecha";
            dgvDetails.Columns["SaleTransactionId"].HeaderText = "# Venta";

            dgvDetails.Columns["UnitPrice"].DefaultCellStyle.Format = "C0";
            dgvDetails.Columns["Subtotal"].DefaultCellStyle.Format = "C0";


            //DATAGRIDVIEW MASTER
            dgvMaster.Columns["Date"].HeaderText = "Fecha";
            dgvMaster.Columns["SaleTransactionId"].HeaderText = "# Venta";

            dgvMaster.Columns["Total"].DefaultCellStyle.Format = "C0";

            #endregion
        }

        #endregion



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _backupService.CreateBackup();
        }

        private void GridStyle(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 65, 92); // azul oscuro
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9.5f, FontStyle.Bold);
            grid.ColumnHeadersHeight = 36;
            grid.RowTemplate.Height = 30;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 65, 92);
            grid.BorderStyle = BorderStyle.None;
            grid.GridColor = Color.FromArgb(230, 230, 230);
        }
    }
}
