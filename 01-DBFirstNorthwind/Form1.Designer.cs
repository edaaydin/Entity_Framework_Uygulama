namespace _01_DBFirstNorthwind
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
            txtId = new TextBox();
            label2 = new Label();
            txtSirket = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            dgvMusteri = new DataGridView();
            chkSecim = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvMusteri).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 49);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "ID :";
            // 
            // txtId
            // 
            txtId.Location = new Point(141, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 114);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 0;
            label2.Text = "şirket Adı :";
            // 
            // txtSirket
            // 
            txtSirket.Location = new Point(141, 107);
            txtSirket.Name = "txtSirket";
            txtSirket.Size = new Size(125, 27);
            txtSirket.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(314, 49);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 2;
            btnEkle.Tag = "1";
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(445, 105);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 2;
            btnSil.Tag = "3";
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(314, 105);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Tag = "2";
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;

            // 
            // dgvMusteri
            // 
            dgvMusteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteri.Dock = DockStyle.Bottom;
            dgvMusteri.Location = new Point(0, 234);
            dgvMusteri.Name = "dgvMusteri";
            dgvMusteri.RowHeadersWidth = 51;
            dgvMusteri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMusteri.Size = new Size(810, 219);
            dgvMusteri.TabIndex = 3;
            dgvMusteri.CellMouseClick += dgvMusteri_CellMouseClick;
            // 
            // chkSecim
            // 
            chkSecim.AutoSize = true;
            chkSecim.Location = new Point(314, 168);
            chkSecim.Name = "chkSecim";
            chkSecim.Size = new Size(116, 24);
            chkSecim.TabIndex = 4;
            chkSecim.Text = "Seçimi kaldır";
            chkSecim.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 453);
            Controls.Add(chkSecim);
            Controls.Add(dgvMusteri);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtSirket);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtSirket;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private DataGridView dgvMusteri;
        private CheckBox chkSecim;
    }
}
