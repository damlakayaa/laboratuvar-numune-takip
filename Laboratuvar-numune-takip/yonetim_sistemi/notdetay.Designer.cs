namespace yonetim_sistemi
{
	partial class notdetay
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
			this.txtNotDetay = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtNotDetay
			// 
			this.txtNotDetay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtNotDetay.Location = new System.Drawing.Point(0, 0);
			this.txtNotDetay.Multiline = true;
			this.txtNotDetay.Name = "txtNotDetay";
			this.txtNotDetay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNotDetay.Size = new System.Drawing.Size(784, 310);
			this.txtNotDetay.TabIndex = 4;
			// 
			// notdetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 310);
			this.Controls.Add(this.txtNotDetay);
			this.Name = "notdetay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "notdetay";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.TextBox txtNotDetay;
	}
}