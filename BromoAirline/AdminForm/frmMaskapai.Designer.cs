namespace BromoAirline.AdminForm
{
    partial class frmMaskapai
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPerusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjumlahkru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDeskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPerus = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtJumalah = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumalah)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Maskapai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semau Maskapai yang terdaftar akan Muncul di sini";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNama,
            this.cPerusahaan,
            this.cjumlahkru,
            this.cDeskripsi,
            this.cedit,
            this.cDelete});
            this.dataGridView1.Location = new System.Drawing.Point(17, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(910, 330);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cNama
            // 
            this.cNama.DataPropertyName = "Nama";
            this.cNama.HeaderText = "Nama";
            this.cNama.MinimumWidth = 8;
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            this.cNama.Width = 150;
            // 
            // cPerusahaan
            // 
            this.cPerusahaan.DataPropertyName = "Perusahaan";
            this.cPerusahaan.HeaderText = "Perusahaan";
            this.cPerusahaan.MinimumWidth = 8;
            this.cPerusahaan.Name = "cPerusahaan";
            this.cPerusahaan.ReadOnly = true;
            this.cPerusahaan.Width = 150;
            // 
            // cjumlahkru
            // 
            this.cjumlahkru.DataPropertyName = "JumlahKru";
            this.cjumlahkru.HeaderText = "JumlahKru";
            this.cjumlahkru.MinimumWidth = 8;
            this.cjumlahkru.Name = "cjumlahkru";
            this.cjumlahkru.ReadOnly = true;
            this.cjumlahkru.Width = 150;
            // 
            // cDeskripsi
            // 
            this.cDeskripsi.DataPropertyName = "Deskripsi";
            this.cDeskripsi.HeaderText = "Deskripsi";
            this.cDeskripsi.MinimumWidth = 8;
            this.cDeskripsi.Name = "cDeskripsi";
            this.cDeskripsi.ReadOnly = true;
            this.cDeskripsi.Width = 150;
            // 
            // cedit
            // 
            this.cedit.HeaderText = "";
            this.cedit.MinimumWidth = 8;
            this.cedit.Name = "cedit";
            this.cedit.ReadOnly = true;
            this.cedit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cedit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cedit.Text = "Edit";
            this.cedit.UseColumnTextForButtonValue = true;
            this.cedit.Width = 150;
            // 
            // cDelete
            // 
            this.cDelete.HeaderText = "";
            this.cDelete.MinimumWidth = 8;
            this.cDelete.Name = "cDelete";
            this.cDelete.ReadOnly = true;
            this.cDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cDelete.Text = "Delete";
            this.cDelete.UseColumnTextForButtonValue = true;
            this.cDelete.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name :";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(790, 573);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(132, 40);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(582, 573);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(136, 40);
            this.btnBatal.TabIndex = 5;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Visible = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Perusahan :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Jumlah Kru :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Deskripsi :";
            // 
            // txtPerus
            // 
            this.txtPerus.Location = new System.Drawing.Point(133, 467);
            this.txtPerus.Name = "txtPerus";
            this.txtPerus.Size = new System.Drawing.Size(233, 26);
            this.txtPerus.TabIndex = 9;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(131, 424);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(233, 26);
            this.txtNama.TabIndex = 10;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(582, 424);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(340, 116);
            this.txtDes.TabIndex = 11;
            // 
            // txtJumalah
            // 
            this.txtJumalah.Location = new System.Drawing.Point(135, 514);
            this.txtJumalah.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtJumalah.Name = "txtJumalah";
            this.txtJumalah.Size = new System.Drawing.Size(231, 26);
            this.txtJumalah.TabIndex = 12;
            this.txtJumalah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumalah_KeyPress);
            // 
            // frmMaskapai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 625);
            this.Controls.Add(this.txtJumalah);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtPerus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMaskapai";
            this.Text = "frmMaskapai";
            this.Load += new System.EventHandler(this.frmMaskapai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumalah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPerus;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.NumericUpDown txtJumalah;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPerusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjumlahkru;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDeskripsi;
        private System.Windows.Forms.DataGridViewButtonColumn cedit;
        private System.Windows.Forms.DataGridViewButtonColumn cDelete;
    }
}