namespace yonetim_sistemi.LaboratuvarModulu
{
	partial class musteriTakip
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriTakip));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnotorumuKapat = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.grdlaboratuvarmusteri = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtara = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.lbldurum = new System.Windows.Forms.Label();
			this.txtfirmaid = new System.Windows.Forms.TextBox();
			this.txtdurum = new System.Windows.Forms.TextBox();
			this.btnyenile = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdlaboratuvarmusteri)).BeginInit();
			this.SuspendLayout();
			// 
			
			// btnotorumuKapat
			// 
			this.btnotorumuKapat.FlatAppearance.BorderSize = 0;
			this.btnotorumuKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnotorumuKapat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnotorumuKapat.ForeColor = System.Drawing.Color.White;
			this.btnotorumuKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnotorumuKapat.Image")));
			this.btnotorumuKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnotorumuKapat.Location = new System.Drawing.Point(1152, 12);
			this.btnotorumuKapat.Name = "btnotorumuKapat";
			this.btnotorumuKapat.Size = new System.Drawing.Size(36, 37);
			this.btnotorumuKapat.TabIndex = 28;
			this.btnotorumuKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnotorumuKapat.UseVisualStyleBackColor = true;
			this.btnotorumuKapat.Click += new System.EventHandler(this.btnotorumuKapat_Click);
			// 
			
			// grdlaboratuvarmusteri
			// 
			this.grdlaboratuvarmusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdlaboratuvarmusteri.BackgroundColor = System.Drawing.Color.White;
			this.grdlaboratuvarmusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdlaboratuvarmusteri.Location = new System.Drawing.Point(12, 136);
			this.grdlaboratuvarmusteri.Name = "grdlaboratuvarmusteri";
			this.grdlaboratuvarmusteri.ReadOnly = true;
			this.grdlaboratuvarmusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdlaboratuvarmusteri.Size = new System.Drawing.Size(1176, 439);
			this.grdlaboratuvarmusteri.TabIndex = 48;
			this.grdlaboratuvarmusteri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdlaboratuvarmusteri_CellClick);
			this.grdlaboratuvarmusteri.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdlaboratuvarmusteri_CellContentDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(483, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 23);
			this.label1.TabIndex = 49;
			this.label1.Text = "Müşteri Takip Ekranı";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(123, 92);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(295, 16);
			this.label8.TabIndex = 50;
			this.label8.Text = "Firma Adı veya Sözleşme Numarası İle Ara:";
			// 
			// txtara
			// 
			this.txtara.Location = new System.Drawing.Point(424, 92);
			this.txtara.Name = "txtara";
			this.txtara.Size = new System.Drawing.Size(273, 20);
			this.txtara.TabIndex = 51;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Blue;
			this.button5.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(703, 81);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(84, 38);
			this.button5.TabIndex = 52;
			this.button5.Text = "Ara";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// lbldurum
			// 
			this.lbldurum.AutoSize = true;
			this.lbldurum.Font = new System.Drawing.Font("Ubuntu Light", 14.75F, System.Drawing.FontStyle.Bold);
			this.lbldurum.Location = new System.Drawing.Point(787, 18);
			this.lbldurum.Name = "lbldurum";
			this.lbldurum.Size = new System.Drawing.Size(0, 26);
			this.lbldurum.TabIndex = 53;
			// 
			// txtfirmaid
			// 
			this.txtfirmaid.Location = new System.Drawing.Point(126, 14);
			this.txtfirmaid.Name = "txtfirmaid";
			this.txtfirmaid.Size = new System.Drawing.Size(33, 20);
			this.txtfirmaid.TabIndex = 54;
			this.txtfirmaid.Visible = false;
			// 
			// txtdurum
			// 
			this.txtdurum.Location = new System.Drawing.Point(126, 40);
			this.txtdurum.Name = "txtdurum";
			this.txtdurum.Size = new System.Drawing.Size(33, 20);
			this.txtdurum.TabIndex = 55;
			this.txtdurum.Visible = false;
			// 
			// btnyenile
			// 
			this.btnyenile.BackColor = System.Drawing.Color.Blue;
			this.btnyenile.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnyenile.ForeColor = System.Drawing.Color.White;
			this.btnyenile.Location = new System.Drawing.Point(802, 80);
			this.btnyenile.Name = "btnyenile";
			this.btnyenile.Size = new System.Drawing.Size(128, 38);
			this.btnyenile.TabIndex = 56;
			this.btnyenile.Text = "Tabloyu Yenile";
			this.btnyenile.UseVisualStyleBackColor = false;
			this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
			// 
			// musteriTakip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 587);
			this.Controls.Add(this.btnyenile);
			this.Controls.Add(this.txtdurum);
			this.Controls.Add(this.txtfirmaid);
			this.Controls.Add(this.lbldurum);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.txtara);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.grdlaboratuvarmusteri);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnotorumuKapat);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "musteriTakip";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "musteriTakip";
			this.Load += new System.EventHandler(this.musteriTakip_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdlaboratuvarmusteri)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Button btnotorumuKapat;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtara;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label lbldurum;
		private System.Windows.Forms.TextBox txtfirmaid;
		private System.Windows.Forms.TextBox txtdurum;
		public System.Windows.Forms.DataGridView grdlaboratuvarmusteri;
		private System.Windows.Forms.Button btnyenile;
	}
}