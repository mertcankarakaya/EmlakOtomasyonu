using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyonu
{
    class Kullanici
    {
        //Burada kapsülleme işlemi yapılmıştır.

        //Bunlar benim field'larım.
        private int _kullanici_ID;
        private string _adi;
        private string _soyadi;
        private string _gsmNo;
        private string _emlakAdi;
        private string _kullaniciAdi;
        private string _sifre;
        private string _kullaniciTipi;

        //Bunlar benim property'lerim.
        public int Kullanici_ID { get => _kullanici_ID; set => _kullanici_ID = value; }
        public string Adi { get => _adi; set => _adi = value; }
        public string Soyadi { get => _soyadi; set => _soyadi = value; }
        public string GsmNo { get => _gsmNo; set => _gsmNo = value; }
        public string EmlakAdi { get => _emlakAdi; set => _emlakAdi = value; }
        public string KullaniciAdi { get => _kullaniciAdi; set => _kullaniciAdi = value; }
        public string Sifre { get => _sifre; set => _sifre = value; }
        public string KullaniciTipi { get => _kullaniciTipi; set => _kullaniciTipi = value; }


        SqlConnection baglanti;
        //CONSTRUCTOR (YAPICI METOD) tanımlanmıştır.
        public Kullanici()
        {
            baglanti = new SqlConnection("Data Source=MERTCAN\\MERTCAN; initial Catalog=EmlakOtomasyonu; Integrated Security=true");
        }

        //Bu method ekleme işlemi yapmaktadır. Bool bir değer döndürür. 
        //Döndürmesinin sebebi kayıt işleminin gerçekleşip gerçekleşmediğini görmek içindir. Gerçekleşiyorsa bir Message.Box ile bunu bize bildirir.
        public bool Kullanici_Ekle()
        {
            bool kontrol = false;
            baglanti.Open(); // bağlantıyı açtık

            //Sorgumuzu yazdım. Ekleme işlemi yapan insert into sorgusu yazdım.
            SqlCommand ekle = new SqlCommand("insert into Kullanici(adi,soyadi,gsmNo,emlak_adi,kullanici_adi,sifre,kullanici_tipi) values ('" + _adi + "','"+_soyadi + "','" + _gsmNo + "','" + _emlakAdi + "','" + _kullaniciAdi + "','" + _sifre + "','" + _kullaniciTipi + "')", baglanti);
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            if (ekle.ExecuteNonQuery() > 0)
            {
                kontrol = true;
            }
            ekle.Dispose();
            baglanti.Close();
            return kontrol;
        }
        //Bu method giriş yapma işlemi yapmaktadır.Bool bir değer döndürür.
        //Kullanıcı adı ve şifre eşleşiyor mu diye kontrol diyor. Aynı zamanda kullanıcı tipine de bakıyor.
        //Dönen değer true ise ilgili forma yönlendirme yapıyor.
        public bool GirisYap()
        {
            bool kontrol = false;
            baglanti.Open(); // bağlantıyı açtık

            //Sorgumuzu yazdım. Ekleme işlemi yapan insert into sorgusu yazdım.
            SqlCommand ekle = new SqlCommand("Select * from Kullanici where kullanici_adi=@KullaniciAdi and  sifre=@Sifre and kullanici_tipi=@KullaniciTipi", baglanti);
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            ekle.Parameters.AddWithValue("KullaniciAdi", _kullaniciAdi);
            ekle.Parameters.AddWithValue("Sifre", _sifre);
            ekle.Parameters.AddWithValue("KullaniciTipi", _kullaniciTipi);
            SqlDataAdapter adapter = new SqlDataAdapter(ekle);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ekle.ExecuteNonQuery();
            //Tablonun olduğu datanın içerisinde eğer "kullanici adi, sifre ve kullanici tipi" girilen değer olan
            //değer var ise 0'dan büyüktür ve doğrudur. Bu yüzden geriye bir doğru değeri döndürdük.
            //true olunca ilgili paneli açma işlemi yapacak.
            if (dt.Rows.Count > 0)
            {
                kontrol = true;
            }
            ekle.Dispose();
            baglanti.Close();
            return kontrol;


        }
        //Gayrimenkul panelinde kendi ilanlarım kısmını kullanici id bilgisine göre almam gerektiği için
        //kullanıcı id'yi bana geriye döndüren bir method tanımladım.
        public string GetBilgi()
        {
           string bilgi="";
            baglanti.Open(); // bağlantıyı açtık

            //Sorgumuzu yazdım. Ekleme işlemi yapan insert into sorgusu yazdım.
            SqlCommand ekle = new SqlCommand("Select kullanici_id from Kullanici where kullanici_adi=@KullaniciAdi and  sifre=@Parola", baglanti);
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            ekle.Parameters.AddWithValue("KullaniciAdi", _kullaniciAdi);
            ekle.Parameters.AddWithValue("Parola", _sifre);
            SqlDataReader dr = ekle.ExecuteReader();
            //Çalıştırdığı execute'dan dönen "kullanici_id" alanındaki değeri bilgiye atıyor.
            while (dr.Read())
            {
                bilgi=dr["kullanici_id"].ToString();
                
            }
            
            baglanti.Close();

            //geriye bilgi değerini döndürüyor.
            return bilgi;
        }

    }
}
