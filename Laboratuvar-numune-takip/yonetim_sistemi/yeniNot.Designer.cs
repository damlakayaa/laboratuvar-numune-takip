namespace yonetim_sistemi
{
	partial class yeniNot
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnNotKaydet = new System.Windows.Forms.Button();
			this.txtNot = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(19, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 21);
			this.label1.TabIndex = 5;
			this.label1.Text = "Notunuzu Giriniz :";
			// 
			// btnNotKaydet
			// 
			this.btnNotKaydet.BackColor = System.Drawing.Color.DarkBlue;
			this.btnNotKaydet.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnNotKaydet.ForeColor = System.Drawing.Color.White;
			this.btnNotKaydet.Location = new System.Drawing.Point(312, 207);
			this.btnNotKaydet.Name = "btnNotKaydet";
			this.btnNotKaydet.Size = new System.Drawing.Size(135, 47);
			this.btnNotKaydet.TabIndex = 4;
			this.btnNotKaydet.Text = "Not Gönder";
			this.btnNotKaydet.UseVisualStyleBackColor = false;
			this.btnNotKaydet.Click += new System.EventHandler(this.btnNotKaydet_Click);
			// 
			// txtNot
			// 
			this.txtNot.Location = new System.Drawing.Point(23, 31);
			this.txtNot.Multiline = true;
			this.txtNot.Name = "txtNot";
			this.txtNot.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNot.Size = new System.Drawing.Size(742, 170);
			this.txtNot.TabIndex = 3;
			// 
			// yeniNot
			// 
			this.AcceptButton = this.btnNotKaydet;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 261);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnNotKaydet);
			this.Controls.Add(this.txtNot);
			this.Name = "yeniNot";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "yeniNot";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnNotKaydet;
		private System.Windows.Forms.TextBox txtNot;
	}
}