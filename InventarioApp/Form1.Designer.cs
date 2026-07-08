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
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1427, 517);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabInventory
            // 
            tabInventory.Controls.Add(dgvProducts);
            tabInventory.Controls.Add(panel1);
            tabInventory.Location = new Point(4, 29);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(1419, 484);
            tabInventory.TabIndex = 0;
            tabInventory.Text = "Inventario";
            tabInventory.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(3, 116);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1413, 365);
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
            panel1.Size = new Size(1413, 113);
            panel1.TabIndex = 5;
            // 
            // lblFilter
            // 
            lblFilter.Anchor = AnchorStyles.Right;
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(1176, 15);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(52, 20);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Buscar";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Right;
            txtSearch.Location = new Point(1104, 41);
            txtSearch.Margin = new Padding(5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(197, 27);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Location = new Point(120, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 65);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "AGREGAR";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Location = new Point(684, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 65);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Location = new Point(402, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(163, 65);
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
            tabVenta.Location = new Point(4, 29);
            tabVenta.Name = "tabVenta";
            tabVenta.Padding = new Padding(3);
            tabVenta.Size = new Size(1419, 484);
            tabVenta.TabIndex = 1;
            tabVenta.Text = "Venta";
            tabVenta.UseVisualStyleBackColor = true;
            // 
            // gbScannedProduct
            // 
            gbScannedProduct.Controls.Add(lblStockSell);
            gbScannedProduct.Controls.Add(lblPriceSell);
            gbScannedProduct.Controls.Add(lblNameSell);
            gbScannedProduct.Controls.Add(lblStock);
            gbScannedProduct.Controls.Add(lblPrice);
            gbScannedProduct.Controls.Add(lblProductName);
            gbScannedProduct.Dock = DockStyle.Top;
            gbScannedProduct.Location = new Point(3, 3);
            gbScannedProduct.Name = "gbScannedProduct";
            gbScannedProduct.Size = new Size(1413, 120);
            gbScannedProduct.TabIndex = 9;
            gbScannedProduct.TabStop = false;
            gbScannedProduct.Text = "groupBox1";
            // 
            // lblStockSell
            // 
            lblStockSell.AutoSize = true;
            lblStockSell.Location = new Point(1305, 76);
            lblStockSell.Name = "lblStockSell";
            lblStockSell.Size = new Size(15, 20);
            lblStockSell.TabIndex = 5;
            lblStockSell.Text = "-";
            // 
            // lblPriceSell
            // 
            lblPriceSell.AutoSize = true;
            lblPriceSell.Location = new Point(661, 76);
            lblPriceSell.Name = "lblPriceSell";
            lblPriceSell.Size = new Size(15, 20);
            lblPriceSell.TabIndex = 4;
            lblPriceSell.Text = "-";
            // 
            // lblNameSell
            // 
            lblNameSell.AutoSize = true;
            lblNameSell.Location = new Point(12, 76);
            lblNameSell.Name = "lblNameSell";
            lblNameSell.Size = new Size(15, 20);
            lblNameSell.TabIndex = 3;
            lblNameSell.Text = "-";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(1296, 40);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(53, 20);
            lblStock.TabIndex = 2;
            lblStock.Text = "STOCK";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(661, 40);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(58, 20);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "PRECIO";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(12, 40);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(180, 20);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "NOMBRE DEL PRODUCTO";
            // 
            // dgvShoppingCart
            // 
            dgvShoppingCart.AllowUserToAddRows = false;
            dgvShoppingCart.AllowUserToDeleteRows = false;
            dgvShoppingCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvShoppingCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShoppingCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShoppingCart.Location = new Point(3, 129);
            dgvShoppingCart.Name = "dgvShoppingCart";
            dgvShoppingCart.ReadOnly = true;
            dgvShoppingCart.RowHeadersWidth = 51;
            dgvShoppingCart.ShowCellToolTips = false;
            dgvShoppingCart.ShowEditingIcon = false;
            dgvShoppingCart.Size = new Size(1413, 119);
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
            panel2.Location = new Point(3, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(1413, 227);
            panel2.TabIndex = 8;
            // 
            // btnCancelItem
            // 
            btnCancelItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelItem.Location = new Point(864, 171);
            btnCancelItem.Name = "btnCancelItem";
            btnCancelItem.Size = new Size(166, 44);
            btnCancelItem.TabIndex = 7;
            btnCancelItem.Text = "QUITAR ITEM";
            btnCancelItem.UseVisualStyleBackColor = true;
            btnCancelItem.Click += btnCancelItem_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1324, 94);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(25, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "$0";
            // 
            // txtBarCodeSale
            // 
            txtBarCodeSale.Location = new Point(12, 16);
            txtBarCodeSale.Name = "txtBarCodeSale";
            txtBarCodeSale.Size = new Size(0, 27);
            txtBarCodeSale.TabIndex = 3;
            txtBarCodeSale.KeyDown += txtBarCodeSale_KeyDown;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(1314, 63);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 1;
            label4.Text = "TOTAL";
            // 
            // btnCancelSale
            // 
            btnCancelSale.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelSale.Location = new Point(1059, 171);
            btnCancelSale.Name = "btnCancelSale";
            btnCancelSale.Size = new Size(154, 44);
            btnCancelSale.TabIndex = 6;
            btnCancelSale.Text = "CANCELAR VENTA";
            btnCancelSale.UseVisualStyleBackColor = true;
            btnCancelSale.Click += btnCancelSale_Click;
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAccept.Location = new Point(1239, 171);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(158, 44);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "ACEPTAR";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // tabHistory
            // 
            tabHistory.Controls.Add(dgvDetails);
            tabHistory.Controls.Add(panel3);
            tabHistory.Controls.Add(dgvMaster);
            tabHistory.Location = new Point(4, 29);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(3);
            tabHistory.Size = new Size(1419, 484);
            tabHistory.TabIndex = 2;
            tabHistory.Text = "Histórico de Ventas";
            tabHistory.UseVisualStyleBackColor = true;
            // 
            // dgvDetails
            // 
            dgvDetails.AllowUserToAddRows = false;
            dgvDetails.AllowUserToDeleteRows = false;
            dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Dock = DockStyle.Fill;
            dgvDetails.Location = new Point(3, 200);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.ReadOnly = true;
            dgvDetails.RowHeadersWidth = 51;
            dgvDetails.ShowCellToolTips = false;
            dgvDetails.ShowEditingIcon = false;
            dgvDetails.Size = new Size(1413, 156);
            dgvDetails.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTotalClosing);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnRegisterClosing);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 356);
            panel3.Name = "panel3";
            panel3.Size = new Size(1413, 125);
            panel3.TabIndex = 1;
            // 
            // lblTotalClosing
            // 
            lblTotalClosing.AutoSize = true;
            lblTotalClosing.Location = new Point(66, 76);
            lblTotalClosing.Name = "lblTotalClosing";
            lblTotalClosing.Size = new Size(15, 20);
            lblTotalClosing.TabIndex = 2;
            lblTotalClosing.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 40);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 1;
            label1.Text = "Total del día";
            // 
            // btnRegisterClosing
            // 
            btnRegisterClosing.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegisterClosing.Location = new Point(1168, 40);
            btnRegisterClosing.Name = "btnRegisterClosing";
            btnRegisterClosing.Size = new Size(224, 56);
            btnRegisterClosing.TabIndex = 0;
            btnRegisterClosing.Text = "CIERRE DE CAJA";
            btnRegisterClosing.UseVisualStyleBackColor = true;
            // 
            // dgvMaster
            // 
            dgvMaster.AllowUserToAddRows = false;
            dgvMaster.AllowUserToDeleteRows = false;
            dgvMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaster.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaster.Dock = DockStyle.Top;
            dgvMaster.Location = new Point(3, 3);
            dgvMaster.Name = "dgvMaster";
            dgvMaster.ReadOnly = true;
            dgvMaster.RowHeadersWidth = 51;
            dgvMaster.ShowCellToolTips = false;
            dgvMaster.ShowEditingIcon = false;
            dgvMaster.Size = new Size(1413, 197);
            dgvMaster.TabIndex = 0;
            dgvMaster.SelectionChanged += dgvMaster_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 517);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Sistema de Inventario";
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
