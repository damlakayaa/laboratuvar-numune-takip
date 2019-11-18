namespace yonetim_sistemi.LaboratuvarModulu
{
	partial class devam_eden_testler
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
			this.btnbitir = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnyenile = new System.Windows.Forms.Button();
			this.txtdurumtexti = new System.Windows.Forms.TextBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.grdDevamEdenleriGetir = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDevamEdenleriGetir)).BeginInit();
			this.SuspendLayout();
			// 
			// btnbitir
			// 
			this.btnbitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnbitir.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnbitir.ForeColor = System.Drawing.Color.White;
			this.btnbitir.Location = new System.Drawing.Point(258, 4);
			this.btnbitir.Name = "btnbitir";
			this.btnbitir.Size = new System.Drawing.Size(305, 55);
			this.btnbitir.TabIndex = 1;
			this.btnbitir.Text = "Testi Bitir";
			this.btnbitir.UseVisualStyleBackColor = true;
			this.btnbitir.Click += new System.EventHandler(this.btnbitir_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
			this.panel1.Controls.Add(this.btnyenile);
			this.panel1.Controls.Add(this.txtdurumtexti);
			this.panel1.Controls.Add(this.txtid);
			this.panel1.Controls.Add(this.btnbitir);
			this.panel1.Location = new System.Drawing.Point(-1, 419);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(866, 61);
			this.panel1.TabIndex = 2;
			// 
			// btnyenile
			// 
			this.btnyenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnyenile.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnyenile.ForeColor = System.Drawing.Color.White;
			this.btnyenile.Location = new System.Drawing.Point(769, 9);
			this.btnyenile.Name = "btnyenile";
			this.btnyenile.Size = new System.Drawing.Size(94, 46);
			this.btnyenile.TabIndex = 5;
			this.btnyenile.Text = "Yenile";
			this.btnyenile.UseVisualStyleBackColor = true;
			this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
			// 
			// txtdurumtexti
			// 
			this.txtdurumtexti.Location = new System.Drawing.Point(109, 38);
			this.txtdurumtexti.Name = "txtdurumtexti";
			this.txtdurumtexti.Size = new System.Drawing.Size(100, 20);
			this.txtdurumtexti.TabIndex = 3;
			this.txtdurumtexti.Visible = false;
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(3, 38);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(100, 20);
			this.txtid.TabIndex = 2;
			this.txtid.Visible = false;
			// 
			// grdDevamEdenleriGetir
			// 
			this.grdDevamEdenleriGetir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdDevamEdenleriGetir.Location = new System.Drawing.Point(-1, 1);
			this.grdDevamEdenleriGetir.Name = "grdDevamEdenleriGetir";
			this.grdDevamEdenleriGetir.ReadOnly = true;
			this.grdDevamEdenleriGetir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDevamEdenleriGetir.Size = new System.Drawing.Size(866, 421);
			this.grdDevamEdenleriGetir.TabIndex = 3;
			this.grdDevamEdenleriGetir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDevamEdenleriGetir_CellClick);
			this.grdDevamEdenleriGetir.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDevamEdenleriGetir_CellContentDoubleClick);
			// 
			// devam_eden_testler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 480);
			this.Controls.Add(this.grdDevamEdenleriGetir);
			this.Controls.Add(this.panel1);
			this.Name = "devam_eden_testler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "devam_eden_testler";
			this.Load += new System.EventHandler(this.devam_eden_testler_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDevamEdenleriGetir)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnbitir;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.TextBox txtdurumtexti;
		public System.Windows.Forms.Button btnyenile;
		public System.Windows.Forms.DataGridView grdDevamEdenleriGetir;
	}
}