
namespace MiniBankaProje
{
    partial class frmHesapHareket
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
            this.lblMusteriAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.txtMusteriNoVeyaTCNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMusteriHesaplari = new System.Windows.Forms.ComboBox();
            this.cbIslemTuru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbParaYatirma = new System.Windows.Forms.RadioButton();
            this.rbParaCekme = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIslemTutari = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIslemAciklamasi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMusteriAdSoyad
            // 
            this.lblMusteriAdSoyad.AutoSize = true;
            this.lblMusteriAdSoyad.Location = new System.Drawing.Point(140, 46);
            this.lblMusteriAdSoyad.Name = "lblMusteriAdSoyad";
            this.lblMusteriAdSoyad.Size = new System.Drawing.Size(0, 13);
            this.lblMusteriAdSoyad.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Müşteri Adı Soyadı:";
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(387, 12);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(75, 23);
            this.btnSorgula.TabIndex = 7;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // txtMusteriNoVeyaTCNo
            // 
            this.txtMusteriNoVeyaTCNo.Location = new System.Drawing.Point(140, 12);
            this.txtMusteriNoVeyaTCNo.Name = "txtMusteriNoVeyaTCNo";
            this.txtMusteriNoVeyaTCNo.Size = new System.Drawing.Size(231, 20);
            this.txtMusteriNoVeyaTCNo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Müşteri No/TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Müşteri Hesapları:";
            // 
            // cbMusteriHesaplari
            // 
            this.cbMusteriHesaplari.FormattingEnabled = true;
            this.cbMusteriHesaplari.Location = new System.Drawing.Point(140, 78);
            this.cbMusteriHesaplari.Name = "cbMusteriHesaplari";
            this.cbMusteriHesaplari.Size = new System.Drawing.Size(322, 21);
            this.cbMusteriHesaplari.TabIndex = 11;
            // 
            // cbIslemTuru
            // 
            this.cbIslemTuru.FormattingEnabled = true;
            this.cbIslemTuru.Location = new System.Drawing.Point(140, 105);
            this.cbIslemTuru.Name = "cbIslemTuru";
            this.cbIslemTuru.Size = new System.Drawing.Size(322, 21);
            this.cbIslemTuru.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "İşlem Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "İşlem Yönü:";
            // 
            // rbParaYatirma
            // 
            this.rbParaYatirma.AutoSize = true;
            this.rbParaYatirma.Checked = true;
            this.rbParaYatirma.Location = new System.Drawing.Point(140, 145);
            this.rbParaYatirma.Name = "rbParaYatirma";
            this.rbParaYatirma.Size = new System.Drawing.Size(85, 17);
            this.rbParaYatirma.TabIndex = 15;
            this.rbParaYatirma.TabStop = true;
            this.rbParaYatirma.Text = "Para Yatırma";
            this.rbParaYatirma.UseVisualStyleBackColor = true;
            // 
            // rbParaCekme
            // 
            this.rbParaCekme.AutoSize = true;
            this.rbParaCekme.Location = new System.Drawing.Point(252, 145);
            this.rbParaCekme.Name = "rbParaCekme";
            this.rbParaCekme.Size = new System.Drawing.Size(83, 17);
            this.rbParaCekme.TabIndex = 16;
            this.rbParaCekme.TabStop = true;
            this.rbParaCekme.Text = "Para Çekme";
            this.rbParaCekme.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "İşlem Tutarı:";
            // 
            // txtIslemTutari
            // 
            this.txtIslemTutari.Location = new System.Drawing.Point(143, 181);
            this.txtIslemTutari.Name = "txtIslemTutari";
            this.txtIslemTutari.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIslemTutari.Size = new System.Drawing.Size(192, 20);
            this.txtIslemTutari.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "İşlem Açıklaması:";
            // 
            // txtIslemAciklamasi
            // 
            this.txtIslemAciklamasi.Location = new System.Drawing.Point(140, 221);
            this.txtIslemAciklamasi.Multiline = true;
            this.txtIslemAciklamasi.Name = "txtIslemAciklamasi";
            this.txtIslemAciklamasi.Size = new System.Drawing.Size(322, 72);
            this.txtIslemAciklamasi.TabIndex = 20;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(140, 313);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmHesapHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 386);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtIslemAciklamasi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIslemTutari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbParaCekme);
            this.Controls.Add(this.rbParaYatirma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbIslemTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMusteriHesaplari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMusteriAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.txtMusteriNoVeyaTCNo);
            this.Controls.Add(this.label1);
            this.Name = "frmHesapHareket";
            this.Text = "Para Yatırma Çekme İşlemleri";
            this.Load += new System.EventHandler(this.frmHesapHareket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.TextBox txtMusteriNoVeyaTCNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMusteriHesaplari;
        private System.Windows.Forms.ComboBox cbIslemTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbParaYatirma;
        private System.Windows.Forms.RadioButton rbParaCekme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIslemTutari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIslemAciklamasi;
        private System.Windows.Forms.Button btnKaydet;
    }
}