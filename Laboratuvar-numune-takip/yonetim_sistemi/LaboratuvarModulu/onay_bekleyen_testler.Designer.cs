namespace yonetim_sistemi.LaboratuvarModulu
{
	partial class onay_bekleyen_testler
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
			this.txtdurumtexti = new System.Windows.Forms.TextBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.btnOnayla = new System.Windows.Forms.Button();
			this.grdOnayBekleyenler = new System.Windows.Forms.DataGridView();
			this.btnyenile = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdOnayBekleyenler)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
			this.panel1.Controls.Add(this.btnyenile);
			this.panel1.Controls.Add(this.txtdurumtexti);
			this.panel1.Controls.Add(this.txtid);
			this.panel1.Controls.Add(this.btnOnayla);
			this.panel1.Location = new System.Drawing.Point(-1, 419);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(866, 61);
			this.panel1.TabIndex = 0;
			// 
			// txtdurumtexti
			// 
			this.txtdurumtexti.Location = new System.Drawing.Point(106, 41);
			this.txtdurumtexti.Name = "txtdurumtexti";
			this.txtdurumtexti.Size = new System.Drawing.Size(100, 20);
			this.txtdurumtexti.TabIndex = 3;
			this.txtdurumtexti.Visible = false;
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(0, 41);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(100, 20);
			this.txtid.TabIndex = 2;
			this.txtid.Visible = false;
			// 
			// btnOnayla
			// 
			this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOnayla.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnOnayla.ForeColor = System.Drawing.Color.White;
			this.btnOnayla.Location = new System.Drawing.Point(258, 4);
			this.btnOnayla.Name = "btnOnayla";
			this.btnOnayla.Size = new System.Drawing.Size(305, 55);
			this.btnOnayla.TabIndex = 1;
			this.btnOnayla.Text = "Testi Başlat";
			this.btnOnayla.UseVisualStyleBackColor = true;
			this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
			// 
			// grdOnayBekleyenler
			// 
			this.grdOnayBekleyenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdOnayBekleyenler.Location = new System.Drawing.Point(-1, 1);
			this.grdOnayBekleyenler.Name = "grdOnayBekleyenler";
			this.grdOnayBekleyenler.ReadOnly = true;
			this.grdOnayBekleyenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdOnayBekleyenler.Size = new System.Drawing.Size(866, 421);
			this.grdOnayBekleyenler.TabIndex = 1;
			this.grdOnayBekleyenler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOnayBekleyenler_CellClick);
			this.grdOnayBekleyenler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOnayBekleyenler_CellContentDoubleClick);
			// 
			// btnyenile
			// 
			this.btnyenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnyenile.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnyenile.ForeColor = System.Drawing.Color.White;
			this.btnyenile.Location = new System.Drawing.Point(760, 12);
			this.btnyenile.Name = "btnyenile";
			this.btnyenile.Size = new System.Drawing.Size(94, 46);
			this.btnyenile.TabIndex = 4;
			this.btnyenile.Text = "Yenile";
			this.btnyenile.UseVisualStyleBackColor = true;
			this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
			// 
			// onay_bekleyen_testler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 480);
			this.Controls.Add(this.grdOnayBekleyenler);
			this.Controls.Add(this.panel1);
			this.Name = "onay_bekleyen_testler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "onay_bekleyen_testler";
			this.Load += new System.EventHandler(this.onay_bekleyen_testler_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdOnayBekleyenler)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.DataGridView grdOnayBekleyenler;
		public System.Windows.Forms.Button btnOnayla;
		public System.Windows.Forms.TextBox txtid;
		public System.Windows.Forms.TextBox txtdurumtexti;
		public System.Windows.Forms.Button btnyenile;
	}
}