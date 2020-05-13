using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonu
{
    public partial class KullaniciGiris : Form
    {
        public static string KullaniciID;

        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            //Musterinin kayıt kısmı işaretli olduğunda kaydetmesi ve müşteri paneline yönlendirmesi için yazıldı.
            if (rdMusteriKayit.Checked)
            {
                //Müşteri kayıt işaretliyse Gayrimenkul kayit işaretli olmasın dedik.
                rdGayrimenkulKayit.Checked = false;
                //Kullanıcı nesnesi oluşturdum.
                Kullanici k = new Kullanici();
                k.Adi = txtMKayitAd.Text;
                k.Soyadi = txtMKayitSoyadi.Text;
                k.GsmNo = txtMKayitTelNo.Text;
                k.KullaniciAdi = txtMKayitKullaniciAd.Text;
                k.KullaniciTipi = "Musteri";
                k.Sifre = txtMKayitSifre.Text;
                k.EmlakAdi = "";
                //Yukarıdan nesneye atadığı değerlerle kullanıcı ekleme yapıyor.
                //True döndüdüğünde ekrana bildirim basıyor.
                if (k.Kullanici_Ekle())
                {
                    MessageBox.Show("Kaydınız Alındı.");
                    //Musteri formuna giriş için yapıldı.
                    MusteriForm mf = new MusteriForm();
                    mf.Show();
                    this.Hide();
                }

            }
            //Gayrimenkul kayıt kısmı işaretli olduğunda gayrimenkul paneline yönlednirme ve kayıt işlemi için yazıldı.
            else
            {
                //MGayrimenkul kayıt işaretliyse Müşteri kayit işaretli olmasın dedik.
                rdMusteriKayit.Checked = false;
                //Nesne tanımlandı.
                Kullanici k = new Kullanici();
                k.Adi = txtGKayitAd.Text;
                k.Soyadi = txtGKayitSoyad.Text;
                k.GsmNo = txtGKayitTelNo.Text;
                k.KullaniciAdi = txtGKayitKullaniciAd.Text;
                k.KullaniciTipi = "Gayrimenkul";
                k.Sifre = txtGKayitSifre.Text;
                k.EmlakAdi = txtGGayrimenkulKayitAd.Text;
                //ilgili değerler nesneye girildi.

                //Kullanıcı ekleme kısmını yukarıda nesneye atadığı değerler ile yaptırdık. Ekleme işlemi gerçekleşirse değer true dönüyor.
                //Gayrimenkul'e kayıt yaptıysa direkt gayrimenkul hesabı oluşuyor ve o panele yönlendirilme yapılıyor.
                if (k.Kullanici_Ekle())
                {
                    //Hangi kullanıcı ile Gayrimenkul paneline girdiğinin bilgisini tutmak için böyle bir değer aldık.
                    //Çünkü Gayrimenkulcuye göre ilanlarını getireceğiz.
                    KullaniciID = k.GetBilgi();
                    MessageBox.Show("Kaydınız Alındı.");
                    //Gayrimenkul formuna giriş için yapıldı.
                    GayrimenkulForm gf = new GayrimenkulForm();
                    gf.Show();
                    this.Hide();
                }
            }
        }

        private void rdMusteriKayit_CheckedChanged(object sender, EventArgs e)
        {
            //Kayıttaki müşteri radio butonu işaretliyse gayrimenkul false olsun demek için yaptım.
            if (rdMusteriKayit.Checked)
            {
                rdGayrimenkulKayit.Checked = false;
            }
        }

        private void rdGayrimenkulKayit_CheckedChanged(object sender, EventArgs e)
        {
            //Kayıttaki gayrimenkul radio butonu işaretliyse musteri false olsun demek için yaptım.
            if (rdGayrimenkulKayit.Checked)
            {
                rdMusteriKayit.Checked = false;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Nesneyi tanımladım.
            Kullanici k = new Kullanici();
            //Eğer müşteri giriş radio butonu işaretliyse Müşteri Paneline girmesi için koşul yazdım.
            if (rdBtnMusteriGiris.Checked)
            {
                //Gerekli değerler nesnelere atandı.
                k.KullaniciTipi = "Musteri";
                k.KullaniciAdi = txtKullaniciAd.Text;
                k.Sifre = txtSifre.Text;
                //Giriş yapma methodu çağırıldı ve eğer giriş doğru ise Müşteri Panelinin olduğu forma yönlendirme yapıldı.
                if (k.GirisYap())
                {
                    //Müşteri formuna giriş için yapıldı.
                    MusteriForm mf = new MusteriForm();
                    mf.Show();
                    this.Hide();
                }
                //True dönmezse zaten giriş başarısızdır. Ekrana uyarı bastırdık.
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı bulunamadı. Lütfen Kullanici Tipinizi, kullanici adinizi ve şifrenizi kontrol ediniz!","Giriş Başarısız");
                }
            }
            //Eğer Gayrimenkul Radio butonu işaretli ise Gayrimenkul Paneline girmesi için koşul yazdım.
            else if (rdBtnGayrimenkulGiris.Checked)
            {
                //Gerekli değerler nesnelere atandı.
                k.KullaniciTipi = "Gayrimenkul";
                k.KullaniciAdi = txtKullaniciAd.Text;
                k.Sifre = txtSifre.Text;
                //Giriş yapma methodu çağırıldı ve eğer giriş doğru ise Gayrimenkul Panelinin olduğu forma yönlendirme yapıldı.
                if (k.GirisYap())
                {
                    //Hangi kullanıcı ile Gayrimenkul paneline girdiğinin bilgisini tutmak için böyle bir değer aldık.
                    //Çünkü Gayrimenkulcuye göre ilanlarını getireceğiz.
                    KullaniciID = k.GetBilgi();
                    //Gayrimenkul formuna giriş için yapıldı.
                    GayrimenkulForm gf = new GayrimenkulForm();
                    gf.Show();
                    this.Hide();
                }
                //True dönmezse zaten giriş başarısızdır. Ekrana uyarı bastırdık.
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı bulunamadı. Lütfen Kullanici Tipinizi, kullanici adinizi ve şifrenizi kontrol ediniz!", "Giriş Başarısız");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Başlangıçta Kayıttaki ve Girişteki musteri radio butonlarını işaretli yaptım.
            rdMusteriKayit.Checked = true;
            rdBtnMusteriGiris.Checked = true;
        }
    }
}
