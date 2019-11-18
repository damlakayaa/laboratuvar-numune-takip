namespace yonetim_sistemi.LaboratuvarModulu
{
	partial class test_bitis_tarihi
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
			this.dtbitistarihi = new System.Windows.Forms.DateTimePicker();
			this.txtbitisid = new System.Windows.Forms.TextBox();
			this.btntestbitir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dtbitistarihi
			// 
			this.dtbitistarihi.Location = new System.Drawing.Point(179, 35);
			this.dtbitistarihi.Name = "dtbitistarihi";
			this.dtbitistarihi.Size = new System.Drawing.Size(321, 20);
			this.dtbitistarihi.TabIndex = 60;
			// 
			// txtbitisid
			// 
			this.txtbitisid.Location = new System.Drawing.Point(21, 43);
			this.txtbitisid.Name = "txtbitisid";
			this.txtbitisid.Size = new System.Drawing.Size(100, 20);
			this.txtbitisid.TabIndex = 59;
			this.txtbitisid.Visible = false;
			// 
			// btntestbitir
			// 
			this.btntestbitir.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.btntestbitir.Location = new System.Drawing.Point(275, 59);
			this.btntestbitir.Name = "btntestbitir";
			this.btntestbitir.Size = new System.Drawing.Size(127, 38);
			this.btntestbitir.TabIndex = 58;
			this.btntestbitir.Text = "Kaydet";
			this.btntestbitir.UseVisualStyleBackColor = true;
			this.btntestbitir.Click += new System.EventHandler(this.btntestbitir_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(214, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 17);
			this.label1.TabIndex = 57;
			this.label1.Text = "Lütfen Test Bitiş Tarihini  Giriniz :";
			// 
			// test_bitis_tarihi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 99);
			this.Controls.Add(this.dtbitistarihi);
			this.Controls.Add(this.txtbitisid);
			this.Controls.Add(this.btntestbitir);
			this.Controls.Add(this.label1);
			this.Name = "test_bitis_tarihi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "test_bitis_tarihi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtbitistarihi;
		public System.Windows.Forms.TextBox txtbitisid;
		private System.Windows.Forms.Button btntestbitir;
		private System.Windows.Forms.Label label1;
	}
}