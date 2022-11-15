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
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kullanici yeniKullanici = new Kullanici();
            yeniKullanici.KullaniciTCNO = txtTCNO.Text;
            yeniKullanici.KullaniciAd = txtAd.Text;
            yeniKullanici.KullaniciSoyad = txtSoyad.Text;
            yeniKullanici.KullaniciRolId = Convert.ToInt32(cbYetkiRolu.SelectedValue);
            yeniKullanici.GirisAd = txtGirisAdi.Text;
            yeniKullanici.GirisSifre = txtGirisSifresi.Text;
            yeniKullanici.BankaSubeId = Convert.ToInt32(cbCalistigiBankaSubesi.SelectedValue);
            yeniKullanici.Gorev = txtGorev.Text;
            MiniBankaEntities vt = new MiniBankaEntities();
            vt.Kullanici.Add(yeniKullanici);
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
                MessageBox.Show("İşlem başarılı!");
            else
                MessageBox.Show("İşlem başarısız!");
        }

        private void frmKullaniciEkle_Load(object sender, EventArgs e)
        {
            //cbCalistigiSube ve cbYetkiRol comboboxlarını dolduralım
            MiniBankaEntities vt = new MiniBankaEntities();
            cbCalistigiBankaSubesi.DisplayMember = "BankaSubeAd";
            cbCalistigiBankaSubesi.ValueMember = "BankaSubeID";
            cbCalistigiBankaSubesi.DataSource = vt.BankaSube.ToList();

            cbYetkiRolu.DisplayMember = "KullaniciRolAd";
            cbYetkiRolu.ValueMember = "KullaniciRolID";
            cbYetkiRolu.DataSource = vt.KullaniciRol.ToList();
        }
    }
}
