namespace yonetim_sistemi.LaboratuvarModulu
{
	partial class test_baslangic_tarihi
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
			this.txtidbaslangicid = new System.Windows.Forms.TextBox();
			this.btnSarKaydet = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dtbaslangictarihi = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// txtidbaslangicid
			// 
			this.txtidbaslangicid.Location = new System.Drawing.Point(12, 38);
			this.txtidbaslangicid.Name = "txtidbaslangicid";
			this.txtidbaslangicid.Size = new System.Drawing.Size(100, 20);
			this.txtidbaslangicid.TabIndex = 55;
			this.txtidbaslangicid.Visible = false;
			// 
			// btnSarKaydet
			// 
			this.btnSarKaydet.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.btnSarKaydet.Location = new System.Drawing.Point(266, 56);
			this.btnSarKaydet.Name = "btnSarKaydet";
			this.btnSarKaydet.Size = new System.Drawing.Size(127, 38);
			this.btnSarKaydet.TabIndex = 54;
			this.btnSarKaydet.Text = "Kaydet";
			this.btnSarKaydet.UseVisualStyleBackColor = true;
			this.btnSarKaydet.Click += new System.EventHandler(this.btnTestBaslat_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(212, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(251, 17);
			this.label1.TabIndex = 52;
			this.label1.Text = "Lütfen Test Başlangıç Tarihini  Giriniz :";
			// 
			// dtbaslangictarihi
			// 
			this.dtbaslangictarihi.Location = new System.Drawing.Point(170, 30);
			this.dtbaslangictarihi.Name = "dtbaslangictarihi";
			this.dtbaslangictarihi.Size = new System.Drawing.Size(321, 20);
			this.dtbaslangictarihi.TabIndex = 56;
			// 
			// test_baslangic_tarihi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 99);
			this.Controls.Add(this.dtbaslangictarihi);
			this.Controls.Add(this.txtidbaslangicid);
			this.Controls.Add(this.btnSarKaydet);
			this.Controls.Add(this.label1);
			this.Name = "test_baslangic_tarihi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "test_baslangic_tarihi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox txtidbaslangicid;
		private System.Windows.Forms.Button btnSarKaydet;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtbaslangictarihi;
	}
}