namespace _02_DbFirstOdev
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
            label1 = new Label();
            label2 = new Label();
            txtPName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            chkDisc = new CheckBox();
            chkDeselect = new CheckBox();
            cmbCategory = new ComboBox();
            cmbSupplier = new ComboBox();
            txtQuantity = new TextBox();
            nudPrice = new NumericUpDown();
            nudStock = new NumericUpDown();
            nudOrder = new NumericUpDown();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgbProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgbProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 52);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "ProductName :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 102);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 0;
            label2.Text = "Category Id :";
            // 
            // txtPName
            // 
            txtPName.Location = new Point(236, 47);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(239, 27);
            txtPName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 167);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 0;
            label3.Text = "Supplier Id :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 229);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 0;
            label4.Text = "Quantity :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(521, 52);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 0;
            label5.Text = "Unit Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(521, 109);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 0;
            label6.Text = "Unit Stock :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(521, 168);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 0;
            label7.Text = "Unit Order :";
            // 
            // chkDisc
            // 
            chkDisc.AutoSize = true;
            chkDisc.Location = new Point(521, 228);
            chkDisc.Name = "chkDisc";
            chkDisc.Size = new Size(118, 24);
            chkDisc.TabIndex = 2;
            chkDisc.Text = "Discontinued";
            chkDisc.UseVisualStyleBackColor = true;
            // 
            // chkDeselect
            // 
            chkDeselect.AutoSize = true;
            chkDeselect.Location = new Point(675, 228);
            chkDeselect.Name = "chkDeselect";
            chkDeselect.Size = new Size(88, 24);
            chkDeselect.TabIndex = 2;
            chkDeselect.Text = "Deselect";
            chkDeselect.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(236, 99);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(239, 28);
            cmbCategory.TabIndex = 3;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(236, 160);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(239, 28);
            cmbSupplier.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(236, 226);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(239, 27);
            txtQuantity.TabIndex = 4;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(660, 45);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(150, 27);
            nudPrice.TabIndex = 5;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(660, 102);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(150, 27);
            nudStock.TabIndex = 5;
            // 
            // nudOrder
            // 
            nudOrder.Location = new Point(660, 160);
            nudOrder.Name = "nudOrder";
            nudOrder.Size = new Size(150, 27);
            nudOrder.TabIndex = 5;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(116, 291);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(153, 52);
            btnEkle.TabIndex = 6;
            btnEkle.Tag = "1";
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(398, 291);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(153, 52);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Tag = "2";
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(675, 291);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(153, 52);
            btnSil.TabIndex = 6;
            btnSil.Tag = "3";
            btnSil.Text = "Sİl";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // dgbProducts
            // 
            dgbProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbProducts.Dock = DockStyle.Bottom;
            dgbProducts.Location = new Point(0, 393);
            dgbProducts.Name = "dgbProducts";
            dgbProducts.RowHeadersWidth = 51;
            dgbProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgbProducts.Size = new Size(1139, 300);
            dgbProducts.TabIndex = 7;
            dgbProducts.CellMouseClick += dgbProducts_CellMouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 693);
            Controls.Add(dgbProducts);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(nudOrder);
            Controls.Add(nudStock);
            Controls.Add(nudPrice);
            Controls.Add(txtQuantity);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbCategory);
            Controls.Add(chkDeselect);
            Controls.Add(chkDisc);
            Controls.Add(txtPName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgbProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox chkDisc;
        private CheckBox chkDeselect;
        private ComboBox cmbCategory;
        private ComboBox cmbSupplier;
        private TextBox txtQuantity;
        private NumericUpDown nudPrice;
        private NumericUpDown nudStock;
        private NumericUpDown nudOrder;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgbProducts;
    }
}
