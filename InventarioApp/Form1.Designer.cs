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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabInventory = new TabPage();
            dgvProducts = new DataGridView();
            panel1 = new Panel();
            lblFilter = new Label();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            tabVenta = new TabPage();
            gbScannedProduct = new GroupBox();
            lblStockSell = new Label();
            lblPriceSell = new Label();
            lblNameSell = new Label();
            lblStock = new Label();
            lblPrice = new Label();
            lblProductName = new Label();
            dgvShoppingCart = new DataGridView();
            panel2 = new Panel();
            btnCancelItem = new Button();
            lblTotal = new Label();
            txtBarCodeSale = new TextBox();
            label4 = new Label();
            btnCancelSale = new Button();
            btnAccept = new Button();
            tabHistory = new TabPage();
            dgvDetails = new DataGridView();
            panel3 = new Panel();
            lblTotalClosing = new Label();
            label1 = new Label();
            btnRegisterClosing = new Button();
            dgvMaster = new DataGridView();
            tabControl1.SuspendLayout();
            tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            tabVenta.SuspendLayout();
            gbScannedProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShoppingCart).BeginInit();
            panel2.SuspendLayout();
            tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaster).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabInventory);
            tabControl1.Controls.Add(tabVenta);
            tabControl1.Controls.Add(tabHistory);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(15, 15);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1754, 513);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabInventory
            // 
            tabInventory.Controls.Add(dgvProducts);
            tabInventory.Controls.Add(panel1);
            tabInventory.Location = new Point(4, 30);
            tabInventory.Margin = new Padding(4, 3, 4, 3);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(4, 3, 4, 3);
            tabInventory.Size = new Size(1746, 479);
            tabInventory.TabIndex = 0;
            tabInventory.Text = "Inventario";
            tabInventory.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(4, 122);
            dgvProducts.Margin = new Padding(4, 3, 4, 3);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1738, 354);
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
            panel1.Location = new Point(4, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1738, 119);
            panel1.TabIndex = 5;
            // 
            // lblFilter
            // 
            lblFilter.Anchor = AnchorStyles.Right;
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(1441, 16);
            lblFilter.Margin = new Padding(4, 0, 4, 0);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(65, 21);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Buscar";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Right;
            txtSearch.Location = new Point(1351, 43);
            txtSearch.Margin = new Padding(6, 5, 6, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(245, 28);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.DeepSkyBlue;
            btnAdd.Location = new Point(150, 23);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(210, 68);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "AGREGAR";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Location = new Point(855, 23);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(194, 68);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Location = new Point(503, 23);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(204, 68);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "EDITAR";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // tabVenta
            // 
            tabVenta.Controls.Add(gbScannedProduct);
            tabVenta.Controls.Add(dgvShoppingCart);
            tabVenta.Controls.Add(panel2);
            tabVenta.Location = new Point(4, 30);
            tabVenta.Margin = new Padding(4, 3, 4, 3);
            tabVenta.Name = "tabVenta";
            tabVenta.Padding = new Padding(4, 3, 4, 3);
            tabVenta.Size = new Size(1746, 479);
            tabVenta.TabIndex = 1;
            tabVenta.Text = "Venta";
            tabVenta.UseVisualStyleBackColor = true;
            // 
            // gbScannedProduct
            // 
            gbScannedProduct.BackColor = Color.LightGray;
            gbScannedProduct.Controls.Add(lblStockSell);
            gbScannedProduct.Controls.Add(lblPriceSell);
            gbScannedProduct.Controls.Add(lblNameSell);
            gbScannedProduct.Controls.Add(lblStock);
            gbScannedProduct.Controls.Add(lblPrice);
            gbScannedProduct.Controls.Add(lblProductName);
            gbScannedProduct.Dock = DockStyle.Top;
            gbScannedProduct.Location = new Point(4, 3);
            gbScannedProduct.Margin = new Padding(4, 3, 4, 3);
            gbScannedProduct.Name = "gbScannedProduct";
            gbScannedProduct.Padding = new Padding(4, 3, 4, 3);
            gbScannedProduct.Size = new Size(1738, 126);
            gbScannedProduct.TabIndex = 9;
            gbScannedProduct.TabStop = false;
            gbScannedProduct.Text = "Producto escaneado";
            // 
            // lblStockSell
            // 
            lblStockSell.AutoSize = true;
            lblStockSell.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockSell.Location = new Point(1631, 80);
            lblStockSell.Margin = new Padding(4, 0, 4, 0);
            lblStockSell.Name = "lblStockSell";
            lblStockSell.Size = new Size(20, 27);
            lblStockSell.TabIndex = 5;
            lblStockSell.Text = "-";
            // 
            // lblPriceSell
            // 
            lblPriceSell.AutoSize = true;
            lblPriceSell.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPriceSell.Location = new Point(818, 80);
            lblPriceSell.Margin = new Padding(4, 0, 4, 0);
            lblPriceSell.Name = "lblPriceSell";
            lblPriceSell.Size = new Size(20, 27);
            lblPriceSell.TabIndex = 4;
            lblPriceSell.Text = "-";
            // 
            // lblNameSell
            // 
            lblNameSell.AutoSize = true;
            lblNameSell.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameSell.Location = new Point(15, 80);
            lblNameSell.Margin = new Padding(4, 0, 4, 0);
            lblNameSell.Name = "lblNameSell";
            lblNameSell.Size = new Size(20, 27);
            lblNameSell.TabIndex = 3;
            lblNameSell.Text = "-";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(1620, 42);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(63, 19);
            lblStock.TabIndex = 2;
            lblStock.Text = "STOCK";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(826, 42);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(70, 19);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "PRECIO";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(15, 42);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(208, 19);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "NOMBRE DEL PRODUCTO";
            // 
            // dgvShoppingCart
            // 
            dgvShoppingCart.AllowUserToAddRows = false;
            dgvShoppingCart.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dgvShoppingCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvShoppingCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvShoppingCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShoppingCart.BackgroundColor = SystemColors.ActiveBorder;
            dgvShoppingCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShoppingCart.Location = new Point(4, 135);
            dgvShoppingCart.Margin = new Padding(4, 3, 4, 3);
            dgvShoppingCart.Name = "dgvShoppingCart";
            dgvShoppingCart.ReadOnly = true;
            dgvShoppingCart.RowHeadersWidth = 51;
            dgvShoppingCart.ShowCellToolTips = false;
            dgvShoppingCart.ShowEditingIcon = false;
            dgvShoppingCart.Size = new Size(1736, 80);
            dgvShoppingCart.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelItem);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(txtBarCodeSale);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnCancelSale);
            panel2.Controls.Add(btnAccept);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(4, 238);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1738, 238);
            panel2.TabIndex = 8;
            // 
            // btnCancelItem
            // 
            btnCancelItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelItem.BackColor = Color.Tan;
            btnCancelItem.Location = new Point(1051, 180);
            btnCancelItem.Margin = new Padding(4, 3, 4, 3);
            btnCancelItem.Name = "btnCancelItem";
            btnCancelItem.Size = new Size(207, 46);
            btnCancelItem.TabIndex = 7;
            btnCancelItem.Text = "QUITAR ITEM";
            btnCancelItem.UseVisualStyleBackColor = false;
            btnCancelItem.Click += btnCancelItem_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.ForestGreen;
            lblTotal.Location = new Point(1581, 99);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 27);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "$0";
            // 
            // txtBarCodeSale
            // 
            txtBarCodeSale.Location = new Point(15, 17);
            txtBarCodeSale.Margin = new Padding(4, 3, 4, 3);
            txtBarCodeSale.Name = "txtBarCodeSale";
            txtBarCodeSale.Size = new Size(1, 28);
            txtBarCodeSale.TabIndex = 3;
            txtBarCodeSale.KeyDown += txtBarCodeSale_KeyDown;
            txtBarCodeSale.Leave += txtBarCodeSale_Leave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1589, 64);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 22);
            label4.TabIndex = 1;
            label4.Text = "TOTAL";
            // 
            // btnCancelSale
            // 
            btnCancelSale.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelSale.BackColor = Color.Salmon;
            btnCancelSale.Location = new Point(1295, 180);
            btnCancelSale.Margin = new Padding(4, 3, 4, 3);
            btnCancelSale.Name = "btnCancelSale";
            btnCancelSale.Size = new Size(193, 46);
            btnCancelSale.TabIndex = 6;
            btnCancelSale.Text = "CANCELAR VENTA";
            btnCancelSale.UseVisualStyleBackColor = false;
            btnCancelSale.Click += btnCancelSale_Click;
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAccept.BackColor = Color.Lime;
            btnAccept.Location = new Point(1520, 180);
            btnAccept.Margin = new Padding(4, 3, 4, 3);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(197, 46);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "ACEPTAR";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // tabHistory
            // 
            tabHistory.Controls.Add(dgvDetails);
            tabHistory.Controls.Add(panel3);
            tabHistory.Controls.Add(dgvMaster);
            tabHistory.Location = new Point(4, 29);
            tabHistory.Margin = new Padding(4, 3, 4, 3);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(4, 3, 4, 3);
            tabHistory.Size = new Size(1746, 480);
            tabHistory.TabIndex = 2;
            tabHistory.Text = "Histórico de Ventas";
            tabHistory.UseVisualStyleBackColor = true;
            // 
            // dgvDetails
            // 
            dgvDetails.AllowUserToAddRows = false;
            dgvDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dgvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Dock = DockStyle.Fill;
            dgvDetails.Location = new Point(4, 146);
            dgvDetails.Margin = new Padding(4, 3, 4, 3);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.ReadOnly = true;
            dgvDetails.RowHeadersWidth = 51;
            dgvDetails.ShowCellToolTips = false;
            dgvDetails.ShowEditingIcon = false;
            dgvDetails.Size = new Size(1738, 200);
            dgvDetails.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTotalClosing);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnRegisterClosing);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(4, 346);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1738, 131);
            panel3.TabIndex = 1;
            // 
            // lblTotalClosing
            // 
            lblTotalClosing.AutoSize = true;
            lblTotalClosing.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalClosing.ForeColor = Color.LimeGreen;
            lblTotalClosing.Location = new Point(55, 80);
            lblTotalClosing.Margin = new Padding(4, 0, 4, 0);
            lblTotalClosing.Name = "lblTotalClosing";
            lblTotalClosing.Size = new Size(20, 27);
            lblTotalClosing.TabIndex = 2;
            lblTotalClosing.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 1;
            label1.Text = "Total del día";
            // 
            // btnRegisterClosing
            // 
            btnRegisterClosing.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegisterClosing.BackColor = Color.Beige;
            btnRegisterClosing.ForeColor = SystemColors.ControlText;
            btnRegisterClosing.Location = new Point(1431, 42);
            btnRegisterClosing.Margin = new Padding(4, 3, 4, 3);
            btnRegisterClosing.Name = "btnRegisterClosing";
            btnRegisterClosing.Size = new Size(280, 59);
            btnRegisterClosing.TabIndex = 0;
            btnRegisterClosing.Text = "CIERRE DE CAJA";
            btnRegisterClosing.UseVisualStyleBackColor = false;
            btnRegisterClosing.Click += btnRegisterClosing_Click;
            // 
            // dgvMaster
            // 
            dgvMaster.AllowUserToAddRows = false;
            dgvMaster.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dgvMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaster.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaster.Dock = DockStyle.Top;
            dgvMaster.Location = new Point(4, 3);
            dgvMaster.Margin = new Padding(4, 3, 4, 3);
            dgvMaster.Name = "dgvMaster";
            dgvMaster.ReadOnly = true;
            dgvMaster.RowHeadersWidth = 51;
            dgvMaster.ShowCellToolTips = false;
            dgvMaster.ShowEditingIcon = false;
            dgvMaster.Size = new Size(1738, 143);
            dgvMaster.TabIndex = 0;
            dgvMaster.SelectionChanged += dgvMaster_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1784, 543);
            Controls.Add(tabControl1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Padding = new Padding(15);
            Text = "Sistema de Inventario";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabVenta.ResumeLayout(false);
            gbScannedProduct.ResumeLayout(false);
            gbScannedProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShoppingCart).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaster).EndInit();
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
        private Label lblTotal;
        private Label label4;
        private TextBox txtBarCodeSale;
        private DataGridView dgvShoppingCart;
        private Button btnCancelSale;
        private Button btnAccept;
        private Button btnCancelItem;
        private GroupBox gbScannedProduct;
        private Label lblStock;
        private Label lblPrice;
        private Label lblProductName;
        private Panel panel2;
        private Label lblNameSell;
        private Label lblStockSell;
        private Label lblPriceSell;
        private DataGridView dgvMaster;
        private DataGridView dgvDetails;
        private Panel panel3;
        private Label lblTotalClosing;
        private Label label1;
        private Button btnRegisterClosing;
    }
}
