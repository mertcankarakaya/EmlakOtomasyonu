using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyonu
{
    class Mustakil : Konut, IKonut
    {
        //Burada kapsülleme işlemi yapılmıştır.

        //Bunlar benim field'larım.
        private string _odaSalonSayi;
        private string _tuvaletbanyosayi;
        private int _balkonsayi;
        private int _katsayi;

        //Bunlar benim property'lerim.
        public string OdaSalonSayi { get => _odaSalonSayi; set => _odaSalonSayi = value; }
        public string TuvaletBanyoSayi { get => _tuvaletbanyosayi; set => _tuvaletbanyosayi = value; }
        public int Balkonsayi { get => _balkonsayi; set => _balkonsayi = value; }
        public int Katsayi { get => _katsayi; set => _katsayi = value; }

        SqlConnection baglanti;
        //CONSTRUCTOR (YAPICI METOD) tanımladım.
        

        //ilanID olmayan constructor tanımladım.(Ekleme işleminde kullanmak için.)
        public Mustakil(string ilanBaslik,
            int metrekare,
            double fiyat,
            string odaSalonSayi,
            string tuvaletBanyoSayi,
            int balkonSayi,
            int katSayi,
            string ilanTipi,
            int kullaniciID,
            string konutTipi) : base(ilanBaslik, metrekare, fiyat, ilanTipi, kullaniciID, konutTipi)
        {
            this.OdaSalonSayi = odaSalonSayi;
            this.TuvaletBanyoSayi = tuvaletBanyoSayi;
            this.Balkonsayi = balkonSayi;
            this.Katsayi = katSayi;
            //Her bu yapıcı method çalıştığında sql bağlantımı gerçekleştirsin diye tanımladım.
            baglanti = new SqlConnection("Data Source=MERTCAN\\MERTCAN; initial Catalog=EmlakOtomasyonu; Integrated Security=true");
        }

        //ilanID olan constructor tanımladım.(Güncelleme işleminde kullanmak için.)
        public Mustakil(int ilanID,
            string ilanBaslik,
            int metrekare,
            double fiyat,
            string odaSalonSayi,
            string tuvaletBanyoSayi,
            int balkonSayi,
            int katSayi,
            string ilanTipi,
            int kullaniciID,
            string konutTipi) : base(ilanID,ilanBaslik, metrekare, fiyat, ilanTipi, kullaniciID, konutTipi)
        {
            this.OdaSalonSayi = odaSalonSayi;
            this.TuvaletBanyoSayi = tuvaletBanyoSayi;
            this.Balkonsayi = balkonSayi;
            this.Katsayi = katSayi;
            //Her bu yapıcı method çalıştığında sql bağlantımı gerçekleştirsin diye tanımladım.
            baglanti = new SqlConnection("Data Source=MERTCAN\\MERTCAN; initial Catalog=EmlakOtomasyonu; Integrated Security=true");
        }
        //Sadece ilan id'nin olduğu bir constructor tanımladım.(silme işleminde sadece ilan id'ye ihtiyacım var.)
        public Mustakil(int ilanID):base(ilanID)
        {
            //ilanID'yi konuttan aldığı için bunun içerisinde bir şey yapmadım. Direkt Konuttan'da nesne oluşturulmadığı için tanım yapmıyorum.
            //Her bu yapıcı method çalıştığında sql bağlantımı gerçekleştirsin diye tanımladım.
            baglanti = new SqlConnection("Data Source=MERTCAN\\MERTCAN; initial Catalog=EmlakOtomasyonu; Integrated Security=true");
        }

        //Sadece fiyat'ın olduğu bir constructor tanımladım.(Komisyon Hesaplama işleminde sadece fiyat'a ihtiyacım var.)
        public Mustakil(double fiyat) : base(fiyat)
        {
            //Fiyat'ı konuttan aldığı için bunun içerisinde bir şey yapmadım. Direkt Konuttan'da nesne oluşturulmadığı için tanım yapmıyorum.
            //Her bu yapıcı method çalıştığında sql bağlantımı gerçekleştirsin diye tanımladım.
            baglanti = new SqlConnection("Data Source=MERTCAN\\MERTCAN; initial Catalog=EmlakOtomasyonu; Integrated Security=true");
        }

        //Nesnelerden aldığı bilgilerle veritabanına yeni ilanlar girmek için böyle bir method tanımladım.
        //Bool değer tanımlama sebebim ekleme işlemi başarılı olduğunda geriye bu değeri true şeklinde döndürür.
        //True değer döndüğünde ekrana kullandığım yerden message bastırıyorum.
        public bool KonutEkle()
        {
            bool kontrol = false;
            baglanti.Open(); // bağlantıyı açtık

            //Sorgumuzu yazdım. Ekleme işlemi yapan insert into sorgusu yazdım.
            SqlCommand ekle = new SqlCommand("insert into Ilan_Ozellikleri(ilanBaslik,metrekare,odaSalonSayi,balkonSayi,katSayi,tuvaletBanyoSayi,ilanTipi,kullanici_id,fiyat,KonutTipi) values ('" + IlanBaslik + "','" + Metrekare + "','" + OdaSalonSayi + "','" + Balkonsayi + "','" + Katsayi + "','" + TuvaletBanyoSayi + "','"+ Ilantipi + "','" + KullaniciID + "','" + Fiyat + "','" + KonutTipi + "')", baglanti);
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            //işlem gerçekleştiğinde 0'dan büyük oluyor böylelikle başarılı olmuş oluyor. True değer döndürtüyor.
            if (ekle.ExecuteNonQuery() > 0)
            {
                kontrol = true;
            }
            ekle.Dispose();
            baglanti.Close();
            return kontrol;

        }

        //İlan ID 'sine göre textboxta doldurulmuş olan alanları güncellemesi için yazdım.
        //Bool değer tanımlama sebebim güncelleme işlemi başarılı olduğunda geriye bu değeri true şeklinde döndürür.
        //True değer döndüğünde ekrana kullandığım yerden message bastırıyorum.
        public bool Ilan_Guncelle()
        {
            bool kontrol = false;
            baglanti.Open();
            //İlan Özellikleri tablosunun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            string guncelle = "update Ilan_Ozellikleri set ilanBaslik=@ilanbaslik,metrekare=@metrekare,balkonSayi=@balkonSayi,katSayi=@katSayi,tuvaletBanyoSayi=@tuvaletBanyoSayi,ilanTipi=@ilanTipi,fiyat=@fiyat where ilan_id=@IlanID";
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlCommand komut = new SqlCommand(guncelle, baglanti);
            //Sorgunun içerisinde ilgili alanları doldurabilmek için aşağıdaki parametreleri oluşturdum.
            komut.Parameters.AddWithValue("@ilanbaslik", IlanBaslik);
            komut.Parameters.AddWithValue("@metrekare", Metrekare);
            komut.Parameters.AddWithValue("@odaSalonSayi", OdaSalonSayi);
            komut.Parameters.AddWithValue("@balkonSayi", Balkonsayi);
            komut.Parameters.AddWithValue("@katSayi", Katsayi);
            komut.Parameters.AddWithValue("@tuvaletBanyoSayi", TuvaletBanyoSayi);
            
            komut.Parameters.AddWithValue("@ilanTipi", Ilantipi);
            komut.Parameters.AddWithValue("@fiyat", Fiyat);
            komut.Parameters.AddWithValue("@IlanID", IlanID);
            if (komut.ExecuteNonQuery() > 0)
            {
                kontrol = true;
            }
            komut.Dispose();
            baglanti.Close();
            return kontrol;


        }

        //İlan ID 'sine göre tüm satırı silmesi için yazdım.
        //Bool değer tanımlama sebebim silme işlemi başarılı olduğunda geriye bu değeri true şeklinde döndürsün diye.
        //True değer döndüğünde ekrana kullandığım yerden message bastırıyorum.
        public bool KonutSil()
        {
            bool kontrol = false;
            baglanti.Open(); // bağlantıyı açtık

            //Sorgumuzu yazdım. Silme işlemi yapan delete sorgusu yazdım.
            SqlCommand sil = new SqlCommand("Delete Ilan_Ozellikleri where ilan_id='" + IlanID + "'", baglanti);
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            if (sil.ExecuteNonQuery() > 0)
            {
                kontrol = true;
            }
            sil.Dispose();
            baglanti.Close();
            return kontrol;
        }

        //Ezdirme yaparak Mustakil'e özel bir komisyon hesabı yaptırdık.
        public override double KomisyonHesapla()
        {
            return (Fiyat / 4) * 1.04;
        }
    }
}
