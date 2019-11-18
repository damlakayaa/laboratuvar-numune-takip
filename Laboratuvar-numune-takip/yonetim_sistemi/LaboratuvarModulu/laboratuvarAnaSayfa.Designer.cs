namespace yonetim_sistemi.LaboratuvarModulu
{
	partial class laboratuvarAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(laboratuvarAnaSayfa));
            this.lblkullaniciadigetir = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnNumuneTakip = new System.Windows.Forms.Button();
            this.btnNumune = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkullaniciadigetir
            // 
            this.lblkullaniciadigetir.AutoSize = true;
            this.lblkullaniciadigetir.Location = new System.Drawing.Point(127, 429);
            this.lblkullaniciadigetir.Name = "lblkullaniciadigetir";
            this.lblkullaniciadigetir.Size = new System.Drawing.Size(0, 20);
            this.lblkullaniciadigetir.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnMusteri);
            this.panel1.Controls.Add(this.btnNumuneTakip);
            this.panel1.Controls.Add(this.btnNumune);
            this.panel1.Controls.Add(this.lblkullaniciadigetir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 528);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(230, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnotorumuKapat_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMusteri.FlatAppearance.BorderSize = 0;
            this.btnMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteri.ForeColor = System.Drawing.Color.Transparent;
            this.btnMusteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteri.Location = new System.Drawing.Point(3, 3);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(299, 40);
            this.btnMusteri.TabIndex = 23;
            this.btnMusteri.Text = "Müşteri Takip";
            this.btnMusteri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnNumuneTakip
            // 
            this.btnNumuneTakip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNumuneTakip.FlatAppearance.BorderSize = 0;
            this.btnNumuneTakip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumuneTakip.ForeColor = System.Drawing.Color.Transparent;
            this.btnNumuneTakip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNumuneTakip.Location = new System.Drawing.Point(3, 104);
            this.btnNumuneTakip.Name = "btnNumuneTakip";
            this.btnNumuneTakip.Size = new System.Drawing.Size(299, 40);
            this.btnNumuneTakip.TabIndex = 22;
            this.btnNumuneTakip.Text = "Numune Takip";
            this.btnNumuneTakip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNumuneTakip.UseVisualStyleBackColor = true;
            this.btnNumuneTakip.Click += new System.EventHandler(this.btnNumuneTakip_Click);
            // 
            // btnNumune
            // 
            this.btnNumune.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNumune.FlatAppearance.BorderSize = 0;
            this.btnNumune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumune.ForeColor = System.Drawing.Color.Transparent;
            this.btnNumune.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNumune.Location = new System.Drawing.Point(0, 58);
            this.btnNumune.Name = "btnNumune";
            this.btnNumune.Size = new System.Drawing.Size(299, 40);
            this.btnNumune.TabIndex = 21;
            this.btnNumune.Text = "Yeni Numune Kayıt";
            this.btnNumune.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNumune.UseVisualStyleBackColor = true;
            this.btnNumune.Click += new System.EventHandler(this.btnNumune_Click);
            // 
            // laboratuvarAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 528);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "laboratuvarAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "laboratuvarAnaSayfa";
            this.Load += new System.EventHandler(this.laboratuvarAnaSayfa_Load);
            this.Click += new System.EventHandler(this.btnotorumuKapat_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblkullaniciadigetir;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnNumuneTakip;
		private System.Windows.Forms.Button btnNumune;
		private System.Windows.Forms.Button btnMusteri;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}