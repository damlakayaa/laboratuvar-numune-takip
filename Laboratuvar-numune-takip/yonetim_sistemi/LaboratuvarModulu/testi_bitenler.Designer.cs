namespace yonetim_sistemi.LaboratuvarModulu
{
	partial class testi_bitenler
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnyenile = new System.Windows.Forms.Button();
			this.grdbitenler = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdbitenler)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
			this.panel1.Controls.Add(this.btnyenile);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(-1, 428);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(866, 52);
			this.panel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Ubuntu Light", 12.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(263, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(376, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Yukarıdaki Fİrmalarını Testleri Tamamlanmıştır";
			// 
			
			// btnyenile
			// 
			this.btnyenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnyenile.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnyenile.ForeColor = System.Drawing.Color.White;
			this.btnyenile.Location = new System.Drawing.Point(760, 3);
			this.btnyenile.Name = "btnyenile";
			this.btnyenile.Size = new System.Drawing.Size(94, 46);
			this.btnyenile.TabIndex = 5;
			this.btnyenile.Text = "Yenile";
			this.btnyenile.UseVisualStyleBackColor = true;
			this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
			// 
			// grdbitenler
			// 
			this.grdbitenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdbitenler.Location = new System.Drawing.Point(-1, 1);
			this.grdbitenler.Name = "grdbitenler";
			this.grdbitenler.ReadOnly = true;
			this.grdbitenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdbitenler.Size = new System.Drawing.Size(866, 427);
			this.grdbitenler.TabIndex = 5;
			this.grdbitenler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdbitenler_CellContentDoubleClick);
			// 
			// testi_bitenler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 480);
			this.Controls.Add(this.grdbitenler);
			this.Controls.Add(this.panel1);
			this.Name = "testi_bitenler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "testi_bitenler";
			this.Load += new System.EventHandler(this.testi_bitenler_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdbitenler)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnyenile;
		public System.Windows.Forms.DataGridView grdbitenler;
	}
}