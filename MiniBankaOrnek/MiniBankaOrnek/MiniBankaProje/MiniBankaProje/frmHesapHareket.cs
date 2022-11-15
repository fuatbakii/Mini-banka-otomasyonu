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
    public partial class frmHesapHareket : Form
    {
        public frmHesapHareket()
        {
            InitializeComponent();
        }


        vMusteri bankaMusteriBilgisi = null;
        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string musteriNoVeyaTCNo = txtMusteriNoVeyaTCNo.Text;
            MiniBankaEntities vt = new MiniBankaEntities();
            bankaMusteriBilgisi = vt.vMusteri.Where(p => p.MusteriNo == musteriNoVeyaTCNo || p.TCNO == musteriNoVeyaTCNo).FirstOrDefault();
            if (bankaMusteriBilgisi != null)
            {
                btnKaydet.Enabled = true;
                lblMusteriAdSoyad.Text = bankaMusteriBilgisi.Ad + " " + bankaMusteriBilgisi.Soyad;

                // cbMusteriHesaplari comboboxını müşterinin mevcut banka hesapları ile dolduralım
                List<Hesap> musteriHesapListesi = vt.Hesap.Where(p => p.BankaMusteriId == bankaMusteriBilgisi.BankaMusteriID).ToList();
                if (musteriHesapListesi != null)
                    cbMusteriHesaplari.DataSource = musteriHesapListesi;
            }
            else
            {
                btnKaydet.Enabled = false;
                lblMusteriAdSoyad.Text = "";
            }
        }

        private void frmHesapHareket_Load(object sender, EventArgs e)
        {
            cbMusteriHesaplari.DisplayMember = "HesapAd";
            cbMusteriHesaplari.ValueMember = "HesapID";

            cbIslemTuru.DisplayMember = "IslemTurAd";
            cbIslemTuru.ValueMember = "IslemTurID";
            MiniBankaEntities vt = new MiniBankaEntities();
            cbIslemTuru.DataSource = vt.IslemTur.ToList();
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
                            HesapHareket yeniHesapHareket = new HesapHareket();
                            yeniHesapHareket.HesapId = Convert.ToInt32(cbMusteriHesaplari.SelectedValue);
                            yeniHesapHareket.IslemTutari = Convert.ToDecimal(txtIslemTutari.Text);
                            yeniHesapHareket.IslemTurId = Convert.ToInt32(cbIslemTuru.SelectedValue);
                            yeniHesapHareket.IslemYonu = rbParaYatirma.Checked ? "+" : "-";
                            yeniHesapHareket.IslemAciklamasi = txtIslemAciklamasi.Text;
                            yeniHesapHareket.IslemTarihi = DateTime.Now;
                            vt.HesapHareket.Add(yeniHesapHareket);
                            int sonuc = vt.SaveChanges();
                            if (sonuc > 0)
                            {
                                //HesapHareket tablosuna kayıt yapıldı. İlgili hesaba ait mevcut bakiye yi güncelle
                                Hesap guncellenecekHesap = vt.Hesap.SingleOrDefault(p => p.HesapID == yeniHesapHareket.HesapId);
                                if (yeniHesapHareket.IslemYonu == "+")
                                    guncellenecekHesap.Bakiye += yeniHesapHareket.IslemTutari;
                                else
                                    guncellenecekHesap.Bakiye -= yeniHesapHareket.IslemTutari;

                                sonuc = vt.SaveChanges();
                                if (sonuc > 0)
                                    MessageBox.Show("İşlem başarılı!");
                                else
                                    MessageBox.Show("İşlem başarısız!");
                            }
                        }
                        catch (Exception hata)
                        {
                            transaction.Rollback();
                        }
                        finally
                        {
                            transaction.Commit();
                        }
                    }
                }
            }
        }
    }
}
