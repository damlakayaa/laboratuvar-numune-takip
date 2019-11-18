namespace yonetim_sistemi
{
	partial class duyurulardetayi
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
			this.txtduyurudetayi = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtduyurudetayi
			// 
			this.txtduyurudetayi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtduyurudetayi.Location = new System.Drawing.Point(0, 0);
			this.txtduyurudetayi.Multiline = true;
			this.txtduyurudetayi.Name = "txtduyurudetayi";
			this.txtduyurudetayi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtduyurudetayi.Size = new System.Drawing.Size(663, 247);
			this.txtduyurudetayi.TabIndex = 0;
			// 
			// duyurulardetayi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 247);
			this.Controls.Add(this.txtduyurudetayi);
			this.Name = "duyurulardetayi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "duyurulardetayi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox txtduyurudetayi;
	}
}