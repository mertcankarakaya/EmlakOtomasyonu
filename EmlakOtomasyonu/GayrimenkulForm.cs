
/***********************************************************************************************************************************************
 *                                                                               SAKARYA ÜNİVERSİTESİ                                         **                  
 *                                                                      BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                             **    
 *                                                                       BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ                               **       
 *                                                                         NESNEYE DAYALI PROGRAMLAMA DERSİ                                   **     
 *                                                                               2019-2020 BAHAR DÖNEMİ                                       **  
 *                                                                                                                                            **
 *                                                                                                                                            **
 *                                                                      ÖDEV NUMARASI..........: 2                                            **    
 *                                                                      ÖĞRENCİ ADI............: Mertcan Karakaya                             **    
 *                                                                      ÖĞRENCİ NUMARASI.......: B161200021                                   **                         
 *                                                                      DERSİN ALINDIĞI GRUP...: A                                            **          
 **********************************************************************************************************************************************/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonu
{
    public partial class GayrimenkulForm : Form
    {
        //MSSQL'e bağlantı kurması için tanımladım.
        SqlConnection baglanti = new SqlConnection("Data Source=MERTCAN\\MERTCAN; initial Catalog=EmlakOtomasyonu; Integrated Security=true");
        public GayrimenkulForm()
        {
            InitializeComponent();
        }
        //Aşağıda atama işlemlerinde kullanacağım değişkenleri tanımladım.
        public int ilanID = 0;
        public string ilanTipi = "";
        public string konutTipi = "";
        public int kullaniciID = 0;
        public string ilanBaslik = "";
        public int metrekare = 0;
        public double fiyat = 0.0;
        public string odaSalonSayi = "";
        public int balkonSayi = 0;
        public int katSayi = 0;
        public string tuvaletBanyoSayi = "";
        public int toplamDaireSayisi = 0;

        //Textbox, combobox ve radio button'ların değerlerini silmesi için tanımladım.
        public void FormTemizle()
        {
            //Müstakil için temizleme tanımları
            txtMustakilBaslik.Text = "";
            txtMustakilMetrekare.Text = "";
            txtMustakilFiyat.Text = "";
            txtMustakilOdaSalon.Text = "1+1";
            txtMustakilBalkon.Text = "";
            txtMustakilTuvaletBanyo.Text = "1+1";
            rdMustakilKiralik.Checked = false;
            rdMustakilSatilik.Checked = false;
            txtMustakilKat.Text = "";
            txtMustakilKomisyon.Text = "";

            //Apartman için temizleme tanımları
            txtApartmanBaslik.Text = "";
            txtApartmanMetrekare.Text = "";
            txtApartmanFiyat.Text = "";
            rdApartmanKiralik.Checked = false;
            rdApartmanSatilik.Checked = false;
            txtApartmanOdaSalon.Text = "1+1";
            txtApartmanBalkon.Text = "";
            txtApartmanToplamDaire.Text = "";
            txtApartmanKomisyon.Text = "";

            //Daire için temizleme tanımları
            txtDaireBaslik.Text = "";
            txtDaireMetrekare.Text = "";
            txtDaireFiyat.Text = "";
            rdDaireKiralik.Checked = false;
            rdDaireSatilik.Checked = false;
            txtDaireOdaSalon.Text = "1+1";
            txtDaireBalkon.Text = "";
            txtDaireTuvaletBanyo.Text = "1+1";
            txtDaireKomisyon.Text = "";

            //Gayrimenkul Arama için temizleme tanımları
            txtGAramaBalkon.Text = "";
            txtGAramaFiyat.Text = "";
            txtGAramaKat.Text = "";
            txtGAramaMetrekare.Text = "";
            rdGAramaKiralik.Checked = false;
            rdGAramaSatilik.Checked = false;
            rdGMustakilArama.Checked = false;
            rdGDaireArama.Checked = false;
            rdGApartmanArama.Checked = false;
            cbxGAramaTuvaletBanyo.Text = "";
            cbxGAramaOdaSalon.Text = "";
        }

        private void btnMustakilIlanVer_Click(object sender, EventArgs e)
        {
            try
            {
                //Nesnenin alanlarına ilgili atamaları gerçekleştirmek için değişkenlere değerlerini atadım.
                konutTipi = "Mustakil";
                kullaniciID = Convert.ToInt32(lblKullaniciID.Text);
                ilanBaslik = txtMustakilBaslik.Text;
                metrekare = Convert.ToInt32(txtMustakilMetrekare.Text);
                fiyat = Convert.ToDouble(txtMustakilFiyat.Text);
                odaSalonSayi = txtMustakilOdaSalon.Text;
                balkonSayi = Convert.ToInt32(txtMustakilBalkon.Text);
                katSayi = Convert.ToInt32(txtMustakilKat.Text);
                tuvaletBanyoSayi = txtMustakilTuvaletBanyo.Text;

                //Hangi ilan tipinin seçildiğini anlamak için bir switch-case tanımladım.
                switch (rdMustakilSatilik.Checked)
                {
                    //Satılık radio butonu seçili olduğunda ilan tipini Satılık yapsın diye yazdım.
                    case true:
                        ilanTipi = "Satılık";
                        break;
                    //Kiralık radio butonu seçili olduğunda ilan tipini Satılık yapsın diye yazdım.
                    case false:
                        ilanTipi = "Kiralık";
                        break;
                }

                //Mustakil Nesnesi tanımladım.
                Mustakil m = new Mustakil(ilanBaslik, metrekare, fiyat, odaSalonSayi, tuvaletBanyoSayi, balkonSayi, katSayi, ilanTipi, kullaniciID, konutTipi);

                //Mustakil nesnesindeki KonutEkle metoduyla nesnedeki alanları kullanarak ekleme işlemi yapıyor.
                //Başarılı olursa ekleme geriye doğru değeri dönüyor.
                //Ve başarılı olduğuna dair bir bilgi döndürüyor.
                if (m.KonutEkle())
                {
                    MessageBox.Show("Ekleme Başarılı");
                }
                //Bu methodla da İlanların bulunduğu tablodaki bilgiler doluyor.
                MustakilDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }

        }
        private void btnApartmanIlanVer_Click(object sender, EventArgs e)
        {
            try
            {
                //Nesnenin alanlarına ilgili atamaları gerçekleştirmek için değişkenlere değerlerini atadım.
                konutTipi = "Apartman";
                kullaniciID = Convert.ToInt32(lblKullaniciID.Text);
                ilanBaslik = txtApartmanBaslik.Text;
                metrekare = Convert.ToInt32(txtApartmanMetrekare.Text);
                fiyat = Convert.ToDouble(txtApartmanFiyat.Text);
                odaSalonSayi = txtApartmanOdaSalon.Text;
                balkonSayi = Convert.ToInt32(txtApartmanBalkon.Text);
                toplamDaireSayisi = Convert.ToInt32(txtApartmanToplamDaire.Text);

                //Hangi ilan tipinin seçildiğini anlamak için bir switch-case tanımladım.
                switch (rdApartmanSatilik.Checked)
                {
                    //Satılık radio butonu seçili olduğunda ilan tipini Satılık yapsın diye yazdım.
                    case true:
                        ilanTipi = "Satılık";
                        break;
                    //Kiralık radio butonu seçili olduğunda ilan tipini Satılık yapsın diye yazdım.
                    case false:
                        ilanTipi = "Kiralık";
                        break;
                }

                Apartman a = new Apartman(ilanBaslik, metrekare, fiyat, odaSalonSayi, toplamDaireSayisi, balkonSayi, ilanTipi, kullaniciID, konutTipi);

                //Apartman nesnesindeki KonutEkle metoduyla nesnedeki alanları kullanarak ekleme işlemi yapıyor.
                //Başarılı olursa ekleme geriye doğru değeri dönüyor.
                //Ve başarılı olduğuna dair bir bilgi döndürüyor.
                if (a.KonutEkle())
                {
                    MessageBox.Show("Ekleme Başarılı");
                }
                //Bu methodla da İlanların bulunduğu tablodaki bilgiler doluyor.
                ApartmanDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }
        private void btnDaireIlanVer_Click(object sender, EventArgs e)
        {
            try
            {
                //Nesnenin alanlarına ilgili atamaları gerçekleştirmek için değişkenlere değerlerini atadım.
                konutTipi = "Daire";
                kullaniciID = Convert.ToInt32(lblKullaniciID.Text);
                ilanBaslik = txtDaireBaslik.Text;
                metrekare = Convert.ToInt32(txtDaireMetrekare.Text);
                fiyat = Convert.ToDouble(txtDaireFiyat.Text);
                odaSalonSayi = txtDaireOdaSalon.Text;
                balkonSayi = Convert.ToInt32(txtDaireBalkon.Text);
                tuvaletBanyoSayi = txtDaireTuvaletBanyo.Text;

                //Hangi ilan tipinin seçildiğini anlamak için bir switch-case tanımladım.
                switch (rdDaireSatilik.Checked)
                {
                    //Satılık radio butonu seçili olduğunda ilan tipini Satılık yapsın diye yazdım.
                    case true:
                        ilanTipi = "Satılık";
                        break;
                    //Kiralık radio butonu seçili olduğunda ilan tipini Satılık yapsın diye yazdım.
                    case false:
                        ilanTipi = "Kiralık";
                        break;
                }
                //Daire Nesnesi tanımladım.
                Daire d = new Daire(ilanBaslik, metrekare, fiyat, odaSalonSayi, tuvaletBanyoSayi, balkonSayi, ilanTipi, kullaniciID, konutTipi);

                //Daire nesnesindeki KonutEkle metoduyla nesnedeki alanları kullanarak ekleme işlemi yapıyor.
                //Başarılı olursa ekleme geriye doğru değeri dönüyor.
                //Ve başarılı olduğuna dair bir bilgi döndürüyor.
                if (d.KonutEkle())
                {
                    MessageBox.Show("Ekleme Başarılı");
                }
                //Bu methodla da İlanların bulunduğu tablodaki bilgiler doluyor.
                DaireDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        //Bu methodu Kendi ilanlarım kısmındaki tablonun içerisini doldurmak için tanımladım.
        public void MustakilDoldur()
        {
            try
            {
                //Sql sorgumuzu yazdım.
                //Bu sorguda Kullanici id'ye ve konu tipi müstakil olanlara göre gayrimenkulcülerin yayınladıkları ilanları getirdim.
                string sql = "SELECT ilan_id, ilanBaslik as [İlan Başlığı],metrekare as Metrekare,odaSalonSayi as [Oda Salon],balkonSayi as Balkon,katSayi as [Kat Sayısı],tuvaletBanyoSayi as [Tuvalet Banyo],ilanTipi as [İlan Tipi],KonutTipi as [Konut Tipi],Fiyat from Ilan_Ozellikleri where KonutTipi='Mustakil' and kullanici_id='" + lblKullaniciID.Text + "'";
                //Sql'den alınan bilgileri datagridview'e göndermek için aşağıdaki işlemleri yapıyoruz.
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand();
                command.CommandText = sql;
                command.Connection = baglanti;
                adapter.SelectCommand = command;
                baglanti.Open();
                adapter.Fill(dt);
                dgwMustakil.DataSource = dt;
                baglanti.Close();
                //İlan özelliklerinin id kısmıyla kullanıcının hiçbir işi yok. Bu yüzden onu gönderirken kapattık.
                dgwMustakil.Columns[0].Visible = false;
                //Tablonun başındaki boşluk gözükmesin diye kullandık.
                dgwMustakil.RowHeadersVisible = false;
                //Verileri tabloya sığdırmak için kullandık.
                dgwMustakil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }
        //Bu methodu Kendi ilanlarım kısmındaki tablonun içerisinde İlan Başlığına göre arama yapabilmesi için yazdım.
        public void MustakilAra()
        {
            try
            {
                //Sql sorgumuzu yazdım.
                //Bu sorguda Kullanici id'ye,ilan başlığına ve konut tipi müstakil olana göre gayrimenkulcülerin yayınladıkları ilanları getirdim.
                string sql = "SELECT ilan_id, ilanBaslik as [İlan Başlığı],metrekare as Metrekare,odaSalonSayi as [Oda Salon],balkonSayi as Balkon,katSayi as [Kat Sayısı],tuvaletBanyoSayi as [Tuvalet Banyo],ilanTipi as [İlan Tipi],KonutTipi as [Konut Tipi],Fiyat from Ilan_Ozellikleri where KonutTipi='Mustakil' and ilanBaslik Like '" + txtAraMustakil.Text + "%'and kullanici_id='" + lblKullaniciID.Text + "'";
                //Sql'den alınan bilgileri datagridview'e göndermek için aşağıdaki işlemleri yapıyoruz.
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand();
                command.CommandText = sql;
                command.Connection = baglanti;
                adapter.SelectCommand = command;
                baglanti.Open();
                adapter.Fill(dt);
                dgwMustakil.DataSource = dt;
                baglanti.Close();
                //İlan özelliklerinin id kısmıyla kullanıcının hiçbir işi yok. Bu yüzden onu gönderirken kapattık.
                dgwMustakil.Columns[0].Visible = false;
                //Tablonun başındaki boşluk gözükmesin diye kullandık.
                dgwMustakil.RowHeadersVisible = false;
                //Verileri tabloya sığdırmak için kullandık.
                dgwMustakil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        //Gayrimenkulcüler tüm ilanlar arasından spesifik bir arama yapabilsin diye tanımlandı.
        //Burada yapılan işlem girilmiş olan alanları baz alarak bir sql sorgusu yazıp o sorguya göre tabloyu doldurmak için yapılmıştır.
        public void DetayliAra()
        {
            //Sorgunun where'dan sonraki kısımlarını tek tek sonuna eklemek üzere bir sorgu yazıldı.
            string script = "SELECT io.ilan_id, io.ilanBaslik as [İlan Başlığı],io.metrekare as Metrekare,io.odaSalonSayi as [Oda Salon],io.balkonSayi as Balkon,io.katSayi as [Kat Sayısı],io.tuvaletBanyoSayi as [Tuvalet Banyo],io.ilanTipi as [İlan Tipi],io.KonutTipi as [Konut Tipi],io.Fiyat,k.emlak_adi as [Emlak Markası],k.gsmNo as [Telefon No] from Ilan_Ozellikleri io join Kullanici k on k.kullanici_id=io.kullanici_id where k.kullanici_tipi='Gayrimenkul' ";

            //Burada çok fazla if-else koşulları kullandığım için farklı bir hata çıkması durumunda message yazdırsın
            //diye bir try-catch tanımladım.
            try
            {
                //Seçilmiş Radio butonlara göre bir konut tipi ataması için aşağıdaki koşullar yazıldı.
                //Eğer dolu ise bu alanlar sorgumuzu yazdığımız script'in sonuna konut tipi ile koşul koyacak.

                if (rdGApartmanArama.Checked)
                {
                    konutTipi = "Apartman";
                    script += "and io.KonutTipi='" + konutTipi + "'";
                }
                else if (rdGDaireArama.Checked)
                {
                    konutTipi = "Daire";
                    script += "and io.KonutTipi='" + konutTipi + "'";
                }
                else if (rdGMustakilArama.Checked)
                {
                    konutTipi = "Mustakil";
                    script += "and io.KonutTipi='" + konutTipi + "'";
                }

                //Seçilmiş Radio butonlara göre bir ian tipi ataması için aşağıdaki koşullar yazıldı.
                //Eğer dolu ise bu alanlar sorgumuzu yazdığımız script'in sonuna konut tipi ile koşul koyacak.

                if (rdGAramaKiralik.Checked)
                {
                    ilanTipi = "Kiralık";
                    script += "and io.ilanTipi='" + ilanTipi + "'";
                }
                else if (rdGAramaSatilik.Checked)
                {
                    ilanTipi = "Satılık";
                    script += "and io.ilanTipi='" + ilanTipi + "'";
                }

                //Eğer dolu ise bu alanlar sorgumuzu yazdığımız script'in sonuna konut tipi ile koşul koyacak.
                if (txtGAramaMetrekare.Text != "")
                {
                    script += "and io.metrekare='" + txtGAramaMetrekare.Text + "'";
                }
                if (txtGAramaFiyat.Text != "")
                {
                    script += "and io.fiyat='" + txtGAramaFiyat.Text + "'";
                }
                if (txtGAramaBalkon.Text != "")
                {
                    script += "and io.balkonSayi='" + txtGAramaBalkon.Text + "'";
                }
                if (txtGAramaKat.Text != "")
                {
                    script += "and io.katSayi='" + txtGAramaKat.Text + "'";
                }
                if (cbxGAramaOdaSalon.Text != "")
                {
                    script += "and io.odaSalonSayi='" + cbxGAramaOdaSalon.Text + "'";
                }
                if (cbxGAramaTuvaletBanyo.Text != "")
                {
                    script += "and io.tuvaletBanyoSayi='" + cbxGAramaTuvaletBanyo.Text + "'";
                }

                //En son elde edilen script'e göre tabloya yeni bilgiler dolacak.
                //Aşağıdaki işlemlerin hepsi databaseden bilgi çekebilmek için kullanılmıştır.
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand();
                command.CommandText = script;
                command.Connection = baglanti;
                adapter.SelectCommand = command;
                baglanti.Open();
                adapter.Fill(dt);
                dgwDetayliArama.DataSource = dt;
                baglanti.Close();
                //İlan özelliklerinin id kısmıyla kullanıcının hiçbir işi yok. Bu yüzden onu gönderirken kapattık.
                dgwDetayliArama.Columns[0].Visible = false;
                //Tablonun başındaki boşluk gözükmesin diye kullandık.
                dgwDetayliArama.RowHeadersVisible = false;
                //Verileri tabloya sığdırmak için kullandık.
                dgwDetayliArama.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        //Bu methodu Kendi ilanlarım kısmındaki tablonun içerisini doldurmak için tanımladım.
        public void ApartmanDoldur()
        {
            try
            {
                //Sql sorgumuzu yazdım.
                //Bu sorguda Kullanici id'ye,ilan başlığına ve konut tipi apartman olana göre gayrimenkulcülerin yayınladıkları ilanları getirdim.
                string sql = "SELECT ilan_id, ilanBaslik as [İlan Başlığı],metrekare as Metrekare,odaSalonSayi as [Oda Salon],balkonSayi as Balkon,toplamDaireSayi as [Toplam Daire Sayisi],ilanTipi as [İlan Tipi],KonutTipi as [Konut Tipi],Fiyat from Ilan_Ozellikleri where KonutTipi='Apartman' and kullanici_id='" + lblKullaniciID.Text + "'";
                //Sql'den alınan bilgileri datagridview'e göndermek için aşağıdaki işlemleri yapıyoruz.
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand();
                command.CommandText = sql;
                command.Connection = baglanti;
                adapter.SelectCommand = command;
                baglanti.Open();
                adapter.Fill(dt);
                dgwApartman.DataSource = dt;
                baglanti.Close();
                //İlan özelliklerinin id kısmıyla kullanıcının hiçbir işi yok. Bu yüzden onu gönderirken kapattık.
                dgwApartman.Columns[0].Visible = false;
                //Tablonun başındaki boşluk gözükmesin diye kullandık.
                dgwApartman.RowHeadersVisible = false;
                //Verileri tabloya sığdırmak için kullandık.
                dgwApartman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }
        //Bu methodu Kendi ilanlarım kısmındaki tablonun içerisinde İlan Başlığına göre arama yapabilmesi için yazdım.
        public void ApartmanAra()
        {
            try
            {
                //Sql sorgumuzu yazdım.
                //Bu sorguda Kullanici id'ye,ilan başlığına ve konut tipi apartman olana göre gayrimenkulcülerin yayınladıkları ilanları getirdim.
                string sql = "SELECT ilan_id, ilanBaslik as [İlan Başlığı],metrekare as Metrekare,odaSalonSayi as [Oda Salon],balkonSayi as Balkon,toplamDaireSayi as [Toplam Daire Sayisi],ilanTipi as [İlan Tipi],KonutTipi as [Konut Tipi],Fiyat from Ilan_Ozellikleri where KonutTipi='Apartman' and ilanBaslik Like '" + txtAraApartman.Text + "%'and kullanici_id='" + lblKullaniciID.Text + "'";
                //Sql'den alınan bilgileri datagridview'e göndermek için aşağıdaki işlemleri yapıyoruz.
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand();
                command.CommandText = sql;
                command.Connection = baglanti;
                adapter.SelectCommand = command;
                baglanti.Open();
                adapter.Fill(dt);
                dgwApartman.DataSource = dt;
                baglanti.Close();
                //İlan özelliklerinin id kısmıyla kullanıcının hiçbir işi yok. Bu yüzden onu gönderirken kapattık.
                dgwApartman.Columns[0].Visible = false;
                //Tablonun başındaki boşluk gözükmesin diye kullandık.
                dgwApartman.RowHeadersVisible = false;
                //Verileri tabloya sığdırmak için kullandık.
                dgwApartman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        //Bu methodu Kendi ilanlarım kısmındaki tablonun içerisini doldurmak için tanımladım.
        public void DaireDoldur()
        {
            try
            {
                //Sql sorgumuzu yazdım.
                //Bu sorguda Kullanici id'ye,ilan başlığına ve konut tipi daire olana göre gayrimenkulcülerin yayınladıkları ilanları getirdim.
                string sql = "SELECT ilan_id, ilanBaslik as [İlan Başlığı],metrekare as Metrekare,odaSalonSayi as [Oda Salon],balkonSayi as Balkon,tuvaletBanyoSayi as [Tuvalet Banyo],ilanTipi as [İlan Tipi],KonutTipi as [Konut Tipi],Fiyat from Ilan_Ozellikleri where KonutTipi='Daire'and kullanici_id='" + lblKullaniciID.Text + "'";
                //Sql'den alınan bilgileri datagridview'e göndermek için aşağıdaki işlemleri yapıyoruz.
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand();
                command.CommandText = sql;
                command.Connection = baglanti;
                adapter.SelectCommand = command;
                baglanti.Open();
                adapter.Fill(dt);
                dgwDaire.DataSource = dt;
                baglanti.Close();
                //İlan özelliklerinin id kısmıyla kullanıcının hiçbir işi yok. Bu yüzden onu gönderirken kapattık.
                dgwDaire.Columns[0].Visible = false;
                //Tablonun başındaki boşluk gözükmesin diye kullandık.
                dgwDaire.RowHeadersVisible = false;
                //Verileri tabloya sığdırmak için kullandık.
                dgwDaire.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        //Bu methodu Kendi ilanlarım kısmındaki tablonun içerisinde İlan Başlığına göre arama yapabilmesi için yazdım.
        public void DaireAra()
        {
            try
            {
                //Sql sorgumuzu yazdım.
                //Bu sorguda Kullanici id'ye,ilan başlığına ve konut tipi daire olana göre gayrimenkulcülerin yayınladıkları ilanları getirdim.
                string sql = "SELECT ilan_id, ilanBaslik as [İlan Başlığı],metrekare as Metrekare,odaSalonSayi as [Oda Salon],balkonSayi as Balkon,tuvaletBanyoSayi as [Tuvalet Banyo],ilanTipi as [İlan Tipi],KonutTipi as [Konut Tipi],Fiyat from Ilan_Ozellikleri where KonutTipi='Daire' and ilanBaslik Like '" + txtAraDaire.Text + "%'and kullanici_id='" + lblKullaniciID.Text + "'";
                //Sql'den alınan bilgileri datagridview'e göndermek için aşağıdaki işlemleri yapıyoruz.
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand();
                command.CommandText = sql;
                command.Connection = baglanti;
                adapter.SelectCommand = command;
                baglanti.Open();
                adapter.Fill(dt);
                dgwDaire.DataSource = dt;
                baglanti.Close();
                //İlan özelliklerinin id kısmıyla kullanıcının hiçbir işi yok. Bu yüzden onu gönderirken kapattık.
                dgwDaire.Columns[0].Visible = false;
                //Tablonun başındaki boşluk gözükmesin diye kullandık.
                dgwDaire.RowHeadersVisible = false;
                //Verileri tabloya sığdırmak için kullandık.
                dgwDaire.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        //Bu methodu comboboxların içerisine hazır değerleri kullanabilmek için atama işlemi yapsın diye tanımladım.
        //Bu işlemi tanımlama sebebim bu doldurma işini birden fazla combobox için yapmak zorunda olduğumdan tanımladım.
        public void CboxDoldur()
        {
            //Bir liste tanımladım.
            List<string> OdaSalonTipi = new List<string>();
            //Listeye değerleri atadım.
            OdaSalonTipi.Add("1+0");
            OdaSalonTipi.Add("1+1");
            OdaSalonTipi.Add("2+1");
            OdaSalonTipi.Add("3+1");
            OdaSalonTipi.Add("4+1");
            OdaSalonTipi.Add("5+1");
            //O değerleri tek tek aldırtıp ilgili combobox'a atadım.
            foreach (var item in OdaSalonTipi)
            {
                txtMustakilOdaSalon.Items.Add(item);
                txtDaireOdaSalon.Items.Add(item);
                txtApartmanOdaSalon.Items.Add(item);
                cbxGAramaOdaSalon.Items.Add(item);
            }

            //Bir liste tanımladım.
            List<string> TuvaletBanyoTipi = new List<string>();
            //Listeye değerleri atadım.
            TuvaletBanyoTipi.Add("1+1");
            TuvaletBanyoTipi.Add("2+1");
            TuvaletBanyoTipi.Add("2+2");
            TuvaletBanyoTipi.Add("3+1");
            TuvaletBanyoTipi.Add("3+2");
            TuvaletBanyoTipi.Add("3+3");
            //O değerleri tek tek aldırtıp ilgili combobox'a atadım.
            foreach (var item in TuvaletBanyoTipi)
            {
                txtMustakilTuvaletBanyo.Items.Add(item);
                txtDaireTuvaletBanyo.Items.Add(item);
                cbxGAramaTuvaletBanyo.Items.Add(item);
            }
        }


        private void GayrimenkulForm_Load(object sender, EventArgs e)
        {
            //Burada kullanıcı giriş yaparken hangi id ile girdiyse onu tutuyorum.
            //Bu id yi diğer yerlerde kullanmak için bir textbox'a atıyorum.
            //O textbox'ı da, textbox ayarlarından gizliyorum.
            lblKullaniciID.Text = KullaniciGiris.KullaniciID;
            //Form başlatıldığında ilgili tabloları doldursun diye tanımladım.
            MustakilDoldur();
            ApartmanDoldur();
            DaireDoldur();
            // Tüm combobox'ların içine başlatıldığında değerlerini atamak için kullandım.
            CboxDoldur();
            //Gelirken tüm formu temizlesin
            FormTemizle();
        }
        private void txtAraMustakil_TextChanged(object sender, EventArgs e)
        {
            //Mustakildeki arama text butonunda herhangi bir değişiklik olursa çalışsın diye bu methodu tanımladım.
            MustakilAra();
        }
        private void txtAraApartman_TextChanged(object sender, EventArgs e)
        {
            //Apartmandaki arama text butonunda herhangi bir değişiklik olursa çalışsın diye bu methodu tanımladım.
            ApartmanAra();
        }
        private void txtAraDaire_TextChanged(object sender, EventArgs e)
        {
            //Dairedeki arama text butonunda herhangi bir değişiklik olursa çalışsın diye bu methodu tanımladım.
            DaireAra();
        }

        private void btnMustakilGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                //Nesnenin alanlarına ilgili atamaları gerçekleştirmek için değişkenlere değerlerini atadım.
                konutTipi = "Mustakil";
                ilanID = Convert.ToInt32(txtIlanID.Text);
                ilanBaslik = txtMustakilBaslik.Text;
                metrekare = Convert.ToInt32(txtMustakilMetrekare.Text);
                fiyat = Convert.ToDouble(txtMustakilFiyat.Text);
                odaSalonSayi = txtMustakilOdaSalon.Text;
                balkonSayi = Convert.ToInt32(txtMustakilBalkon.Text);
                katSayi = Convert.ToInt32(txtMustakilKat.Text);
                tuvaletBanyoSayi = txtMustakilTuvaletBanyo.Text;

                //Satılık radio butonu seçiliyse ilanTipi'ni Satılık yapması için yazdım.
                if (rdMustakilSatilik.Checked)
                {
                    ilanTipi = "Satılık";
                }
                //Kiralık radio butonu seçiliyse ilanTipi'ni Kiralık yapması için yazdım.
                else if (rdMustakilKiralik.Checked)
                {
                    ilanTipi = "Kiralık";
                }

                //Mustakil Nesnesi tanımladım.(ilanID'li olanı tanımladım çünkü güncellemeyi ilan id'ye göre yapıyor benim bu nesnede ihtiyacım olacak.)
                Mustakil m = new Mustakil(ilanID, ilanBaslik, metrekare, fiyat, odaSalonSayi, tuvaletBanyoSayi, balkonSayi, katSayi, ilanTipi, kullaniciID, konutTipi);

                //Nesneden aldığı bilgileri kullanarak seçili olan ilan id'sine göre güncelleme yapıyor.
                //Aşağıdaki method başarılı olursa true değeri döndürüyor.
                //True dönerse aşağıdaki gibi bir bildirim bastırıyoruz.
                //Methodu sınıftan çağırdık.
                if (m.Ilan_Guncelle())
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    //Daha sonra o güncellenmiş haliyle tekrar yazsın diye bu methodu çağırıyoruz.
                    MustakilDoldur();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        //Mustakil'e ait olan datagridview'de seçili olan satırdaki bilgilere göre combobox'ları doldursun diye kullandım.
        //Bunu yapmamın nedeni güncelleme yaparken buradan seçip onda göre değerleri değiştirip tekrardan yerine koyması için yaptım.
        private void dgwMustakil_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //seçilen indexteki tüm satırı seçsin diye tanımladım.
                dgwMustakil.Rows[e.RowIndex].Selected = true;

                //Eğer seçilmiş satır null'dan farklı ise ilgili alanları sutün sayılarına göre atayacak.
                if (dgwMustakil.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
                {
                    txtIlanID.Text = (dgwMustakil.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtMustakilBaslik.Text = (dgwMustakil.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txtMustakilMetrekare.Text = (dgwMustakil.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtMustakilOdaSalon.Text = (dgwMustakil.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtMustakilBalkon.Text = (dgwMustakil.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txtMustakilKat.Text = (dgwMustakil.Rows[e.RowIndex].Cells[5].Value.ToString());
                    txtMustakilTuvaletBanyo.Text = (dgwMustakil.Rows[e.RowIndex].Cells[6].Value.ToString());

                    //Burada da eğer ilgili sutündaki değer satılık'a eşitse satılık radio butonunu seçili yapsın.
                    if (dgwMustakil.Rows[e.RowIndex].Cells[7].Value.ToString() == "Satılık")
                    {
                        rdMustakilSatilik.Checked = true;
                    }
                    //Eğer kiralık ise kiralık radio butonunu seçili yapsın.
                    else
                    {
                        rdMustakilKiralik.Checked = true;
                    }

                    txtMustakilFiyat.Text = (dgwMustakil.Rows[e.RowIndex].Cells[9].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        private void btnApartmanGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                //Nesnenin alanlarına ilgili atamaları gerçekleştirmek için değişkenlere değerlerini atadım.
                ilanID = Convert.ToInt32(txtIlanID.Text);
                konutTipi = "Apartman";
                ilanBaslik = txtApartmanBaslik.Text;
                metrekare = Convert.ToInt32(txtApartmanMetrekare.Text);
                fiyat = Convert.ToDouble(txtApartmanFiyat.Text);
                odaSalonSayi = txtApartmanOdaSalon.Text;
                balkonSayi = Convert.ToInt32(txtApartmanBalkon.Text);
                toplamDaireSayisi = Convert.ToInt32(txtApartmanToplamDaire.Text);

                //Satılık radio butonu seçiliyse ilanTipi'ni Satılık yapması için yazdım.
                if (rdApartmanSatilik.Checked)
                {
                    ilanTipi = "Satılık";
                }
                //Kiralık radio butonu seçiliyse ilanTipi'ni Kiralık yapması için yazdım.
                else if (rdApartmanKiralik.Checked)
                {
                    ilanTipi = "Kiralık";
                }
                //Apartman nesnesini tanımladım.(ilanID'li olanı tanımladım çünkü güncellemeyi ilan id'ye göre yapıyor benim bu nesnede ihtiyacım olacak.)
                Apartman a = new Apartman(ilanID, ilanBaslik, metrekare, fiyat, odaSalonSayi, toplamDaireSayisi, balkonSayi, ilanTipi, kullaniciID, konutTipi);

                //Nesneden aldığı bilgileri kullanarak seçili olan ilan id'sine göre güncelleme yapıyor.
                //Aşağıdaki method başarılı olursa true değeri döndürüyor.
                //True dönerse aşağıdaki gibi bir bildirim bastırıyoruz.
                if (a.Ilan_Guncelle())
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    //Daha sonra o güncellenmiş haliyle tekrar yazsın diye bu methodu çağırıyoruz.
                    ApartmanDoldur();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        //Apartman'a ait olan datagridview'de seçili olan satırdaki bilgilere göre combobox'ları doldursun diye kullandım.
        //Bunu yapmamın nedeni güncelleme yaparken buradan seçip onda göre değerleri değiştirip tekrardan yerine koyması için yaptım.
        private void dgwApartman_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //seçilen indexteki tüm satırı seçsin diye tanımladım.
                dgwApartman.Rows[e.RowIndex].Selected = true;

                //Eğer seçilmiş satır null'dan farklı ise ilgili alanları sutün sayılarına göre atayacak.
                if (dgwApartman.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
                {
                    txtIlanID.Text = (dgwApartman.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtApartmanBaslik.Text = (dgwApartman.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txtApartmanMetrekare.Text = (dgwApartman.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtApartmanOdaSalon.Text = (dgwApartman.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtApartmanBalkon.Text = (dgwApartman.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txtApartmanToplamDaire.Text = (dgwApartman.Rows[e.RowIndex].Cells[5].Value.ToString());

                    //Burada da eğer ilgili sutündaki değer satılık'a eşitse satılık radio butonunu seçili yapsın.
                    if (dgwApartman.Rows[e.RowIndex].Cells[6].Value.ToString() == "Satılık")
                    {
                        rdApartmanSatilik.Checked = true;
                    }
                    //Eğer kiralık ise kiralık radio butonunu seçili yapsın.
                    else
                    {
                        rdApartmanKiralik.Checked = true;
                    }

                    txtApartmanFiyat.Text = (dgwApartman.Rows[e.RowIndex].Cells[8].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        //Daire'ye ait olan datagridview'de seçili olan satırdaki bilgilere göre combobox'ları doldursun diye kullandım.
        //Bunu yapmamın nedeni güncelleme yaparken buradan seçip onda göre değerleri değiştirip tekrardan yerine koyması için yaptım.
        private void dgwDaire_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //seçilen indexteki tüm satırı seçsin diye tanımladım.
                dgwDaire.Rows[e.RowIndex].Selected = true;

                //Eğer seçilmiş satır null'dan farklı ise ilgili alanları sutün sayılarına göre atayacak.
                if (dgwDaire.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
                {
                    txtIlanID.Text = (dgwDaire.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtDaireBaslik.Text = (dgwDaire.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txtDaireMetrekare.Text = (dgwDaire.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtDaireOdaSalon.Text = (dgwDaire.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtDaireBalkon.Text = (dgwDaire.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txtDaireTuvaletBanyo.Text = (dgwDaire.Rows[e.RowIndex].Cells[5].Value.ToString());

                    //Burada da eğer ilgili sutündaki değer satılık'a eşitse satılık radio butonunu seçili yapsın.
                    if (dgwDaire.Rows[e.RowIndex].Cells[6].Value.ToString() == "Satılık")
                    {
                        rdDaireSatilik.Checked = true;
                    }
                    //Eğer kiralık ise kiralık radio butonunu seçili yapsın.
                    else
                    {
                        rdDaireKiralik.Checked = true;
                    }

                    txtDaireFiyat.Text = (dgwDaire.Rows[e.RowIndex].Cells[8].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        private void btnDaireGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                //Nesnenin alanlarına ilgili atamaları gerçekleştirmek için değişkenlere değerlerini atadım.
                konutTipi = "Daire";
                ilanID = Convert.ToInt32(txtIlanID.Text);
                ilanBaslik = txtDaireBaslik.Text;
                metrekare = Convert.ToInt32(txtDaireMetrekare.Text);
                fiyat = Convert.ToDouble(txtDaireFiyat.Text);
                odaSalonSayi = txtDaireOdaSalon.Text;
                balkonSayi = Convert.ToInt32(txtDaireBalkon.Text);
                tuvaletBanyoSayi = txtDaireTuvaletBanyo.Text;


                //Satılık radio butonu seçiliyse ilanTipi'ni Satılık yapması için yazdım.
                if (rdDaireSatilik.Checked)
                {
                    ilanTipi = "Satılık";
                }
                //Kiralık radio butonu seçiliyse ilanTipi'ni Kiralık yapması için yazdım.
                else if (rdDaireKiralik.Checked)
                {
                    ilanTipi = "Kiralık";
                }

                //Daire nesnesini tanımladım. (ilanID'li olanı tanımladım çünkü güncellemeyi ilan id'ye göre yapıyor benim bu nesnede ihtiyacım olacak.)
                Daire d = new Daire(ilanID, ilanBaslik, metrekare, fiyat, odaSalonSayi, tuvaletBanyoSayi, balkonSayi, ilanTipi, kullaniciID, konutTipi);

                //Nesneden aldığı bilgileri kullanarak seçili olan ilan id'sine göre güncelleme yapıyor.
                //Aşağıdaki method başarılı olursa true değeri döndürüyor.
                //True dönerse aşağıdaki gibi bir bildirim bastırıyoruz.
                if (d.Ilan_Guncelle())
                {
                    MessageBox.Show("Guncelleme Başarılı");
                    //Daha sonra o güncellenmiş haliyle tekrar yazsın diye bu methodu çağırıyoruz.
                    DaireDoldur();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        private void btnMustakilSil_Click(object sender, EventArgs e)
        {
            try
            {
                //ilan id'yi yine form ekranında gizlemiştim.
                //Tablodan seçilmiş bir değeri ilanID label'ına atıyor.
                ilanID = Convert.ToInt32(txtIlanID.Text);

                //Mustakil Nesnesi tanımladım.(ilanID'li olanı tanımladım çünkü silmeyi ilan id'ye göre yapıyor benim bu nesnede ihtiyacım olacak.)
                Mustakil m = new Mustakil(ilanID);

                //Nesneden aldığı ilan id değeriyle aşağıdaki methodu çalıştırıyor
                //Bu method sayesinde ilan id'ye göre ilanı sildirtiyorum.
                //Sildiğinde true değer dönüyor ve aşağıdaki mesajı bastırıyorum.
                if (m.KonutSil())
                {
                    MessageBox.Show("İlan Silindi !");
                    //Silinmiş haliyle tekrardan tabloyu dolduruyorum.
                    MustakilDoldur();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        private void btnApartmanSil_Click(object sender, EventArgs e)
        {
            try
            {
                //ilan id'yi yine form ekranında gizlemiştim.
                //Tablodan seçilmiş bir değeri ilanID label'ına atıyor.
                ilanID = Convert.ToInt32(txtIlanID.Text);

                //Apartman Nesnesi tanımladım.(ilanID'li olanı tanımladım çünkü silmeyi ilan id'ye göre yapıyor benim bu nesnede ihtiyacım olacak.)
                Apartman a = new Apartman(ilanID);

                //Nesneden aldığı ilan id değeriyle aşağıdaki methodu çalıştırıyor
                //Bu method sayesinde ilan id'ye göre ilanı sildirtiyorum.
                //Sildiğinde true değer dönüyor ve aşağıdaki mesajı bastırıyorum.
                if (a.KonutSil())
                {
                    MessageBox.Show("İlan Silindi !");
                    //Silinmiş haliyle tekrardan tabloyu dolduruyorum.
                    ApartmanDoldur();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        private void btnDaireSil_Click(object sender, EventArgs e)
        {
            try
            {
                //ilan id'yi yine form ekranında gizlemiştim.
                //Tablodan seçilmiş bir değeri ilanID label'ına atıyor.
                ilanID = Convert.ToInt32(txtIlanID.Text);

                //Apartman Nesnesi tanımladım.(ilanID'li olanı tanımladım çünkü silmeyi ilan id'ye göre yapıyor benim bu nesnede ihtiyacım olacak.)
                Daire d = new Daire(ilanID);

                //Nesneden aldığı ilan id değeriyle aşağıdaki methodu çalıştırıyor
                //Bu method sayesinde ilan id'ye göre ilanı sildirtiyorum.
                //Sildiğinde true değer dönüyor ve aşağıdaki mesajı bastırıyorum.
                if (d.KonutSil())
                {
                    MessageBox.Show("İlan Silindi !");
                    //Silinmiş haliyle tekrardan tabloyu dolduruyorum.
                    DaireDoldur();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        private void btmFormTemizle_Click(object sender, EventArgs e)
        {
            //Formda bulunan tüm girilmiş değerleri temizletmek için tanımladığım methodu çağırıyorum.
            FormTemizle();
        }

        private void btnMustakilTemizle_Click(object sender, EventArgs e)
        {
            //Formda bulunan tüm girilmiş değerleri temizletmek için tanımladığım methodu çağırıyorum.
            FormTemizle();
        }

        private void btnDaireTemizle_Click(object sender, EventArgs e)
        {
            //Formda bulunan tüm girilmiş değerleri temizletmek için tanımladığım methodu çağırıyorum.
            FormTemizle();
        }

        private void btnGIlanAra_Click(object sender, EventArgs e)
        {
            //Formda bulunan tüm girilmiş değerleri temizletmek için tanımladığım methodu çağırıyorum.
            DetayliAra();
        }

        private void btnDaireKomisyonHesap_Click(object sender, EventArgs e)
        {
            try
            {
                //Daire'deki Komisyon oranını hesaplayıp ekrandaki textbox'a yazması için kullandım.
                //fiyat'ı tanımladım.
                fiyat = Convert.ToDouble(txtDaireFiyat.Text);
                //Burada yapıcı method'la fiyatı nesneye göndermiş oldum.
                Daire daire = new Daire(fiyat);
                //Komisyon hesapla metodunu ezdirerek hesaplattırdım.
                txtDaireKomisyon.Text = daire.KomisyonHesapla().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        private void btnMustakilKomisyonHesap_Click(object sender, EventArgs e)
        {
            try
            {
                //Mustakil'deki Komisyon oranını hesaplayıp ekrandaki textbox'a yazması için kullandım.
                //Burada fiyatı tanımladım.
                fiyat = Convert.ToDouble(txtMustakilFiyat.Text);
                //Burada yapıcı method'la fiyatı nesneye göndermiş oldum.
                Mustakil mustakil = new Mustakil(fiyat);
                //Komisyon hesapla metodunu ezdirerek hesaplattırdım.
                txtMustakilKomisyon.Text = mustakil.KomisyonHesapla().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        private void btnApartmanKomisyonHesap_Click(object sender, EventArgs e)
        {
            try
            {
                //Apartman'daki Komisyon oranını hesaplayıp ekrandaki textbox'a yazması için kullandım.
                //Burada fiyatı tanımladım.
                fiyat = Convert.ToDouble(txtApartmanFiyat.Text);
                //Burada yapıcı method'la fiyatı nesneye göndermiş oldum.
                Apartman s = new Apartman(fiyat);
                //Komisyon hesapla metodunu ezdirerek hesaplattırdım.
                txtApartmanKomisyon.Text = s.KomisyonHesapla().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
            }
        }

        private void KonutSekme_MouseClick(object sender, MouseEventArgs e)
        {
            //Formda bulunan tüm girilmiş değerleri her sekmelere(Mustakil, Apartman ve Daire sekmelerine) tıklandığında temizletmek için tanımladığım methodu çağırıyorum.
            FormTemizle();
        }

        private void btnAramaFormuSil_Click(object sender, EventArgs e)
        {
            //Formda bulunan tüm girilmiş değerleri her sekmelere(Mustakil, Apartman ve Daire sekmelerine) tıklandığında temizletmek için tanımladığım methodu çağırıyorum.
            FormTemizle();
        }
    }
}
