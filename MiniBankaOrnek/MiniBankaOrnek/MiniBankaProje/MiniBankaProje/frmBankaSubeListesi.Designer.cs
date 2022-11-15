
namespace MiniBankaProje
{
    partial class frmBankaSubeListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BankaSubeAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankaSubeKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BankaSubeAd,
            this.BankaSubeKodu,
            this.Tel,
            this.Faks,
            this.Adres});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // BankaSubeAd
            // 
            this.BankaSubeAd.DataPropertyName = "BankaSubeAd";
            this.BankaSubeAd.HeaderText = "Şube Adı";
            this.BankaSubeAd.Name = "BankaSubeAd";
            // 
            // BankaSubeKodu
            // 
            this.BankaSubeKodu.DataPropertyName = "BankaSubeKodu";
            this.BankaSubeKodu.HeaderText = "Şube Kodu";
            this.BankaSubeKodu.Name = "BankaSubeKodu";
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Telefon";
            this.Tel.Name = "Tel";
            // 
            // Faks
            // 
            this.Faks.DataPropertyName = "Faks";
            this.Faks.HeaderText = "Faks";
            this.Faks.Name = "Faks";
            // 
            // Adres
            // 
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Değişiklikleri Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBankaSubeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBankaSubeListesi";
            this.Text = "TBMYO BANK ŞUBELERİ";
            this.Load += new System.EventHandler(this.frmBankaSubeListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankaSubeAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankaSubeKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.Button button1;
    }
}