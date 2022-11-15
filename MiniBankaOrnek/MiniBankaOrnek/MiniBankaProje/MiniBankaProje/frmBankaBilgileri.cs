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
    public partial class frmBankaBilgileri : Form
    {
        public frmBankaBilgileri()
        {
            InitializeComponent();
        }

        private void frmBankaBilgileri_Load(object sender, EventArgs e)
        {
            //banka bilgisi kayıtlı mı? kayıtlı ise ekrandaki kontrollere doldur
            MiniBankaEntities vt = new MiniBankaEntities();
            bankaBilgisi = vt.Banka.SingleOrDefault(); //ilk kaydı döndür
            if (bankaBilgisi != null) //bankabilgisi null değil yani kayıt var. Ekrana bilgileri bas
            {
                txtBankaAd.Text = bankaBilgisi.BankaAd;
                txtBankaKod.Text = bankaBilgisi.BankaKodu;
                txtTelefon.Text = bankaBilgisi.Tel;
                txtFaks.Text = bankaBilgisi.Faks;
                txtAdres.Text = bankaBilgisi.Adres;
            }
        }

        Banka bankaBilgisi = null;

        private void button1_Click(object sender, EventArgs e)
        {
            MiniBankaEntities vt = new MiniBankaEntities();
            if (bankaBilgisi != null)
            { //bankabilgisi var. Değişiklik varsa güncelleme yapılacak
                bankaBilgisi = vt.Banka.FirstOrDefault(p => p.BankaID == bankaBilgisi.BankaID);
                bankaBilgisi.BankaAd = txtBankaAd.Text;
                bankaBilgisi.BankaKodu = txtBankaKod.Text;
                bankaBilgisi.Tel = txtTelefon.Text;
                bankaBilgisi.Faks = txtFaks.Text;
                bankaBilgisi.Adres = txtAdres.Text;
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                    MessageBox.Show("İşlem başarılı!");
                else
                    MessageBox.Show("İşlem başarısız!");
            }
            else
            { //bankabilgisi null yani kayıt yok. Yeni kayıt yapılacak
                bankaBilgisi = new Banka();
                bankaBilgisi.BankaAd = txtBankaAd.Text;
                bankaBilgisi.BankaKodu = txtBankaKod.Text;
                bankaBilgisi.Tel = txtTelefon.Text;
                bankaBilgisi.Faks = txtFaks.Text;
                bankaBilgisi.Adres = txtAdres.Text;
                vt.Banka.Add(bankaBilgisi);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                    MessageBox.Show("İşlem başarılı!");
                else
                    MessageBox.Show("İşlem başarısız!");
            }
        }
    }
}
