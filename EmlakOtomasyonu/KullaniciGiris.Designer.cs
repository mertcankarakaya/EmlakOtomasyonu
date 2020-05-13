namespace EmlakOtomasyonu
{
    partial class KullaniciGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnGayrimenkulGiris = new System.Windows.Forms.RadioButton();
            this.rdBtnMusteriGiris = new System.Windows.Forms.RadioButton();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnKayit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdGayrimenkulKayit = new System.Windows.Forms.RadioButton();
            this.txtGKayitSifre = new System.Windows.Forms.TextBox();
            this.txtGKayitKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtGKayitTelNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGKayitSoyad = new System.Windows.Forms.TextBox();
            this.txtGKayitAd = new System.Windows.Forms.TextBox();
            this.txtGGayrimenkulKayitAd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdMusteriKayit = new System.Windows.Forms.RadioButton();
            this.txtMKayitSifre = new System.Windows.Forms.TextBox();
            this.txtMKayitKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtMKayitTelNo = new System.Windows.Forms.TextBox();
            this.txtMKayitSoyadi = new System.Windows.Forms.TextBox();
            this.txtMKayitAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(72, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.rdBtnGayrimenkulGiris);
            this.groupBox1.Controls.Add(this.rdBtnMusteriGiris);
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKullaniciAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(164, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 331);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Girişi";
            // 
            // rdBtnGayrimenkulGiris
            // 
            this.rdBtnGayrimenkulGiris.AutoSize = true;
            this.rdBtnGayrimenkulGiris.Location = new System.Drawing.Point(194, -3);
            this.rdBtnGayrimenkulGiris.Name = "rdBtnGayrimenkulGiris";
            this.rdBtnGayrimenkulGiris.Size = new System.Drawing.Size(178, 28);
            this.rdBtnGayrimenkulGiris.TabIndex = 11;
            this.rdBtnGayrimenkulGiris.TabStop = true;
            this.rdBtnGayrimenkulGiris.Text = "Gayrimenkul Giriş";
            this.rdBtnGayrimenkulGiris.UseVisualStyleBackColor = true;
            // 
            // rdBtnMusteriGiris
            // 
            this.rdBtnMusteriGiris.AutoSize = true;
            this.rdBtnMusteriGiris.Location = new System.Drawing.Point(6, -3);
            this.rdBtnMusteriGiris.Name = "rdBtnMusteriGiris";
            this.rdBtnMusteriGiris.Size = new System.Drawing.Size(134, 28);
            this.rdBtnMusteriGiris.TabIndex = 10;
            this.rdBtnMusteriGiris.TabStop = true;
            this.rdBtnMusteriGiris.Text = "Müşteri Giriş";
            this.rdBtnMusteriGiris.UseVisualStyleBackColor = true;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(76, 222);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(269, 42);
            this.btnGiris.TabIndex = 9;
            this.btnGiris.Text = "Giriş Yap ve Devam Et";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(76, 162);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(269, 28);
            this.txtSifre.TabIndex = 8;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(76, 90);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(269, 28);
            this.txtKullaniciAd.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 602);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Üye Girişi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btnKayit);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Üye ol";
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.Color.White;
            this.btnKayit.Location = new System.Drawing.Point(450, 518);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(269, 47);
            this.btnKayit.TabIndex = 33;
            this.btnKayit.Text = "Üye Ol ve Devam Et";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.rdGayrimenkulKayit);
            this.groupBox3.Controls.Add(this.txtGKayitSifre);
            this.groupBox3.Controls.Add(this.txtGKayitKullaniciAd);
            this.groupBox3.Controls.Add(this.txtGKayitTelNo);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtGKayitSoyad);
            this.groupBox3.Controls.Add(this.txtGKayitAd);
            this.groupBox3.Controls.Add(this.txtGGayrimenkulKayitAd);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox3.Location = new System.Drawing.Point(377, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 408);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri Kayıt";
            // 
            // rdGayrimenkulKayit
            // 
            this.rdGayrimenkulKayit.AutoSize = true;
            this.rdGayrimenkulKayit.Location = new System.Drawing.Point(11, -1);
            this.rdGayrimenkulKayit.Name = "rdGayrimenkulKayit";
            this.rdGayrimenkulKayit.Size = new System.Drawing.Size(180, 28);
            this.rdGayrimenkulKayit.TabIndex = 33;
            this.rdGayrimenkulKayit.TabStop = true;
            this.rdGayrimenkulKayit.Text = "Gayrimenkul Kayıt";
            this.rdGayrimenkulKayit.UseVisualStyleBackColor = true;
            this.rdGayrimenkulKayit.CheckedChanged += new System.EventHandler(this.rdGayrimenkulKayit_CheckedChanged);
            // 
            // txtGKayitSifre
            // 
            this.txtGKayitSifre.Location = new System.Drawing.Point(38, 360);
            this.txtGKayitSifre.Name = "txtGKayitSifre";
            this.txtGKayitSifre.Size = new System.Drawing.Size(269, 28);
            this.txtGKayitSifre.TabIndex = 26;
            // 
            // txtGKayitKullaniciAd
            // 
            this.txtGKayitKullaniciAd.Location = new System.Drawing.Point(38, 293);
            this.txtGKayitKullaniciAd.Name = "txtGKayitKullaniciAd";
            this.txtGKayitKullaniciAd.Size = new System.Drawing.Size(269, 28);
            this.txtGKayitKullaniciAd.TabIndex = 31;
            // 
            // txtGKayitTelNo
            // 
            this.txtGKayitTelNo.Location = new System.Drawing.Point(38, 222);
            this.txtGKayitTelNo.Name = "txtGKayitTelNo";
            this.txtGKayitTelNo.Size = new System.Drawing.Size(269, 28);
            this.txtGKayitTelNo.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(34, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 24);
            this.label14.TabIndex = 24;
            this.label14.Text = "Şifre";
            this.label14.UseWaitCursor = true;
            // 
            // txtGKayitSoyad
            // 
            this.txtGKayitSoyad.Location = new System.Drawing.Point(180, 154);
            this.txtGKayitSoyad.Name = "txtGKayitSoyad";
            this.txtGKayitSoyad.Size = new System.Drawing.Size(127, 28);
            this.txtGKayitSoyad.TabIndex = 29;
            // 
            // txtGKayitAd
            // 
            this.txtGKayitAd.Location = new System.Drawing.Point(38, 154);
            this.txtGKayitAd.Name = "txtGKayitAd";
            this.txtGKayitAd.Size = new System.Drawing.Size(127, 28);
            this.txtGKayitAd.TabIndex = 24;
            // 
            // txtGGayrimenkulKayitAd
            // 
            this.txtGGayrimenkulKayitAd.Location = new System.Drawing.Point(38, 87);
            this.txtGGayrimenkulKayitAd.Name = "txtGGayrimenkulKayitAd";
            this.txtGGayrimenkulKayitAd.Size = new System.Drawing.Size(269, 28);
            this.txtGGayrimenkulKayitAd.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(173, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 24);
            this.label15.TabIndex = 27;
            this.label15.Text = "Soyadı";
            this.label15.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Telefon Numarası";
            this.label5.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(34, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "Gayrimenkul Adı";
            this.label11.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(34, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "Adı";
            this.label12.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(34, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 24);
            this.label13.TabIndex = 14;
            this.label13.Text = "Kullanıcı Adı";
            this.label13.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(233, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.rdMusteriKayit);
            this.groupBox2.Controls.Add(this.txtMKayitSifre);
            this.groupBox2.Controls.Add(this.txtMKayitKullaniciAd);
            this.groupBox2.Controls.Add(this.txtMKayitTelNo);
            this.groupBox2.Controls.Add(this.txtMKayitSoyadi);
            this.groupBox2.Controls.Add(this.txtMKayitAd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(8, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 408);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Kayıt";
            // 
            // rdMusteriKayit
            // 
            this.rdMusteriKayit.AutoSize = true;
            this.rdMusteriKayit.Location = new System.Drawing.Point(6, -1);
            this.rdMusteriKayit.Name = "rdMusteriKayit";
            this.rdMusteriKayit.Size = new System.Drawing.Size(136, 28);
            this.rdMusteriKayit.TabIndex = 25;
            this.rdMusteriKayit.TabStop = true;
            this.rdMusteriKayit.Text = "Müşteri Kayıt";
            this.rdMusteriKayit.UseVisualStyleBackColor = true;
            this.rdMusteriKayit.CheckedChanged += new System.EventHandler(this.rdMusteriKayit_CheckedChanged);
            // 
            // txtMKayitSifre
            // 
            this.txtMKayitSifre.Location = new System.Drawing.Point(37, 360);
            this.txtMKayitSifre.Name = "txtMKayitSifre";
            this.txtMKayitSifre.Size = new System.Drawing.Size(269, 28);
            this.txtMKayitSifre.TabIndex = 22;
            // 
            // txtMKayitKullaniciAd
            // 
            this.txtMKayitKullaniciAd.Location = new System.Drawing.Point(37, 293);
            this.txtMKayitKullaniciAd.Name = "txtMKayitKullaniciAd";
            this.txtMKayitKullaniciAd.Size = new System.Drawing.Size(269, 28);
            this.txtMKayitKullaniciAd.TabIndex = 21;
            // 
            // txtMKayitTelNo
            // 
            this.txtMKayitTelNo.Location = new System.Drawing.Point(37, 222);
            this.txtMKayitTelNo.Name = "txtMKayitTelNo";
            this.txtMKayitTelNo.Size = new System.Drawing.Size(269, 28);
            this.txtMKayitTelNo.TabIndex = 20;
            // 
            // txtMKayitSoyadi
            // 
            this.txtMKayitSoyadi.Location = new System.Drawing.Point(37, 154);
            this.txtMKayitSoyadi.Name = "txtMKayitSoyadi";
            this.txtMKayitSoyadi.Size = new System.Drawing.Size(269, 28);
            this.txtMKayitSoyadi.TabIndex = 19;
            // 
            // txtMKayitAd
            // 
            this.txtMKayitAd.Location = new System.Drawing.Point(37, 87);
            this.txtMKayitAd.Name = "txtMKayitAd";
            this.txtMKayitAd.Size = new System.Drawing.Size(269, 28);
            this.txtMKayitAd.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(33, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Telefon Numarası";
            this.label10.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(33, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adı";
            this.label7.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(33, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Soyadı";
            this.label8.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(33, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı Adı";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre";
            this.label4.UseWaitCursor = true;
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(736, 602);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciGiris";
            this.Text = "MK Emlak - Kullanıcı Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.TextBox txtGKayitSifre;
        private System.Windows.Forms.TextBox txtGKayitKullaniciAd;
        private System.Windows.Forms.TextBox txtGKayitTelNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGKayitSoyad;
        private System.Windows.Forms.TextBox txtGKayitAd;
        private System.Windows.Forms.TextBox txtGGayrimenkulKayitAd;
        private System.Windows.Forms.TextBox txtMKayitSifre;
        private System.Windows.Forms.TextBox txtMKayitKullaniciAd;
        private System.Windows.Forms.TextBox txtMKayitTelNo;
        private System.Windows.Forms.TextBox txtMKayitSoyadi;
        private System.Windows.Forms.TextBox txtMKayitAd;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.RadioButton rdBtnGayrimenkulGiris;
        private System.Windows.Forms.RadioButton rdBtnMusteriGiris;
        private System.Windows.Forms.RadioButton rdGayrimenkulKayit;
        private System.Windows.Forms.RadioButton rdMusteriKayit;
        private System.Windows.Forms.Button btnKayit;
    }
}

