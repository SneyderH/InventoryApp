using InventarioApp.Data;
using InventarioApp.Forms;
using InventarioApp.Models;
using InventarioApp.Services;

namespace InventarioApp
{
    public partial class Form1 : Form
    {
        private readonly ProductService _productService = new();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

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
    }
}
