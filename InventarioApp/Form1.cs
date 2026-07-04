using InventarioApp.Data;
using InventarioApp.Forms;
using InventarioApp.Models;
using InventarioApp.Services;
using System.ComponentModel;
using System.Data;
using System.Drawing.Text;

namespace InventarioApp
{
    public partial class Form1 : Form
    {
        private readonly ProductService _productService = new();
        private readonly SellService _sellService = new();
        private List<Sale> _shoppingCart = new List<Sale>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        #region INVENTORY
        private void LoadProducts(string filter = "")
        {
            var products = string.IsNullOrEmpty(filter)
                ? _productService.GetAll()
                : _productService.Search(filter);

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;

            //Resaltar stock bajo
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
            if (dgvProducts.CurrentRow.DataBoundItem is not Product selected)
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

        #region SALES
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabVenta.Enabled = tabControl1.SelectedIndex == 1;
            txtBarCodeSale.Focus();
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

                ShoppingCartRefresh();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void ShoppingCartRefresh()
        {
            dgvShoppingCart.DataSource = null;
            dgvShoppingCart.DataSource = _shoppingCart;
        }




        #endregion

    }
}
