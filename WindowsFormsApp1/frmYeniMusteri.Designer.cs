namespace WindowsFormsApp1
{
    partial class FrmYeniMusteri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.txtKimlikNo = new System.Windows.Forms.TextBox();
            this.mskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOda109 = new System.Windows.Forms.Button();
            this.btnOda108 = new System.Windows.Forms.Button();
            this.btnOda107 = new System.Windows.Forms.Button();
            this.btnOda106 = new System.Windows.Forms.Button();
            this.btnOda105 = new System.Windows.Forms.Button();
            this.btnOda104 = new System.Windows.Forms.Button();
            this.btnOda103 = new System.Windows.Forms.Button();
            this.btnOda102 = new System.Windows.Forms.Button();
            this.btnOda101 = new System.Windows.Forms.Button();
            this.btnDoluOda = new System.Windows.Forms.Button();
            this.btnBosOda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUcret);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.DtpCikisTarihi);
            this.groupBox1.Controls.Add(this.DtpGirisTarihi);
            this.groupBox1.Controls.Add(this.txtOdaNo);
            this.groupBox1.Controls.Add(this.txtKimlikNo);
            this.groupBox1.Controls.Add(this.mskTxtTelefon);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "0";
            this.label11.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.comboBox1.Location = new System.Drawing.Point(170, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cinsiyeti:";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(167, 279);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(200, 22);
            this.txtUcret.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ücret:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(191, 401);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(94, 37);
            this.btnKaydet.TabIndex = 33;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Location = new System.Drawing.Point(167, 348);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(200, 22);
            this.DtpCikisTarihi.TabIndex = 32;
            this.DtpCikisTarihi.ValueChanged += new System.EventHandler(this.DtpCikisTarihi_ValueChanged);
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Location = new System.Drawing.Point(167, 311);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(200, 22);
            this.DtpGirisTarihi.TabIndex = 31;
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Enabled = false;
            this.txtOdaNo.Location = new System.Drawing.Point(167, 243);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(200, 22);
            this.txtOdaNo.TabIndex = 30;
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.Location = new System.Drawing.Point(167, 214);
            this.txtKimlikNo.MaxLength = 11;
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(200, 22);
            this.txtKimlikNo.TabIndex = 29;
            // 
            // mskTxtTelefon
            // 
            this.mskTxtTelefon.Location = new System.Drawing.Point(167, 140);
            this.mskTxtTelefon.Mask = "(999) 000-0000";
            this.mskTxtTelefon.Name = "mskTxtTelefon";
            this.mskTxtTelefon.Size = new System.Drawing.Size(200, 22);
            this.mskTxtTelefon.TabIndex = 28;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(167, 180);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 22);
            this.txtMail.TabIndex = 27;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(167, 74);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(200, 22);
            this.txtSoyadi.TabIndex = 26;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(167, 35);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(200, 22);
            this.txtAdi.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Çıkış Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Giriş Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Oda Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "T.C.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOda109);
            this.groupBox2.Controls.Add(this.btnOda108);
            this.groupBox2.Controls.Add(this.btnOda107);
            this.groupBox2.Controls.Add(this.btnOda106);
            this.groupBox2.Controls.Add(this.btnOda105);
            this.groupBox2.Controls.Add(this.btnOda104);
            this.groupBox2.Controls.Add(this.btnOda103);
            this.groupBox2.Controls.Add(this.btnOda102);
            this.groupBox2.Controls.Add(this.btnOda101);
            this.groupBox2.Location = new System.Drawing.Point(487, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 412);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // btnOda109
            // 
            this.btnOda109.BackColor = System.Drawing.Color.Lime;
            this.btnOda109.Location = new System.Drawing.Point(355, 255);
            this.btnOda109.Name = "btnOda109";
            this.btnOda109.Size = new System.Drawing.Size(75, 55);
            this.btnOda109.TabIndex = 8;
            this.btnOda109.Text = "109";
            this.btnOda109.UseVisualStyleBackColor = false;
            this.btnOda109.Click += new System.EventHandler(this.btnOda109_Click);
            // 
            // btnOda108
            // 
            this.btnOda108.BackColor = System.Drawing.Color.Lime;
            this.btnOda108.Location = new System.Drawing.Point(197, 255);
            this.btnOda108.Name = "btnOda108";
            this.btnOda108.Size = new System.Drawing.Size(75, 55);
            this.btnOda108.TabIndex = 7;
            this.btnOda108.Text = "108";
            this.btnOda108.UseVisualStyleBackColor = false;
            this.btnOda108.Click += new System.EventHandler(this.btnOda108_Click);
            // 
            // btnOda107
            // 
            this.btnOda107.BackColor = System.Drawing.Color.Lime;
            this.btnOda107.Location = new System.Drawing.Point(48, 255);
            this.btnOda107.Name = "btnOda107";
            this.btnOda107.Size = new System.Drawing.Size(75, 55);
            this.btnOda107.TabIndex = 6;
            this.btnOda107.Text = "107";
            this.btnOda107.UseVisualStyleBackColor = false;
            this.btnOda107.Click += new System.EventHandler(this.btnOda107_Click);
            // 
            // btnOda106
            // 
            this.btnOda106.BackColor = System.Drawing.Color.Lime;
            this.btnOda106.Location = new System.Drawing.Point(355, 147);
            this.btnOda106.Name = "btnOda106";
            this.btnOda106.Size = new System.Drawing.Size(75, 55);
            this.btnOda106.TabIndex = 5;
            this.btnOda106.Text = "106";
            this.btnOda106.UseVisualStyleBackColor = false;
            this.btnOda106.Click += new System.EventHandler(this.btnOda106_Click);
            // 
            // btnOda105
            // 
            this.btnOda105.BackColor = System.Drawing.Color.Lime;
            this.btnOda105.Location = new System.Drawing.Point(197, 147);
            this.btnOda105.Name = "btnOda105";
            this.btnOda105.Size = new System.Drawing.Size(75, 55);
            this.btnOda105.TabIndex = 4;
            this.btnOda105.Text = "105";
            this.btnOda105.UseVisualStyleBackColor = false;
            this.btnOda105.Click += new System.EventHandler(this.btnOda105_Click);
            // 
            // btnOda104
            // 
            this.btnOda104.BackColor = System.Drawing.Color.Lime;
            this.btnOda104.Location = new System.Drawing.Point(48, 147);
            this.btnOda104.Name = "btnOda104";
            this.btnOda104.Size = new System.Drawing.Size(75, 55);
            this.btnOda104.TabIndex = 3;
            this.btnOda104.Text = "104";
            this.btnOda104.UseVisualStyleBackColor = false;
            this.btnOda104.Click += new System.EventHandler(this.btnOda104_Click);
            // 
            // btnOda103
            // 
            this.btnOda103.BackColor = System.Drawing.Color.Lime;
            this.btnOda103.Location = new System.Drawing.Point(355, 39);
            this.btnOda103.Name = "btnOda103";
            this.btnOda103.Size = new System.Drawing.Size(75, 55);
            this.btnOda103.TabIndex = 2;
            this.btnOda103.Text = "103";
            this.btnOda103.UseVisualStyleBackColor = false;
            this.btnOda103.Click += new System.EventHandler(this.btnOda103_Click);
            // 
            // btnOda102
            // 
            this.btnOda102.BackColor = System.Drawing.Color.Lime;
            this.btnOda102.Location = new System.Drawing.Point(197, 39);
            this.btnOda102.Name = "btnOda102";
            this.btnOda102.Size = new System.Drawing.Size(75, 55);
            this.btnOda102.TabIndex = 1;
            this.btnOda102.Text = "102";
            this.btnOda102.UseVisualStyleBackColor = false;
            this.btnOda102.Click += new System.EventHandler(this.btnOda102_Click);
            // 
            // btnOda101
            // 
            this.btnOda101.BackColor = System.Drawing.Color.Lime;
            this.btnOda101.Location = new System.Drawing.Point(48, 36);
            this.btnOda101.Name = "btnOda101";
            this.btnOda101.Size = new System.Drawing.Size(75, 55);
            this.btnOda101.TabIndex = 0;
            this.btnOda101.Text = "101";
            this.btnOda101.UseVisualStyleBackColor = false;
            this.btnOda101.Click += new System.EventHandler(this.btnOda101_Click);
            // 
            // btnDoluOda
            // 
            this.btnDoluOda.BackColor = System.Drawing.Color.Red;
            this.btnDoluOda.Location = new System.Drawing.Point(842, 440);
            this.btnDoluOda.Name = "btnDoluOda";
            this.btnDoluOda.Size = new System.Drawing.Size(75, 55);
            this.btnDoluOda.TabIndex = 9;
            this.btnDoluOda.Text = "DOLU";
            this.btnDoluOda.UseVisualStyleBackColor = false;
            this.btnDoluOda.Click += new System.EventHandler(this.btnDoluOda_Click);
            // 
            // btnBosOda
            // 
            this.btnBosOda.BackColor = System.Drawing.Color.Lime;
            this.btnBosOda.Location = new System.Drawing.Point(930, 440);
            this.btnBosOda.Name = "btnBosOda";
            this.btnBosOda.Size = new System.Drawing.Size(75, 55);
            this.btnBosOda.TabIndex = 10;
            this.btnBosOda.Text = "BOŞ";
            this.btnBosOda.UseVisualStyleBackColor = false;
            this.btnBosOda.Click += new System.EventHandler(this.btnBosOda_Click);
            // 
            // FrmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1038, 516);
            this.Controls.Add(this.btnDoluOda);
            this.Controls.Add(this.btnBosOda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmYeniMusteri";
            this.Text = "Yeni Müşteri Kayıt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.TextBox txtKimlikNo;
        private System.Windows.Forms.MaskedTextBox mskTxtTelefon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOda109;
        private System.Windows.Forms.Button btnOda108;
        private System.Windows.Forms.Button btnOda107;
        private System.Windows.Forms.Button btnOda106;
        private System.Windows.Forms.Button btnOda105;
        private System.Windows.Forms.Button btnOda104;
        private System.Windows.Forms.Button btnOda103;
        private System.Windows.Forms.Button btnOda102;
        private System.Windows.Forms.Button btnOda101;
        private System.Windows.Forms.Button btnDoluOda;
        private System.Windows.Forms.Button btnBosOda;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}