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
    public partial class frmGirisEkran : Form
    {
        public frmGirisEkran()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string girisAd = txtGirisAd.Text;
            string sifre = txtSifre.Text;
            if (string.IsNullOrEmpty(girisAd) || string.IsNullOrEmpty(sifre))
            {
                //giriş adı veya şifre girilmemiş. Uyarı ver.
                MessageBox.Show("Giriş adı ve şifre boş olamaz!", "Giriş hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Giriş adı ve şifre boş değilse doludur. Kullanıcı var mı yok mu kontrol et
                MiniBankaEntities vt = new MiniBankaEntities();
                vKullanici girisKullanici = vt.vKullanici.SingleOrDefault(p => p.GirisAd == girisAd && p.GirisSifre == sifre);
                if (girisKullanici == null)
                {   //eğer bu ad ve şifreye ait kullanıcı yoksa girisKullanici null döner
                    MessageBox.Show("Girilen ad ve şifreye ait kullanıcı bulunamadı!", "Giriş hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {   //eğer vKullanici null değilse sisteme login et
                    frmAnaEkran girisEkrani = new frmAnaEkran(girisKullanici);
                    girisEkrani.Show();
                    this.Hide();
                }
            }
        }
    }
}
