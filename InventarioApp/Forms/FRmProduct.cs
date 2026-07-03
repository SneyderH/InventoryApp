using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioApp.Models;
using InventarioApp.Services;

namespace InventarioApp.Forms
{
    public partial class FRmProduct : Form
    {
        private readonly ProductService _productoService = new();
        private readonly Product? _productoExistente;

        // Constructor para AGREGAR
        public FRmProduct()
        {
            InitializeComponent();
            _productoExistente = null;
        }

        // Constructor para EDITAR
        public FRmProduct(Product productoAEditar)
        {
            InitializeComponent();
            _productoExistente = productoAEditar;
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            if (_productoExistente != null)
            {
                this.Text = "Editar Producto";
                txtBarCode.Text = _productoExistente.BarCode;
                txtName.Text = _productoExistente.Name;
                cmbCategory.Text = _productoExistente.Category;
                nudPrice.Value = _productoExistente.UnitPrice;
                nudStock.Value = _productoExistente.Stock;
                nudMinStock.Value = _productoExistente.MinStock;
            }
            else
            {
                this.Text = "Agregar Producto";
            }
        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ValidateBarCode();
            }
        }

        private void ValidateBarCode()
        {
            if (_productoExistente != null) return;

            string codigo = txtBarCode.Text.Trim();
            if (string.IsNullOrWhiteSpace(codigo)) return;

            var productoEncontrado = _productoService.SearchByCode(codigo);

            if (productoEncontrado != null)
            {
                var respuesta = MessageBox.Show(
                    $"Este producto ya existe:\n\n" +
                    $"Nombre: {productoEncontrado.Name}\n" +
                    $"Stock actual: {productoEncontrado.Stock}\n\n" +
                    $"¿Deseas editarlo para actualizar el stock?",
                    "Producto existente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    this.Tag = productoEncontrado;
                    this.DialogResult = DialogResult.Retry;
                    this.Close();
                }
                else
                {
                    txtBarCode.Clear();
                    txtBarCode.Focus();
                }
            }
            else
            {
                txtName.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarCode.Text))
            {
                MessageBox.Show("El código de barras es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idExcluir = _productoExistente?.Id ?? 0;
            if (_productoService.ExistingBarCode(txtBarCode.Text.Trim(), idExcluir))
            {
                MessageBox.Show("Ya existe un producto con ese código de barras.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_productoExistente != null)
            {
                _productoExistente.BarCode = txtBarCode.Text.Trim();
                _productoExistente.Name = txtName.Text.Trim();
                _productoExistente.Category = cmbCategory.Text.Trim();
                _productoExistente.UnitPrice = nudPrice.Value;
                _productoExistente.Stock = (int)nudStock.Value;
                _productoExistente.MinStock = (int)nudMinStock.Value;

                _productoService.Update(_productoExistente);
            }
            else
            {
                var nuevoProducto = new Product
                {
                    BarCode = txtBarCode.Text.Trim(),
                    Name = txtName.Text.Trim(),
                    Category = cmbCategory.Text.Trim(),
                    UnitPrice = nudPrice.Value,
                    Stock = (int)nudStock.Value,
                    MinStock = (int)nudMinStock.Value
                };

                _productoService.Add(nuevoProducto);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
