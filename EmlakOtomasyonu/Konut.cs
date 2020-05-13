using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyonu
{
    //Mustakil,Daire,Apartman sınıflarının hepsinin temelinde Konut sınıfı vardır. 
    //Ve konut sınıfı soyut bir sınıftır ve nesne üretilemez.
    abstract class Konut
    {
        //Burada kapsülleme işlemi yapılmıştır.

        //Bunlar benim field'larım.
        private int _ilanID;
        private string _ilanBaslik;
        private int _metrekare;
        private double _fiyat;
        private string _ilantipi;
        private int _kullaniciID;
        private string _konutTipi;

        //Bunlar benim property'lerim.
        public int IlanID { get => _ilanID; set => _ilanID = value; }
        public string IlanBaslik { get => _ilanBaslik; set => _ilanBaslik = value; }
        public int Metrekare { get => _metrekare; set => _metrekare = value; }
        public double Fiyat { get => _fiyat; set => _fiyat = value; }
        public string Ilantipi { get => _ilantipi; set => _ilantipi = value; }
        public int KullaniciID { get => _kullaniciID; set => _kullaniciID = value; }
        public string KonutTipi { get => _konutTipi; set => _konutTipi = value; }

        //ilanID olmayan constructor tanımladım.(Ekleme işleminde kullanmak için.)
        public Konut(string ilanBaslik,
            int metrekare,
            double fiyat,
            string ilanTipi,
            int kullaniciID,
            string konutTipi)
        {
            this.IlanBaslik = ilanBaslik;
            this.Metrekare = metrekare;
            this.Fiyat = fiyat;
            this.Ilantipi = ilanTipi;
            this.KullaniciID = kullaniciID;
            this.KonutTipi = konutTipi;
        }

        //ilanID olan constructor tanımladım. (Güncelleme yaparken kullanmak için.)
        public Konut(int ilanID,
            string ilanBaslik,
            int metrekare,
            double fiyat,
            string ilanTipi,
            int kullaniciID,
            string konutTipi)
        {
            this.IlanID = ilanID;
            this.IlanBaslik = ilanBaslik;
            this.Metrekare = metrekare;
            this.Fiyat = fiyat;
            this.Ilantipi = ilanTipi;
            this.KullaniciID = kullaniciID;
            this.KonutTipi = konutTipi;
            
        }
        //Sadece ilan id'nin olduğu bir constructor tanımladım.(silme işleminde sadece ilan id'ye ihtiyacım var.)
        public Konut(int ilanID)
        {
            this.IlanID = ilanID;
        }

        //Sadece fiyat'ın olduğu bir constructor tanımladım.(Komisyon Hesaplama işleminde sadece fiyat'a ihtiyacım var.)
        public Konut(double fiyat)
        {
            this.Fiyat = fiyat;
        }

       

        //Pollymorphizm yaptık. Bunu tanımlama sebebim Komisyon hesaplamasının 
        //her konut sınıfının alt sınıfı için farklı bir şekilde hesaplandığı için kullandım.
        //Bu method diğer ilgili sınıflar tarafından override edilrek ezilir.
        public virtual double KomisyonHesapla()
        {
            return 0;
        }
    }
    
}
