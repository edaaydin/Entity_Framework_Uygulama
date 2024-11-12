namespace _04_CodeFirstPhoneBook
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
            groupBox1 = new GroupBox();
            btnEkle = new Button();
            label4 = new Label();
            label3 = new Label();
            txtTel = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lsvContacts = new ListView();
            groupBox2 = new GroupBox();
            btnGuncelle = new Button();
            btnAra = new Button();
            label6 = new Label();
            label5 = new Label();
            txtAra = new TextBox();
            btnYenile = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTel);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 356);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(114, 277);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(125, 46);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += Mylick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 236);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 178);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Soyad :";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(114, 229);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(125, 27);
            txtTel.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(114, 171);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(114, 106);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 113);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 51);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Yeni Oluştur";
            // 
            // lsvContacts
            // 
            lsvContacts.Location = new Point(39, 427);
            lsvContacts.Name = "lsvContacts";
            lsvContacts.Size = new Size(766, 235);
            lsvContacts.TabIndex = 1;
            lsvContacts.UseCompatibleStateImageBehavior = false;
            lsvContacts.ItemSelectionChanged += lsvContacts_ItemSelectionChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGuncelle);
            groupBox2.Controls.Add(btnAra);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtAra);
            groupBox2.Location = new Point(343, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(462, 272);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(23, 203);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(155, 30);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += Mylick;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(290, 125);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(155, 30);
            btnAra.TabIndex = 4;
            btnAra.Text = "Kişi Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += Mylick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 88);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 3;
            label6.Text = "Ad ve Soyad :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 43);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 0;
            label5.Text = "Bul";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(23, 125);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(247, 27);
            txtAra.TabIndex = 2;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(661, 340);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(144, 42);
            btnYenile.TabIndex = 3;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += Mylick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 680);
            Controls.Add(btnYenile);
            Controls.Add(groupBox2);
            Controls.Add(lsvContacts);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEkle;
        private Label label4;
        private Label label3;
        private TextBox txtTel;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label2;
        private Label label1;
        private ListView lsvContacts;
        private GroupBox groupBox2;
        private Button btnAra;
        private Label label6;
        private Label label5;
        private TextBox txtAra;
        private Button btnGuncelle;
        private Button btnYenile;
    }
}
