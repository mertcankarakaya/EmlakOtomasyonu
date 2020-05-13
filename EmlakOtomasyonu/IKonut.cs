using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyonu
{
    //Tüm alt sınıflarında ilgili methodlar olduğu için bu şekilde bir Arayüz (Interface) tanımlanmıştır.
    interface IKonut
    {
        bool KonutEkle();
        bool Ilan_Guncelle();
        bool KonutSil();
    }
}
