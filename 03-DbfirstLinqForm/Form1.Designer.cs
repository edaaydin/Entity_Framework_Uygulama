namespace _03_DbfirstLinqForm
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
            dgvSonuc = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            button5 = new Button();
            label7 = new Label();
            button6 = new Button();
            label8 = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSonuc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 16);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 0;
            label1.Text = "Tüm müşterilerimi getir";
            // 
            // dgvSonuc
            // 
            dgvSonuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSonuc.Location = new Point(47, 553);
            dgvSonuc.Name = "dgvSonuc";
            dgvSonuc.RowHeadersWidth = 51;
            dgvSonuc.Size = new Size(936, 315);
            dgvSonuc.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(47, 49);
            button1.Name = "button1";
            button1.Size = new Size(147, 46);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 102);
            label2.Name = "label2";
            label2.Size = new Size(226, 20);
            label2.TabIndex = 0;
            label2.Text = "Müşterilerimin sadece adını getir";
            // 
            // button2
            // 
            button2.Location = new Point(47, 135);
            button2.Name = "button2";
            button2.Size = new Size(147, 46);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 191);
            label3.Name = "label3";
            label3.Size = new Size(292, 20);
            label3.TabIndex = 0;
            label3.Text = "Müşterilerimin sadece adını ve şehrini getir";
            // 
            // button3
            // 
            button3.Location = new Point(47, 224);
            button3.Name = "button3";
            button3.Size = new Size(147, 46);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 281);
            label4.Name = "label4";
            label4.Size = new Size(265, 20);
            label4.TabIndex = 0;
            label4.Text = "Müşterilerimin şehri London olanı getir";
            // 
            // button4
            // 
            button4.Location = new Point(47, 314);
            button4.Name = "button4";
            button4.Size = new Size(147, 46);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 366);
            label5.Name = "label5";
            label5.Size = new Size(415, 20);
            label5.TabIndex = 0;
            label5.Text = "Ürünlerimin fiyatı 50'den buyuk olanları pahalıdan ucuza getir";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 458);
            label6.Name = "label6";
            label6.Size = new Size(456, 20);
            label6.TabIndex = 0;
            label6.Text = "Çalışanlarımın ad, soyad, d.tarihi kolonlarıyla dyılına göre sıralı getir\r\n";
            // 
            // button5
            // 
            button5.Location = new Point(47, 399);
            button5.Name = "button5";
            button5.Size = new Size(147, 46);
            button5.TabIndex = 2;
            button5.Text = "button8";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(457, 12);
            label7.Name = "label7";
            label7.Size = new Size(207, 20);
            label7.TabIndex = 0;
            label7.Text = "Adında a olan müşterimi getir";
            // 
            // button6
            // 
            button6.Location = new Point(47, 491);
            button6.Name = "button6";
            button6.Size = new Size(147, 46);
            button6.TabIndex = 2;
            button6.Text = "button7";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(457, 102);
            label8.Name = "label8";
            label8.Size = new Size(433, 20);
            label8.TabIndex = 0;
            label8.Text = "Müşteri ad, çalışanAd, sipariş tarihi ve kargo şirketinin adını getir\r\n";
            // 
            // button7
            // 
            button7.Location = new Point(457, 45);
            button7.Name = "button7";
            button7.Size = new Size(147, 46);
            button7.TabIndex = 2;
            button7.Text = "button6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(457, 135);
            button8.Name = "button8";
            button8.Size = new Size(147, 46);
            button8.TabIndex = 2;
            button8.Text = "button5";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(457, 211);
            button9.Name = "button9";
            button9.Size = new Size(126, 46);
            button9.TabIndex = 3;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(457, 281);
            button10.Name = "button10";
            button10.Size = new Size(126, 48);
            button10.TabIndex = 4;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(489, 366);
            button11.Name = "button11";
            button11.Size = new Size(115, 52);
            button11.TabIndex = 5;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(535, 444);
            button12.Name = "button12";
            button12.Size = new Size(114, 49);
            button12.TabIndex = 6;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 880);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(dgvSonuc);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSonuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvSonuc;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Button button3;
        private Label label4;
        private Button button4;
        private Label label5;
        private Label label6;
        private Button button5;
        private Label label7;
        private Button button6;
        private Label label8;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}
