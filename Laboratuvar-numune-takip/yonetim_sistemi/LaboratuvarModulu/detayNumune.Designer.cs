namespace yonetim_sistemi.LaboratuvarModulu
{
	partial class detayNumune
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grdurun = new System.Windows.Forms.DataGridView();
            this.cmbDeneyMethodu = new System.Windows.Forms.ComboBox();
            this.txtnumuneAdi = new System.Windows.Forms.TextBox();
            this.txtnumuneNo = new System.Windows.Forms.TextBox();
            this.btnyazdir = new System.Windows.Forms.Button();
            this.txturunid = new System.Windows.Forms.TextBox();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.txtnotlar = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtfirmaadres = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtbitistarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dttesttarihi = new System.Windows.Forms.DateTimePicker();
            this.dtgiristarihi = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcikistateslimalan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtgiristeteslimalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcikistateslimeden = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtgiristeteslimeden = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfirmamail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtyetkilikisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfirmatel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfirmaad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtistekno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnumunekaydet = new System.Windows.Forms.Button();
            this.txtfirmaid = new System.Windows.Forms.TextBox();
            this.cbyardimciekipman = new System.Windows.Forms.CheckBox();
            this.cbgozlekontrol = new System.Windows.Forms.CheckBox();
            this.cbambalaj = new System.Windows.Forms.CheckBox();
            this.cbteknikdeger = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdurun)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(459, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 24);
            this.button3.TabIndex = 102;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 101;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grdurun
            // 
            this.grdurun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdurun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdurun.Location = new System.Drawing.Point(23, 423);
            this.grdurun.Name = "grdurun";
            this.grdurun.ReadOnly = true;
            this.grdurun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdurun.Size = new System.Drawing.Size(552, 210);
            this.grdurun.TabIndex = 99;
            this.grdurun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdurun_CellClick);
            // 
            // cmbDeneyMethodu
            // 
            this.cmbDeneyMethodu.ForeColor = System.Drawing.Color.DimGray;
            this.cmbDeneyMethodu.FormattingEnabled = true;
            this.cmbDeneyMethodu.Items.AddRange(new object[] {
            "IEC 60068-2-75(Çekiç Deneyleri)",
            "TS EN 60112(Yüzeysel Kaçaklar)",
            "TS EN 60204-1+A1",
            "TS EN 60529(IP Testleri)",
            "TS EN 60598-1",
            "TS EN 60598-2-1 (Sabit Armatür)",
            "TS EN 60598-2-2(Gömme Armatür)",
            "TS EN 60598-2-3+A1+AC(Yol ve Cadde Armatürleri)",
            "TS EN 60598-2-4(Taşınabilir Armatür)",
            "TS EN 60598-2-5(Projektörler)",
            "TS EN 60695",
            "TS EN 60695-10-2(Bilye Basıncı)",
            "TS EN 60695-11-5(İğne Alevi)",
            "TS EN 60695-2-11(Kızaran Tel Testi)",
            "TS EN 61347-1(Lamba Kontrol)",
            "TS EN 62031(Led Modüller)"});
            this.cmbDeneyMethodu.Location = new System.Drawing.Point(287, 397);
            this.cmbDeneyMethodu.Name = "cmbDeneyMethodu";
            this.cmbDeneyMethodu.Size = new System.Drawing.Size(288, 21);
            this.cmbDeneyMethodu.Sorted = true;
            this.cmbDeneyMethodu.TabIndex = 98;
            this.cmbDeneyMethodu.Text = "Deney Methodunu";
            // 
            // txtnumuneAdi
            // 
            this.txtnumuneAdi.ForeColor = System.Drawing.Color.DimGray;
            this.txtnumuneAdi.Location = new System.Drawing.Point(155, 397);
            this.txtnumuneAdi.Name = "txtnumuneAdi";
            this.txtnumuneAdi.Size = new System.Drawing.Size(126, 20);
            this.txtnumuneAdi.TabIndex = 97;
            this.txtnumuneAdi.Text = "Numune Adını Giriniz";
            // 
            // txtnumuneNo
            // 
            this.txtnumuneNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtnumuneNo.Location = new System.Drawing.Point(23, 397);
            this.txtnumuneNo.Name = "txtnumuneNo";
            this.txtnumuneNo.Size = new System.Drawing.Size(126, 20);
            this.txtnumuneNo.TabIndex = 96;
            this.txtnumuneNo.Text = "Numune No Giriniz";
            // 
            // btnyazdir
            // 
            this.btnyazdir.BackColor = System.Drawing.Color.Firebrick;
            this.btnyazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyazdir.ForeColor = System.Drawing.Color.White;
            this.btnyazdir.Location = new System.Drawing.Point(346, 4);
            this.btnyazdir.Name = "btnyazdir";
            this.btnyazdir.Size = new System.Drawing.Size(122, 37);
            this.btnyazdir.TabIndex = 115;
            this.btnyazdir.Text = "Yazdır";
            this.btnyazdir.UseVisualStyleBackColor = false;
            this.btnyazdir.Visible = false;
            // 
            // txturunid
            // 
            this.txturunid.Location = new System.Drawing.Point(591, 364);
            this.txturunid.Name = "txturunid";
            this.txturunid.Size = new System.Drawing.Size(12, 20);
            this.txturunid.TabIndex = 116;
            this.txturunid.Visible = false;
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.BackColor = System.Drawing.Color.Blue;
            this.btnMusteriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(206, 4);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(122, 37);
            this.btnMusteriGuncelle.TabIndex = 114;
            this.btnMusteriGuncelle.Text = "Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // txtnotlar
            // 
            this.txtnotlar.Location = new System.Drawing.Point(378, 270);
            this.txtnotlar.Multiline = true;
            this.txtnotlar.Name = "txtnotlar";
            this.txtnotlar.Size = new System.Drawing.Size(200, 61);
            this.txtnotlar.TabIndex = 113;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(323, 273);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 14);
            this.label19.TabIndex = 112;
            this.label19.Text = "Notlar :";
            // 
            // txtfirmaadres
            // 
            this.txtfirmaadres.Location = new System.Drawing.Point(378, 203);
            this.txtfirmaadres.Multiline = true;
            this.txtfirmaadres.Name = "txtfirmaadres";
            this.txtfirmaadres.Size = new System.Drawing.Size(200, 61);
            this.txtfirmaadres.TabIndex = 111;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(296, 206);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 14);
            this.label18.TabIndex = 110;
            this.label18.Text = "Firma Adres :";
            // 
            // dtbitistarihi
            // 
            this.dtbitistarihi.CustomFormat = "\'Test Sırada Bekliyor\'";
            this.dtbitistarihi.Location = new System.Drawing.Point(378, 167);
            this.dtbitistarihi.Name = "dtbitistarihi";
            this.dtbitistarihi.Size = new System.Drawing.Size(200, 20);
            this.dtbitistarihi.TabIndex = 109;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(309, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 14);
            this.label8.TabIndex = 108;
            this.label8.Text = "Bitiş Tarihi";
            // 
            // dttesttarihi
            // 
            this.dttesttarihi.CustomFormat = "\'Test Sırada Bekliyor\'";
            this.dttesttarihi.Location = new System.Drawing.Point(378, 134);
            this.dttesttarihi.Name = "dttesttarihi";
            this.dttesttarihi.Size = new System.Drawing.Size(200, 20);
            this.dttesttarihi.TabIndex = 107;
            this.dttesttarihi.Value = new System.DateTime(2019, 1, 4, 12, 22, 35, 0);
            // 
            // dtgiristarihi
            // 
            this.dtgiristarihi.Location = new System.Drawing.Point(378, 102);
            this.dtgiristarihi.Name = "dtgiristarihi";
            this.dtgiristarihi.Size = new System.Drawing.Size(200, 20);
            this.dtgiristarihi.TabIndex = 106;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(306, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 14);
            this.label17.TabIndex = 105;
            this.label17.Text = "Giriş Tarihi :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(40, 495);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 18);
            this.label16.TabIndex = 94;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(41, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 18);
            this.label14.TabIndex = 91;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.25F);
            this.label13.Location = new System.Drawing.Point(23, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 16);
            this.label13.TabIndex = 89;
            this.label13.Text = "Numune Kabul Şartları";
            // 
            // txtcikistateslimalan
            // 
            this.txtcikistateslimalan.Location = new System.Drawing.Point(129, 310);
            this.txtcikistateslimalan.Name = "txtcikistateslimalan";
            this.txtcikistateslimalan.Size = new System.Drawing.Size(155, 20);
            this.txtcikistateslimalan.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 14);
            this.label11.TabIndex = 87;
            this.label11.Text = "Çıkışta Teslim Alan:";
            // 
            // txtgiristeteslimalan
            // 
            this.txtgiristeteslimalan.Location = new System.Drawing.Point(129, 258);
            this.txtgiristeteslimalan.Name = "txtgiristeteslimalan";
            this.txtgiristeteslimalan.Size = new System.Drawing.Size(155, 20);
            this.txtgiristeteslimalan.TabIndex = 86;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 14);
            this.label12.TabIndex = 85;
            this.label12.Text = "Girişte Teslim Alan:";
            // 
            // txtcikistateslimeden
            // 
            this.txtcikistateslimeden.Location = new System.Drawing.Point(129, 284);
            this.txtcikistateslimeden.Name = "txtcikistateslimeden";
            this.txtcikistateslimeden.Size = new System.Drawing.Size(155, 20);
            this.txtcikistateslimeden.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 14);
            this.label10.TabIndex = 83;
            this.label10.Text = "Çıkışta Teslim Eden:";
            // 
            // txtgiristeteslimeden
            // 
            this.txtgiristeteslimeden.Location = new System.Drawing.Point(129, 232);
            this.txtgiristeteslimeden.Name = "txtgiristeteslimeden";
            this.txtgiristeteslimeden.Size = new System.Drawing.Size(155, 20);
            this.txtgiristeteslimeden.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 14);
            this.label9.TabIndex = 81;
            this.label9.Text = "Girişte Teslim Eden:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 14);
            this.label7.TabIndex = 80;
            this.label7.Text = "Test Tarihi:";
            // 
            // txtfirmamail
            // 
            this.txtfirmamail.Location = new System.Drawing.Point(95, 206);
            this.txtfirmamail.Name = "txtfirmamail";
            this.txtfirmamail.Size = new System.Drawing.Size(189, 20);
            this.txtfirmamail.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 78;
            this.label6.Text = "Firma Mail :";
            // 
            // txtyetkilikisi
            // 
            this.txtyetkilikisi.Location = new System.Drawing.Point(95, 180);
            this.txtyetkilikisi.Name = "txtyetkilikisi";
            this.txtyetkilikisi.Size = new System.Drawing.Size(189, 20);
            this.txtyetkilikisi.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 14);
            this.label5.TabIndex = 76;
            this.label5.Text = "Yetkili Kişi :";
            // 
            // txtfirmatel
            // 
            this.txtfirmatel.Location = new System.Drawing.Point(95, 154);
            this.txtfirmatel.Name = "txtfirmatel";
            this.txtfirmatel.Size = new System.Drawing.Size(189, 20);
            this.txtfirmatel.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 74;
            this.label4.Text = "Firma Tel :";
            // 
            // txtfirmaad
            // 
            this.txtfirmaad.Location = new System.Drawing.Point(95, 128);
            this.txtfirmaad.Name = "txtfirmaad";
            this.txtfirmaad.Size = new System.Drawing.Size(189, 20);
            this.txtfirmaad.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 72;
            this.label3.Text = "İstek No:";
            // 
            // txtistekno
            // 
            this.txtistekno.Location = new System.Drawing.Point(95, 102);
            this.txtistekno.Name = "txtistekno";
            this.txtistekno.Size = new System.Drawing.Size(189, 20);
            this.txtistekno.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 70;
            this.label2.Text = "Firma Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 69;
            this.label1.Text = "Numune Bilgi Formu";
            // 
            // btnnumunekaydet
            // 
            this.btnnumunekaydet.Location = new System.Drawing.Point(390, 368);
            this.btnnumunekaydet.Name = "btnnumunekaydet";
            this.btnnumunekaydet.Size = new System.Drawing.Size(63, 23);
            this.btnnumunekaydet.TabIndex = 117;
            this.btnnumunekaydet.Text = "Kaydet";
            this.btnnumunekaydet.UseVisualStyleBackColor = true;
            this.btnnumunekaydet.Click += new System.EventHandler(this.btnnumunekaydet_Click);
            // 
            // txtfirmaid
            // 
            this.txtfirmaid.Location = new System.Drawing.Point(528, 9);
            this.txtfirmaid.Name = "txtfirmaid";
            this.txtfirmaid.Size = new System.Drawing.Size(100, 20);
            this.txtfirmaid.TabIndex = 118;
            this.txtfirmaid.Visible = false;
            // 
            // cbyardimciekipman
            // 
            this.cbyardimciekipman.AutoSize = true;
            this.cbyardimciekipman.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbyardimciekipman.Location = new System.Drawing.Point(166, 354);
            this.cbyardimciekipman.Name = "cbyardimciekipman";
            this.cbyardimciekipman.Size = new System.Drawing.Size(150, 16);
            this.cbyardimciekipman.TabIndex = 122;
            this.cbyardimciekipman.Text = "Yardımcı Ekipmanların Kontrolü";
            this.cbyardimciekipman.UseVisualStyleBackColor = true;
            // 
            // cbgozlekontrol
            // 
            this.cbgozlekontrol.AutoSize = true;
            this.cbgozlekontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbgozlekontrol.Location = new System.Drawing.Point(23, 376);
            this.cbgozlekontrol.Name = "cbgozlekontrol";
            this.cbgozlekontrol.Size = new System.Drawing.Size(139, 16);
            this.cbgozlekontrol.TabIndex = 119;
            this.cbgozlekontrol.Text = "Gözle Kontrol Uygun Olacak";
            this.cbgozlekontrol.UseVisualStyleBackColor = true;
            // 
            // cbambalaj
            // 
            this.cbambalaj.AutoSize = true;
            this.cbambalaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbambalaj.Location = new System.Drawing.Point(166, 373);
            this.cbambalaj.Name = "cbambalaj";
            this.cbambalaj.Size = new System.Drawing.Size(135, 16);
            this.cbambalaj.TabIndex = 121;
            this.cbambalaj.Text = "Ambalaj Kontrolü Yapılacak";
            this.cbambalaj.UseVisualStyleBackColor = true;
            // 
            // cbteknikdeger
            // 
            this.cbteknikdeger.AutoSize = true;
            this.cbteknikdeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbteknikdeger.Location = new System.Drawing.Point(23, 354);
            this.cbteknikdeger.Name = "cbteknikdeger";
            this.cbteknikdeger.Size = new System.Drawing.Size(137, 16);
            this.cbteknikdeger.TabIndex = 120;
            this.cbteknikdeger.Text = "Teknik Değer Etiketi Olacak";
            this.cbteknikdeger.UseVisualStyleBackColor = true;
            // 
            // detayNumune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 645);
            this.Controls.Add(this.cbyardimciekipman);
            this.Controls.Add(this.cbgozlekontrol);
            this.Controls.Add(this.cbambalaj);
            this.Controls.Add(this.cbteknikdeger);
            this.Controls.Add(this.txtfirmaid);
            this.Controls.Add(this.btnnumunekaydet);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grdurun);
            this.Controls.Add(this.cmbDeneyMethodu);
            this.Controls.Add(this.txtnumuneAdi);
            this.Controls.Add(this.txtnumuneNo);
            this.Controls.Add(this.btnyazdir);
            this.Controls.Add(this.txturunid);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.txtnotlar);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtfirmaadres);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtbitistarihi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dttesttarihi);
            this.Controls.Add(this.dtgiristarihi);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtcikistateslimalan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtgiristeteslimalan);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtcikistateslimeden);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtgiristeteslimeden);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtfirmamail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtyetkilikisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfirmatel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfirmaad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtistekno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "detayNumune";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "detayNumune";
            ((System.ComponentModel.ISupportInitialize)(this.grdurun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.Button button3;
		public System.Windows.Forms.Button button2;
		public System.Windows.Forms.DataGridView grdurun;
		public System.Windows.Forms.ComboBox cmbDeneyMethodu;
		public System.Windows.Forms.TextBox txtnumuneAdi;
		public System.Windows.Forms.TextBox txtnumuneNo;
		public System.Windows.Forms.Button btnyazdir;
		public System.Windows.Forms.TextBox txturunid;
		public System.Windows.Forms.Button btnMusteriGuncelle;
		public System.Windows.Forms.TextBox txtnotlar;
		public System.Windows.Forms.Label label19;
		public System.Windows.Forms.TextBox txtfirmaadres;
		public System.Windows.Forms.Label label18;
		public System.Windows.Forms.DateTimePicker dtbitistarihi;
		public System.Windows.Forms.Label label8;
		public System.Windows.Forms.DateTimePicker dttesttarihi;
		public System.Windows.Forms.DateTimePicker dtgiristarihi;
		public System.Windows.Forms.Label label17;
		public System.Windows.Forms.Label label16;
		public System.Windows.Forms.Label label14;
		public System.Windows.Forms.Label label13;
		public System.Windows.Forms.TextBox txtcikistateslimalan;
		public System.Windows.Forms.Label label11;
		public System.Windows.Forms.TextBox txtgiristeteslimalan;
		public System.Windows.Forms.Label label12;
		public System.Windows.Forms.TextBox txtcikistateslimeden;
		public System.Windows.Forms.Label label10;
		public System.Windows.Forms.TextBox txtgiristeteslimeden;
		public System.Windows.Forms.Label label9;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox txtfirmamail;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox txtyetkilikisi;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox txtfirmatel;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox txtfirmaad;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtistekno;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnnumunekaydet;
		public System.Windows.Forms.TextBox txtfirmaid;
		public System.Windows.Forms.CheckBox cbyardimciekipman;
		public System.Windows.Forms.CheckBox cbgozlekontrol;
		public System.Windows.Forms.CheckBox cbambalaj;
		public System.Windows.Forms.CheckBox cbteknikdeger;
	}
}