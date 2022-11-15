using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBankaProje
{
    public partial class frmBankaSubeListesi : Form
    {
        public frmBankaSubeListesi()
        {
            InitializeComponent();
        }

        private void frmBankaSubeListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false; //ekstra alan yani kolon oluşturmasın
            MiniBankaEntities vt = new MiniBankaEntities();
            dataGridView1.DataSource = vt.BankaSube.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiniBankaEntities vt = new MiniBankaEntities();
            List<BankaSube> orjinalSubeListesi = vt.BankaSube.ToList();
            List<BankaSube> griddekiSubeListesi = dataGridView1.DataSource as List<BankaSube>;
            foreach (var orjinalSube in orjinalSubeListesi)
            {
                foreach (var gridSube in griddekiSubeListesi)
                {
                    if (orjinalSube.BankaSubeID == gridSube.BankaSubeID)
                    {
                        orjinalSube.BankaSubeAd = gridSube.BankaSubeAd;
                        orjinalSube.BankaSubeKodu = gridSube.BankaSubeKodu;
                        orjinalSube.Tel = gridSube.Tel;
                        orjinalSube.Faks = gridSube.Faks;
                        orjinalSube.Adres = gridSube.Adres;
                    }
                }
            }
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
                MessageBox.Show("İşlem başarılı!");
            else
                MessageBox.Show("İşlem başarısız!");
        }
    }
}
