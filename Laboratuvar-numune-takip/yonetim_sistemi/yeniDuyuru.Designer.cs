namespace yonetim_sistemi
{
	partial class yeniDuyuru
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
            this.txtDuyuru = new System.Windows.Forms.TextBox();
            this.btnDuyuruGonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDuyuru
            // 
            this.txtDuyuru.Location = new System.Drawing.Point(16, 26);
            this.txtDuyuru.Multiline = true;
            this.txtDuyuru.Name = "txtDuyuru";
            this.txtDuyuru.Size = new System.Drawing.Size(742, 170);
            this.txtDuyuru.TabIndex = 0;
            // 
            // btnDuyuruGonder
            // 
            this.btnDuyuruGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnDuyuruGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuyuruGonder.ForeColor = System.Drawing.Color.White;
            this.btnDuyuruGonder.Location = new System.Drawing.Point(283, 202);
            this.btnDuyuruGonder.Name = "btnDuyuruGonder";
            this.btnDuyuruGonder.Size = new System.Drawing.Size(174, 47);
            this.btnDuyuruGonder.TabIndex = 1;
            this.btnDuyuruGonder.Text = "Duyuru Gönder";
            this.btnDuyuruGonder.UseVisualStyleBackColor = false;
            this.btnDuyuruGonder.Click += new System.EventHandler(this.btnDuyuruGonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Duyurunuzu Giriniz :";
            // 
            // yeniDuyuru
            // 
            this.AcceptButton = this.btnDuyuruGonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDuyuruGonder);
            this.Controls.Add(this.txtDuyuru);
            this.Name = "yeniDuyuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yeniDuyuru";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDuyuru;
		private System.Windows.Forms.Button btnDuyuruGonder;
		private System.Windows.Forms.Label label1;
	}
}