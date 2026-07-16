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
            txtBarCode.Location = new Point(16, 59);
            txtBarCode.Margin = new Padding(4, 3, 4, 3);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(226, 30);
            txtBarCode.TabIndex = 0;
            txtBarCode.KeyDown += txtBarCode_KeyDown;
            // 
            // txtName
            // 
            txtName.Location = new Point(279, 59);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 30);
            txtName.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(612, 60);
            cmbCategory.Margin = new Padding(4, 3, 4, 3);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(206, 29);
            cmbCategory.TabIndex = 2;
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(881, 58);
            nudPrice.Margin = new Padding(4, 3, 4, 3);
            nudPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(206, 30);
            nudPrice.TabIndex = 3;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(279, 146);
            nudStock.Margin = new Padding(4, 3, 4, 3);
            nudStock.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(206, 30);
            nudStock.TabIndex = 4;
            // 
            // nudMinStock
            // 
            nudMinStock.Location = new Point(612, 144);
            nudMinStock.Margin = new Padding(4, 3, 4, 3);
            nudMinStock.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudMinStock.Name = "nudMinStock";
            nudMinStock.Size = new Size(206, 30);
            nudMinStock.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(247, 268);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(238, 64);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Location = new Point(612, 268);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(239, 64);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblBarCode
            // 
            lblBarCode.AutoSize = true;
            lblBarCode.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblBarCode.Location = new Point(38, 20);
            lblBarCode.Margin = new Padding(4, 0, 4, 0);
            lblBarCode.Name = "lblBarCode";
            lblBarCode.Size = new Size(180, 23);
            lblBarCode.TabIndex = 8;
            lblBarCode.Text = "Código de Barras";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblName.Location = new Point(329, 20);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(89, 23);
            lblName.TabIndex = 9;
            lblName.Text = "Nombre";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblCategory.Location = new Point(660, 21);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(108, 23);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Categoría";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblPrice.Location = new Point(944, 20);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(71, 23);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblStock.Location = new Point(352, 120);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(64, 23);
            lblStock.TabIndex = 12;
            lblStock.Text = "Stock";
            // 
            // lblMinStock
            // 
            lblMinStock.AutoSize = true;
            lblMinStock.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblMinStock.Location = new Point(642, 120);
            lblMinStock.Margin = new Padding(4, 0, 4, 0);
            lblMinStock.Name = "lblMinStock";
            lblMinStock.Size = new Size(142, 23);
            lblMinStock.TabIndex = 13;
            lblMinStock.Text = "Stock Mínimo";
            // 
            // FRmProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 403);
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
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
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