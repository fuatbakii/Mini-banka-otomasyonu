
namespace MiniBankaProje
{
    partial class frmBankaSubeEkleme
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
            this.cbBanka = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFaks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBankaSubeKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBankaSubeAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banka:";
            // 
            // cbBanka
            // 
            this.cbBanka.FormattingEnabled = true;
            this.cbBanka.Location = new System.Drawing.Point(128, 13);
            this.cbBanka.Name = "cbBanka";
            this.cbBanka.Size = new System.Drawing.Size(356, 21);
            this.cbBanka.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(128, 151);
            this.txtAdres.MaxLength = 100;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(356, 95);
            this.txtAdres.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Banka Adresi:";
            // 
            // txtFaks
            // 
            this.txtFaks.Location = new System.Drawing.Point(128, 119);
            this.txtFaks.MaxLength = 11;
            this.txtFaks.Name = "txtFaks";
            this.txtFaks.Size = new System.Drawing.Size(148, 20);
            this.txtFaks.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Banka Faks:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(128, 93);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(148, 20);
            this.txtTelefon.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Banka Telefon:";
            // 
            // txtBankaSubeKod
            // 
            this.txtBankaSubeKod.Location = new System.Drawing.Point(128, 66);
            this.txtBankaSubeKod.MaxLength = 4;
            this.txtBankaSubeKod.Name = "txtBankaSubeKod";
            this.txtBankaSubeKod.Size = new System.Drawing.Size(148, 20);
            this.txtBankaSubeKod.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şube Kodu:";
            // 
            // txtBankaSubeAd
            // 
            this.txtBankaSubeAd.Location = new System.Drawing.Point(128, 40);
            this.txtBankaSubeAd.MaxLength = 100;
            this.txtBankaSubeAd.Name = "txtBankaSubeAd";
            this.txtBankaSubeAd.Size = new System.Drawing.Size(356, 20);
            this.txtBankaSubeAd.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Şube Adı:";
            // 
            // frmBankaSubeEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFaks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBankaSubeKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBankaSubeAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBanka);
            this.Controls.Add(this.label1);
            this.Name = "frmBankaSubeEkleme";
            this.Text = "Banka Şubesi Ekleme";
            this.Load += new System.EventHandler(this.frmBankaSubeEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBanka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFaks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBankaSubeKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBankaSubeAd;
        private System.Windows.Forms.Label label6;
    }
}