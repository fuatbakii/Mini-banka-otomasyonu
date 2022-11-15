
namespace MiniBankaProje
{
    partial class frmHesapEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriNoVeyaTCNo = new System.Windows.Forms.TextBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMusteriAdSoyad = new System.Windows.Forms.Label();
            this.cbHesapTuru = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHesapAd = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtHesapAcilisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri No/TC No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMusteriNoVeyaTCNo
            // 
            this.txtMusteriNoVeyaTCNo.Location = new System.Drawing.Point(153, 10);
            this.txtMusteriNoVeyaTCNo.Name = "txtMusteriNoVeyaTCNo";
            this.txtMusteriNoVeyaTCNo.Size = new System.Drawing.Size(231, 20);
            this.txtMusteriNoVeyaTCNo.TabIndex = 1;
            this.txtMusteriNoVeyaTCNo.TextChanged += new System.EventHandler(this.txtMusteriNoVeyaTCNo_TextChanged);
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(400, 10);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(75, 23);
            this.btnSorgula.TabIndex = 2;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri Adı Soyadı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMusteriAdSoyad
            // 
            this.lblMusteriAdSoyad.AutoSize = true;
            this.lblMusteriAdSoyad.Location = new System.Drawing.Point(153, 44);
            this.lblMusteriAdSoyad.Name = "lblMusteriAdSoyad";
            this.lblMusteriAdSoyad.Size = new System.Drawing.Size(0, 13);
            this.lblMusteriAdSoyad.TabIndex = 4;
            this.lblMusteriAdSoyad.Click += new System.EventHandler(this.lblMusteriAdSoyad_Click);
            // 
            // cbHesapTuru
            // 
            this.cbHesapTuru.FormattingEnabled = true;
            this.cbHesapTuru.Location = new System.Drawing.Point(153, 71);
            this.cbHesapTuru.Name = "cbHesapTuru";
            this.cbHesapTuru.Size = new System.Drawing.Size(231, 21);
            this.cbHesapTuru.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hesap Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hesap Adı:";
            // 
            // txtHesapAd
            // 
            this.txtHesapAd.Location = new System.Drawing.Point(153, 107);
            this.txtHesapAd.MaxLength = 50;
            this.txtHesapAd.Name = "txtHesapAd";
            this.txtHesapAd.Size = new System.Drawing.Size(231, 20);
            this.txtHesapAd.TabIndex = 8;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(153, 137);
            this.txtHesapNo.MaxLength = 16;
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(231, 20);
            this.txtHesapNo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hesap No:";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Enabled = false;
            this.btnOlustur.Location = new System.Drawing.Point(400, 134);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 11;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "IBAN:";
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Location = new System.Drawing.Point(153, 181);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(0, 13);
            this.lblIBAN.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hesap Açılış Tarihi:";
            // 
            // dtHesapAcilisTarihi
            // 
            this.dtHesapAcilisTarihi.Location = new System.Drawing.Point(153, 207);
            this.dtHesapAcilisTarihi.Name = "dtHesapAcilisTarihi";
            this.dtHesapAcilisTarihi.Size = new System.Drawing.Size(231, 20);
            this.dtHesapAcilisTarihi.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bakiye:";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(153, 253);
            this.txtBakiye.MaxLength = 20;
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBakiye.Size = new System.Drawing.Size(228, 20);
            this.txtBakiye.TabIndex = 17;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(153, 298);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmHesapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 357);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtHesapAcilisTarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblIBAN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHesapAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbHesapTuru);
            this.Controls.Add(this.lblMusteriAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.txtMusteriNoVeyaTCNo);
            this.Controls.Add(this.label1);
            this.Name = "frmHesapEkle";
            this.Text = "Yeni Hesap Oluştur";
            this.Load += new System.EventHandler(this.frmHesapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriNoVeyaTCNo;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMusteriAdSoyad;
        private System.Windows.Forms.ComboBox cbHesapTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHesapAd;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtHesapAcilisTarihi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Button btnKaydet;
    }
}