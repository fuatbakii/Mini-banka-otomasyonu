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
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void frmAnaEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void TumMenuleriGizle()
        {
            menuSistemAdmin.Visible = false;
            menuGiseGorevlisi.Visible = false;
        }


        enum RolKodlari
        {
            SistemAdmin,
            BankaMuduru,
            SubeMuduru,
            GiseGorevlisi,
            OperasyonSorumlusu,
            MusteriHizmetleriSorumlusu
        }

        public frmAnaEkran(vKullanici girisYapanKullanici)
        {
            InitializeComponent();
            TumMenuleriGizle();

            if(girisYapanKullanici.KullaniciRolKod==RolKodlari.SistemAdmin.ToString())
            {
                menuSistemAdmin.Visible = true;
            }

            if(girisYapanKullanici.KullaniciRolKod==RolKodlari.GiseGorevlisi.ToString())
            {
                menuGiseGorevlisi.Visible = true;
            }
        }

        private void bankaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBankaBilgileri bankaBilgileri = new frmBankaBilgileri();
            bankaBilgileri.MdiParent = this; //formu ana ekran içinde açılmasını sağlar
            bankaBilgileri.Show();
        }

        private void yeniŞubeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBankaSubeEkleme bankaSubeEkleme = new frmBankaSubeEkleme();
            bankaSubeEkleme.MdiParent = this;
            bankaSubeEkleme.Show();
        }

        private void şubeListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBankaSubeListesi bankaSubeListesi = new frmBankaSubeListesi();
            bankaSubeListesi.MdiParent = this;
            bankaSubeListesi.Show();
        }

        private void yeniKullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle kullaniciEkle = new frmKullaniciEkle();
            kullaniciEkle.MdiParent = this;
            kullaniciEkle.Show();
        }

        private void kullanıcıListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciListesi kullaniciListesi = new frmKullaniciListesi();
            kullaniciListesi.MdiParent = this;
            kullaniciListesi.Show();
        }

        private void yeniMüşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriEkle yeniMusteriEkle = new frmMusteriEkle();
            yeniMusteriEkle.MdiParent = this;
            yeniMusteriEkle.Show();
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriListesi musteriListesi = new frmMusteriListesi();
            musteriListesi.MdiParent = this;
            musteriListesi.Show();
        }

        private void yeniHesapOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapEkle yeniHesap = new frmHesapEkle();
            yeniHesap.MdiParent = this;
            yeniHesap.Show();
        }

        private void paraYatırmaÇekmeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapHareket paraYatirmaCekme = new frmHesapHareket();
            paraYatirmaCekme.MdiParent = this;
            paraYatirmaCekme.Show();
        }
    }
}
