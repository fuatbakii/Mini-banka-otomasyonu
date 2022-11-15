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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {
            //cbHesapAcilacakSube comboboxını dolduralım
            MiniBankaEntities vt = new MiniBankaEntities();
            cbHesapBankaSubesi.DisplayMember = "BankaSubeAd";
            cbHesapBankaSubesi.ValueMember = "BankaSubeID";
            cbHesapBankaSubesi.DataSource = vt.BankaSube.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (MiniBankaEntities vt=new MiniBankaEntities())
            {
                using (var transaction=vt.Database.BeginTransaction())
                {
                    try
                    {
                        Musteri yeniMusteri = new Musteri();
                        yeniMusteri.MusteriNo = txtMusteriNo.Text;
                        yeniMusteri.TCNO = txtTCNO.Text;
                        yeniMusteri.Ad = txtAd.Text;
                        yeniMusteri.Soyad = txtSoyad.Text;
                        yeniMusteri.DogumYeri = txtDogumYeri.Text;
                        yeniMusteri.DogumTarihi = dtDogumTarihi.Value;
                        yeniMusteri.EvAdresi = txtEvAdresi.Text;
                        yeniMusteri.IsAdresi = txtIsAdresi.Text;
                        yeniMusteri.Telefon = txtTelefon.Text;
                        vt.Musteri.Add(yeniMusteri);
                        vt.SaveChanges();
                        int kaydedilenMusteriID = yeniMusteri.MusteriID; //kaydedilen musteriID yi verir

                        BankaMusteri yeniBankaMusteri = new BankaMusteri();
                        yeniBankaMusteri.BankaSubeId = Convert.ToInt32(cbHesapBankaSubesi.SelectedValue);
                        yeniBankaMusteri.MusteriId = kaydedilenMusteriID;
                        yeniBankaMusteri.IslemTarihi = DateTime.Now;
                        vt.BankaMusteri.Add(yeniBankaMusteri);
                        int sonuc = vt.SaveChanges();
                        if (sonuc > 0)
                            MessageBox.Show("İşlem başarılı!");
                        else
                            MessageBox.Show("İşlem başarısız!");
                    }
                    catch (Exception hata)
                    {
                        //hata oluştu. Kaydetme işlemini iptal et. Tüm kayıtlar eski haline dönsün
                        transaction.Rollback(); //kaydetme iptal edilir. Kayıtlar eski haline döner
                    }
                    finally
                    {
                        //hiçbir hata olmadı. Tüm işlemler başarılı oldu. Bu sebeple kaydetme işlemini onayla
                        transaction.Commit(); // kaydetme işlemi onayla. Veriler tüm tablolara kayıt olur
                    }
                }
            }
        }
    }
}
