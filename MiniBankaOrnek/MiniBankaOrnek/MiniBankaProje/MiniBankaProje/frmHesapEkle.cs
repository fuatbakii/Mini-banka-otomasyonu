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
    public partial class frmHesapEkle : Form
    {
        public frmHesapEkle()
        {
            InitializeComponent();
        }

        private void frmHesapEkle_Load(object sender, EventArgs e)
        {
            //cbHesapTuru comboboxını dolduralım
            cbHesapTuru.DisplayMember = "HesapTurAd";
            cbHesapTuru.ValueMember = "HesapTurID";
            MiniBankaEntities vt = new MiniBankaEntities();
            cbHesapTuru.DataSource = vt.HesapTur.ToList();
        }

        vMusteri bankaMusteriBilgisi = null;
        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string musteriNoVeyaTCNo = txtMusteriNoVeyaTCNo.Text;
            MiniBankaEntities vt = new MiniBankaEntities();
            bankaMusteriBilgisi = vt.vMusteri.Where(p => p.MusteriNo == musteriNoVeyaTCNo || p.TCNO == musteriNoVeyaTCNo).FirstOrDefault();
            if (bankaMusteriBilgisi != null)
            {
                btnOlustur.Enabled = true;
                btnKaydet.Enabled = true;
                lblMusteriAdSoyad.Text = bankaMusteriBilgisi.Ad + " " + bankaMusteriBilgisi.Soyad;
            }
            else
            {
                btnOlustur.Enabled = false;
                btnKaydet.Enabled = false;
                lblMusteriAdSoyad.Text = "";
            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            string hesapNo = "";
            MiniBankaEntities vt = new MiniBankaEntities();
            List<Hesap> tumHesapListesi = vt.Hesap.OrderByDescending(p => p.HesapNo).ToList();
            if (tumHesapListesi == null || tumHesapListesi.Count == 0)
            {
                hesapNo = "1000000000000001";
            }
            else
            {
                decimal sayisalHesapNo = Convert.ToDecimal(tumHesapListesi[0].HesapNo);
                sayisalHesapNo += 1; //ardışık olarak bir sonraki hesapno
                hesapNo = sayisalHesapNo.ToString();
            }
            txtHesapNo.Text = hesapNo;
            //iban oluşturma kısmı
            string IBAN = "TR56" + bankaMusteriBilgisi.BankaKodu + "0" + hesapNo;
            lblIBAN.Text = IBAN;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (bankaMusteriBilgisi != null)
            {
                using (MiniBankaEntities vt = new MiniBankaEntities())
                {
                    using (var transaction = vt.Database.BeginTransaction())
                    {
                        try
                        {
                            Hesap yeniHesap = new Hesap();
                            yeniHesap.BankaMusteriId = bankaMusteriBilgisi.BankaMusteriID;
                            yeniHesap.HesapTurId = Convert.ToInt32(cbHesapTuru.SelectedValue);
                            yeniHesap.HesapAd = txtHesapAd.Text;
                            yeniHesap.HesapNo = txtHesapNo.Text;
                            yeniHesap.IBAN = lblIBAN.Text;
                            yeniHesap.AcilisTarihi = dtHesapAcilisTarihi.Value;
                            yeniHesap.KapanisTarihi = null;
                            yeniHesap.Aktif = true;
                            yeniHesap.Bakiye = Convert.ToDecimal(txtBakiye.Text);
                            vt.Hesap.Add(yeniHesap);
                            vt.SaveChanges();
                            int hesapID = yeniHesap.HesapID; //yeni kaydedilen hesapID yi verir

                            HesapHareket yeniHesapHareket = new HesapHareket();
                            yeniHesapHareket.HesapId = hesapID;
                            yeniHesapHareket.IslemTutari = yeniHesap.Bakiye;
                            yeniHesapHareket.IslemTurId = 1; //yeni hesap açılırken virman olarak seçtik
                            yeniHesapHareket.IslemYonu = "+";
                            yeniHesapHareket.IslemAciklamasi = lblMusteriAdSoyad.Text + " ait hesap açma işlemi";
                            yeniHesapHareket.IslemTarihi = (DateTime)dtHesapAcilisTarihi.Value;
                            vt.HesapHareket.Add(yeniHesapHareket);
                            int sonuc = vt.SaveChanges();
                            if (sonuc > 0)
                                MessageBox.Show("İşlem başarılı!");
                            else
                                MessageBox.Show("İşlem başarısız!");
                        }
                        catch (Exception hata)
                        {
                            transaction.Rollback(); //işlemi iptal et
                        }
                        finally
                        {
                            transaction.Commit(); //tüm işlemler doğruysa işlemi onayla
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblMusteriAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void txtMusteriNoVeyaTCNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
