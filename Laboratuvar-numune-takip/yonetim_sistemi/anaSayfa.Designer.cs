namespace yonetim_sistemi
{
	partial class anaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaSayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listDuyurular = new System.Windows.Forms.ListView();
            this.Duyurular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDoviz = new System.Windows.Forms.Button();
            this.btnyoneticiGit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNotSil = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblhosgeldiniz = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnsatisGit = new System.Windows.Forms.Button();
            this.btnlabaratuvarGit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnotorumuKapat = new System.Windows.Forms.Button();
            this.notlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOTLARIM";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "DUYURULAR";
            // 
            // listDuyurular
            // 
            this.listDuyurular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Duyurular});
            this.listDuyurular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDuyurular.FullRowSelect = true;
            this.listDuyurular.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listDuyurular.Location = new System.Drawing.Point(12, 192);
            this.listDuyurular.Name = "listDuyurular";
            this.listDuyurular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listDuyurular.Size = new System.Drawing.Size(1174, 178);
            this.listDuyurular.TabIndex = 12;
            this.listDuyurular.UseCompatibleStateImageBehavior = false;
            this.listDuyurular.View = System.Windows.Forms.View.Details;
            this.listDuyurular.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listDuyurular_MouseDoubleClick);
            // 
            // Duyurular
            // 
            this.Duyurular.Text = "Duyurular";
            this.Duyurular.Width = 930;
            // 
            // btnDoviz
            // 
            this.btnDoviz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnDoviz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDoviz.FlatAppearance.BorderSize = 0;
            this.btnDoviz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoviz.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoviz.ForeColor = System.Drawing.Color.Transparent;
            this.btnDoviz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoviz.Location = new System.Drawing.Point(930, 112);
            this.btnDoviz.Name = "btnDoviz";
            this.btnDoviz.Size = new System.Drawing.Size(230, 40);
            this.btnDoviz.TabIndex = 21;
            this.btnDoviz.Text = "Döviz Kurları";
            this.btnDoviz.UseVisualStyleBackColor = false;
            this.btnDoviz.Click += new System.EventHandler(this.btnDoviz_Click);
            // 
            // btnyoneticiGit
            // 
            this.btnyoneticiGit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnyoneticiGit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnyoneticiGit.FlatAppearance.BorderSize = 0;
            this.btnyoneticiGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyoneticiGit.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyoneticiGit.ForeColor = System.Drawing.Color.Transparent;
            this.btnyoneticiGit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyoneticiGit.Location = new System.Drawing.Point(636, 112);
            this.btnyoneticiGit.Name = "btnyoneticiGit";
            this.btnyoneticiGit.Size = new System.Drawing.Size(230, 40);
            this.btnyoneticiGit.TabIndex = 5;
            this.btnyoneticiGit.Text = "Yeni Personel Ekle";
            this.btnyoneticiGit.UseVisualStyleBackColor = false;
            this.btnyoneticiGit.Click += new System.EventHandler(this.btnyoneticiGit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 109);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::yonetim_sistemi.Properties.Resources.ana_sayfa;
            this.pictureBox2.Location = new System.Drawing.Point(135, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(736, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 43);
            this.label4.TabIndex = 1;
            this.label4.Text = "Laboratuvar Yönetim Sistemi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 57);
            this.label3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(139, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 25);
            this.button2.TabIndex = 24;
            this.button2.Text = "Yeni Not Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(139, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 25);
            this.button1.TabIndex = 25;
            this.button1.Text = "Yeni Duyuru Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNotSil
            // 
            this.btnNotSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnNotSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNotSil.FlatAppearance.BorderSize = 0;
            this.btnNotSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotSil.ForeColor = System.Drawing.Color.Transparent;
            this.btnNotSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotSil.Location = new System.Drawing.Point(354, 378);
            this.btnNotSil.Name = "btnNotSil";
            this.btnNotSil.Size = new System.Drawing.Size(209, 25);
            this.btnNotSil.TabIndex = 27;
            this.btnNotSil.Text = "Notu Sil";
            this.btnNotSil.UseVisualStyleBackColor = false;
            this.btnNotSil.Click += new System.EventHandler(this.btnNotSil_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(12, 409);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(1174, 176);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Duyurular";
            this.columnHeader1.Width = 930;
            // 
            // lblhosgeldiniz
            // 
            this.lblhosgeldiniz.AutoSize = true;
            this.lblhosgeldiniz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lblhosgeldiniz.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhosgeldiniz.Location = new System.Drawing.Point(958, 155);
            this.lblhosgeldiniz.Name = "lblhosgeldiniz";
            this.lblhosgeldiniz.Size = new System.Drawing.Size(107, 16);
            this.lblhosgeldiniz.TabIndex = 20;
            this.lblhosgeldiniz.Text = "Hoşgeldiniz Sn.";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(1071, 155);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(89, 16);
            this.lblKullaniciAdi.TabIndex = 22;
            this.lblKullaniciAdi.Text = "kullanici_adi";
            // 
            // btnsatisGit
            // 
            this.btnsatisGit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnsatisGit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsatisGit.FlatAppearance.BorderSize = 0;
            this.btnsatisGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsatisGit.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsatisGit.ForeColor = System.Drawing.Color.Transparent;
            this.btnsatisGit.Image = global::yonetim_sistemi.Properties.Resources.satis1;
            this.btnsatisGit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsatisGit.Location = new System.Drawing.Point(12, 112);
            this.btnsatisGit.Name = "btnsatisGit";
            this.btnsatisGit.Size = new System.Drawing.Size(230, 40);
            this.btnsatisGit.TabIndex = 1;
            this.btnsatisGit.Text = "Satış Yönetim Sistemi";
            this.btnsatisGit.UseVisualStyleBackColor = false;
            this.btnsatisGit.Click += new System.EventHandler(this.btnsatisGit_Click);
            // 
            // btnlabaratuvarGit
            // 
            this.btnlabaratuvarGit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnlabaratuvarGit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlabaratuvarGit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnlabaratuvarGit.FlatAppearance.BorderSize = 0;
            this.btnlabaratuvarGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlabaratuvarGit.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlabaratuvarGit.ForeColor = System.Drawing.Color.Transparent;
            this.btnlabaratuvarGit.Image = global::yonetim_sistemi.Properties.Resources.laboratuvar;
            this.btnlabaratuvarGit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlabaratuvarGit.Location = new System.Drawing.Point(333, 112);
            this.btnlabaratuvarGit.Name = "btnlabaratuvarGit";
            this.btnlabaratuvarGit.Size = new System.Drawing.Size(230, 40);
            this.btnlabaratuvarGit.TabIndex = 2;
            this.btnlabaratuvarGit.Text = "Laboratuvar Yönetim Sistemi";
            this.btnlabaratuvarGit.UseVisualStyleBackColor = false;
            this.btnlabaratuvarGit.Click += new System.EventHandler(this.btnlabaratuvarGit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::yonetim_sistemi.Properties.Resources.kucult;
            this.pictureBox1.Location = new System.Drawing.Point(1191, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnotorumuKapat
            // 
            this.btnotorumuKapat.FlatAppearance.BorderSize = 0;
            this.btnotorumuKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnotorumuKapat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnotorumuKapat.ForeColor = System.Drawing.Color.White;
            this.btnotorumuKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnotorumuKapat.Image")));
            this.btnotorumuKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnotorumuKapat.Location = new System.Drawing.Point(1228, 115);
            this.btnotorumuKapat.Name = "btnotorumuKapat";
            this.btnotorumuKapat.Size = new System.Drawing.Size(36, 37);
            this.btnotorumuKapat.TabIndex = 17;
            this.btnotorumuKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnotorumuKapat.UseVisualStyleBackColor = true;
            this.btnotorumuKapat.Click += new System.EventHandler(this.btnoturumuKapat_Click);
            // 
            // anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 602);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblhosgeldiniz);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDoviz);
            this.Controls.Add(this.btnNotSil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnotorumuKapat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnyoneticiGit);
            this.Controls.Add(this.btnsatisGit);
            this.Controls.Add(this.btnlabaratuvarGit);
            this.Controls.Add(this.listDuyurular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "anaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anaSayfa";
            this.Load += new System.EventHandler(this.anaSayfa_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnsatisGit;
		private System.Windows.Forms.Button btnlabaratuvarGit;
		private System.Windows.Forms.Button btnyoneticiGit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader Duyurular;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnDoviz;
		public System.Windows.Forms.Button btnotorumuKapat;
		private System.Windows.Forms.Button button2;
		public System.Windows.Forms.ListView listDuyurular;
		private System.Windows.Forms.Button button1;

		private System.Windows.Forms.BindingSource notlarBindingSource;
		private System.Windows.Forms.Button btnNotSil;
		public System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblhosgeldiniz;
        public System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}