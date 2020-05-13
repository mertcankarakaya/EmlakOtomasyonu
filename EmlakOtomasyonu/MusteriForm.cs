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
    public partial class MusteriForm : Form
    {
        //MSSQL'e bağlantı kurması için tanımladım.
        SqlConnection baglanti = new SqlConnection("Data Source=MERTCAN\\MERTCAN; initial Catalog=EmlakOtomasyonu; Integrated Security=true");
        public MusteriForm()
        {
            InitializeComponent();
        }
        //Müşteriler tüm ilanlar arasından spesifik bir arama yapabilsin diye tanımlandı.
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
                string konutTipi = "";
                if (rdMApartmanArama.Checked)
                {
                    konutTipi = "Apartman";
                    script += "and io.KonutTipi='" + konutTipi + "'";
                }
                else if (rdMDaireArama.Checked)
                {
                    konutTipi = "Daire";
                    script += "and io.KonutTipi='" + konutTipi + "'";
                }
                else if (rdMMustakilArama.Checked)
                {
                    konutTipi = "Mustakil";
                    script += "and io.KonutTipi='" + konutTipi + "'";
                }

                //Seçilmiş Radio butonlara göre bir ian tipi ataması için aşağıdaki koşullar yazıldı.
                //Eğer dolu ise bu alanlar sorgumuzu yazdığımız script'in sonuna konut tipi ile koşul koyacak.
                string ilantipi = "";
                if (rdMAramaKiralik.Checked)
                {
                    ilantipi = "Kiralık";
                    script += "and io.ilanTipi='" + ilantipi + "'";
                }
                else if (rdMAramaSatilik.Checked)
                {
                    ilantipi = "Satılık";
                    script += "and io.ilanTipi='" + ilantipi + "'";
                }

                //Eğer dolu ise bu alanlar sorgumuzu yazdığımız script'in sonuna konut tipi ile koşul koyacak.
                if (txtMAramaMetrekare.Text != "")
                {
                    script += "and io.metrekare='" + txtMAramaMetrekare.Text + "'";
                }
                if (txtMAramaFiyat.Text != "")
                {
                    script += "and io.fiyat='" + txtMAramaFiyat.Text + "'";
                }
                if (txtMAramaBalkon.Text != "")
                {
                    script += "and io.balkonSayi='" + txtMAramaBalkon.Text + "'";
                }
                if (txtMAramaKat.Text != "")
                {
                    script += "and io.katSayi='" + txtMAramaKat.Text + "'";
                }
                if (cbxMAramaOdaSalon.Text != "")
                {
                    script += "and io.odaSalonSayi='" + cbxMAramaOdaSalon.Text + "'";
                }
                if (cbxMAramaTuvaletBanyo.Text != "")
                {
                    script += "and io.tuvaletBanyoSayi='" + cbxMAramaTuvaletBanyo.Text + "'";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. Bir hata ile karşılaşıldı. Lütfen Yaptığınız işlemi kontrol edip tekrar deneyin.");
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
                cbxMAramaOdaSalon.Items.Add(item);
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
                cbxMAramaTuvaletBanyo.Items.Add(item);
            }
        }
        //Textbox, combobox ve radio button'ların değerlerini silmesi için tanımladım.
        public void FormTemizle()
        {
            //Müşteri Arama için temizleme tanımları
            txtMAramaBalkon.Text = "";
            txtMAramaFiyat.Text = "";
            txtMAramaKat.Text = "";
            txtMAramaMetrekare.Text = "";
            rdMAramaKiralik.Checked = false;
            rdMAramaSatilik.Checked = false;
            rdMMustakilArama.Checked = false;
            rdMDaireArama.Checked = false;
            rdMApartmanArama.Checked = false;
            cbxMAramaTuvaletBanyo.Text = "";
            cbxMAramaOdaSalon.Text = "";
            
        }

        private void btnMIlanAra_Click(object sender, EventArgs e)
        {
            //Bu butona bastığın aşağıdaki method çalışıp değerleri gönderme işlemi yapıyor.
            DetayliAra();
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            //Form açıldığında combobox'lardaki ilgili alanlar dolsun diye aşağıdaki methodu tanımladım.
            CboxDoldur();
        }

        private void btnMusteriTemizle_Click(object sender, EventArgs e)
        {
            //Tüm formu temizle butonuna bastığında çalışması için yazdım.
            FormTemizle();
        }
    }
}
