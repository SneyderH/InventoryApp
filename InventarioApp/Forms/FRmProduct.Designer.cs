using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace InventarioApp.Forms
{
    partial class FRmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBarCode = new TextBox();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            nudPrice = new NumericUpDown();
            nudStock = new NumericUpDown();
            nudMinStock = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            lblBarCode = new Label();
            lblName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblMinStock = new Label();
            ((ISupportInitialize)nudPrice).BeginInit();
            ((ISupportInitialize)nudStock).BeginInit();
            ((ISupportInitialize)nudMinStock).BeginInit();
            SuspendLayout();
            // 
            // txtBarCode
            // 
            txtBarCode.Location = new Point(12, 42);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(150, 27);
            txtBarCode.TabIndex = 0;
            txtBarCode.KeyDown += txtBarCode_KeyDown;
            // 
            // txtName
            // 
            txtName.Location = new Point(203, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 27);
            txtName.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(380, 42);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 2;
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(578, 43);
            nudPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(150, 27);
            nudPrice.TabIndex = 3;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(203, 137);
            nudStock.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(150, 27);
            nudStock.TabIndex = 4;
            // 
            // nudMinStock
            // 
            nudMinStock.Location = new Point(381, 137);
            nudMinStock.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudMinStock.Name = "nudMinStock";
            nudMinStock.Size = new Size(150, 27);
            nudMinStock.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(190, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(173, 61);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(454, 296);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(174, 61);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblBarCode
            // 
            lblBarCode.AutoSize = true;
            lblBarCode.Location = new Point(28, 19);
            lblBarCode.Name = "lblBarCode";
            lblBarCode.Size = new Size(124, 20);
            lblBarCode.TabIndex = 8;
            lblBarCode.Text = "Código de Barras";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(239, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 20);
            lblName.TabIndex = 9;
            lblName.Text = "Nombre";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(420, 19);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(74, 20);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Categoría";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(623, 19);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 20);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(256, 114);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 12;
            lblStock.Text = "Stock";
            // 
            // lblMinStock
            // 
            lblMinStock.AutoSize = true;
            lblMinStock.Location = new Point(403, 114);
            lblMinStock.Name = "lblMinStock";
            lblMinStock.Size = new Size(100, 20);
            lblMinStock.TabIndex = 13;
            lblMinStock.Text = "Stock Mínimo";
            // 
            // FRmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMinStock);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            Controls.Add(lblBarCode);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(nudMinStock);
            Controls.Add(nudStock);
            Controls.Add(nudPrice);
            Controls.Add(cmbCategory);
            Controls.Add(txtName);
            Controls.Add(txtBarCode);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "FRmProduct";
            Text = "Producto";
            Load += FrmProduct_Load;
            ((ISupportInitialize)nudPrice).EndInit();
            ((ISupportInitialize)nudStock).EndInit();
            ((ISupportInitialize)nudMinStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBarCode;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private NumericUpDown nudPrice;
        private NumericUpDown nudStock;
        private NumericUpDown nudMinStock;
        private Button btnSave;
        private Button btnCancel;
        private Label lblBarCode;
        private Label lblName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;
        private Label lblMinStock;
    }
}