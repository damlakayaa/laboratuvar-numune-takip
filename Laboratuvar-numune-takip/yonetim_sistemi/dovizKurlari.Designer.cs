namespace yonetim_sistemi
{
	partial class dovizKurlari
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dovizKurlari));
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnotorumuKapat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(155, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 25);
			this.label1.TabIndex = 25;
			this.label1.Text = "Döviz Kurları";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 117);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(776, 321);
			this.dataGridView1.TabIndex = 26;
			// 

			// 
			// btnotorumuKapat
			// 
			this.btnotorumuKapat.FlatAppearance.BorderSize = 0;
			this.btnotorumuKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnotorumuKapat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnotorumuKapat.ForeColor = System.Drawing.Color.White;
			this.btnotorumuKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnotorumuKapat.Image")));
			this.btnotorumuKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnotorumuKapat.Location = new System.Drawing.Point(756, 12);
			this.btnotorumuKapat.Name = "btnotorumuKapat";
			this.btnotorumuKapat.Size = new System.Drawing.Size(32, 34);
			this.btnotorumuKapat.TabIndex = 22;
			this.btnotorumuKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnotorumuKapat.UseVisualStyleBackColor = true;
			this.btnotorumuKapat.Click += new System.EventHandler(this.btnotorumuKapat_Click);
			// 
			// dovizKurlari
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.btnotorumuKapat);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "dovizKurlari";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "dovizKurlari";
			this.Load += new System.EventHandler(this.dovizKurlari_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button btnotorumuKapat;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}