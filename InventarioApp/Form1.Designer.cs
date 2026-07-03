using InventarioApp.Data;

namespace InventarioApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabInventory = new TabPage();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvProducts = new DataGridView();
            panel1 = new Panel();
            tabVenta = new TabPage();
            tabHistory = new TabPage();
            lblFilter = new Label();
            tabControl1.SuspendLayout();
            tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabInventory);
            tabControl1.Controls.Add(tabVenta);
            tabControl1.Controls.Add(tabHistory);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabInventory
            // 
            tabInventory.Controls.Add(dgvProducts);
            tabInventory.Controls.Add(panel1);
            tabInventory.Location = new Point(4, 29);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(792, 417);
            tabInventory.TabIndex = 0;
            tabInventory.Text = "Inventario";
            tabInventory.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(551, 41);
            txtSearch.Margin = new Padding(5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(197, 27);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(357, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 65);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(188, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(163, 65);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 65);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(3, 116);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(786, 298);
            dgvProducts.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblFilter);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 113);
            panel1.TabIndex = 5;
            // 
            // tabVenta
            // 
            tabVenta.Location = new Point(4, 29);
            tabVenta.Name = "tabVenta";
            tabVenta.Padding = new Padding(3);
            tabVenta.Size = new Size(792, 417);
            tabVenta.TabIndex = 1;
            tabVenta.Text = "Venta";
            tabVenta.UseVisualStyleBackColor = true;
            // 
            // tabHistory
            // 
            tabHistory.Location = new Point(4, 29);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(3);
            tabHistory.Size = new Size(792, 417);
            tabHistory.TabIndex = 2;
            tabHistory.Text = "Histórico de Ventas";
            tabHistory.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(623, 15);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(52, 20);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Buscar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Sistema de Inventario";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabInventory;
        private DataGridView dgvProducts;
        private TabPage tabVenta;
        private TabPage tabHistory;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel panel1;
        private Label lblFilter;
    }
}
