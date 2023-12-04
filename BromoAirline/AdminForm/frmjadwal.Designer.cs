namespace BromoAirline.AdminForm
{
    partial class frmjadwal
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
            this.txtHarga = new System.Windows.Forms.NumericUpDown();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtWaktu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDurasi = new System.Windows.Forms.TextBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.cmbDari = new System.Windows.Forms.ComboBox();
            this.cmbKe = new System.Windows.Forms.ComboBox();
            this.cmbMaskapai = new System.Windows.Forms.ComboBox();
            this.ckode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbandara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmaskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwaktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdurasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cdelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(627, 537);
            this.txtHarga.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(298, 26);
            this.txtHarga.TabIndex = 25;
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(193, 426);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(233, 26);
            this.txtKode.TabIndex = 23;
            // 
            // txtWaktu
            // 
            this.txtWaktu.Location = new System.Drawing.Point(627, 460);
            this.txtWaktu.Name = "txtWaktu";
            this.txtWaktu.Size = new System.Drawing.Size(298, 26);
            this.txtWaktu.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tanggal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ke :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dari :";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(585, 575);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(136, 40);
            this.btnBatal.TabIndex = 18;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Visible = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(793, 575);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(132, 40);
            this.btnSimpan.TabIndex = 17;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kode Penerbangan :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ckode,
            this.cbandara,
            this.ctujuan,
            this.cmaskapai,
            this.Ctanggal,
            this.cwaktu,
            this.cdurasi,
            this.charga,
            this.cedit,
            this.cdelete});
            this.dataGridView1.Location = new System.Drawing.Point(3, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(981, 330);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Semau Jadwal penerbangan akan muncul di sini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Master Jadwal Penerbangan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Maskapai :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Waktu Keberangkatan :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Durasi Penerbanagan :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 537);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Harga Per Tiket :";
            // 
            // txtDurasi
            // 
            this.txtDurasi.Location = new System.Drawing.Point(627, 500);
            this.txtDurasi.Name = "txtDurasi";
            this.txtDurasi.Size = new System.Drawing.Size(298, 26);
            this.txtDurasi.TabIndex = 30;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(627, 419);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(298, 26);
            this.dtpTanggal.TabIndex = 31;
            // 
            // cmbDari
            // 
            this.cmbDari.FormattingEnabled = true;
            this.cmbDari.Location = new System.Drawing.Point(193, 466);
            this.cmbDari.Name = "cmbDari";
            this.cmbDari.Size = new System.Drawing.Size(233, 28);
            this.cmbDari.TabIndex = 32;
            // 
            // cmbKe
            // 
            this.cmbKe.FormattingEnabled = true;
            this.cmbKe.Location = new System.Drawing.Point(193, 513);
            this.cmbKe.Name = "cmbKe";
            this.cmbKe.Size = new System.Drawing.Size(233, 28);
            this.cmbKe.TabIndex = 33;
            // 
            // cmbMaskapai
            // 
            this.cmbMaskapai.FormattingEnabled = true;
            this.cmbMaskapai.Location = new System.Drawing.Point(193, 553);
            this.cmbMaskapai.Name = "cmbMaskapai";
            this.cmbMaskapai.Size = new System.Drawing.Size(233, 28);
            this.cmbMaskapai.TabIndex = 34;
            // 
            // ckode
            // 
            this.ckode.DataPropertyName = "KodePenerbangan";
            this.ckode.HeaderText = "Kode Penerbangan";
            this.ckode.MinimumWidth = 8;
            this.ckode.Name = "ckode";
            this.ckode.ReadOnly = true;
            this.ckode.Width = 150;
            // 
            // cbandara
            // 
            this.cbandara.DataPropertyName = "BandaraKeberangkatanID";
            this.cbandara.HeaderText = "bandara Keberangkatan";
            this.cbandara.MinimumWidth = 8;
            this.cbandara.Name = "cbandara";
            this.cbandara.ReadOnly = true;
            this.cbandara.Width = 150;
            // 
            // ctujuan
            // 
            this.ctujuan.DataPropertyName = "BandaraTujuanID";
            this.ctujuan.HeaderText = "Bandara Tujuan";
            this.ctujuan.MinimumWidth = 8;
            this.ctujuan.Name = "ctujuan";
            this.ctujuan.ReadOnly = true;
            this.ctujuan.Width = 150;
            // 
            // cmaskapai
            // 
            this.cmaskapai.DataPropertyName = "MaskapaiID";
            this.cmaskapai.HeaderText = "Maskapai";
            this.cmaskapai.MinimumWidth = 8;
            this.cmaskapai.Name = "cmaskapai";
            this.cmaskapai.ReadOnly = true;
            this.cmaskapai.Width = 150;
            // 
            // Ctanggal
            // 
            this.Ctanggal.DataPropertyName = "TanggalWaktuKeberangkatan";
            this.Ctanggal.HeaderText = "Tanggal Keberangakatan";
            this.Ctanggal.MinimumWidth = 8;
            this.Ctanggal.Name = "Ctanggal";
            this.Ctanggal.ReadOnly = true;
            this.Ctanggal.Width = 150;
            // 
            // cwaktu
            // 
            this.cwaktu.DataPropertyName = "Waktuuuu";
            this.cwaktu.HeaderText = "Waktu keberangkatan";
            this.cwaktu.MinimumWidth = 8;
            this.cwaktu.Name = "cwaktu";
            this.cwaktu.ReadOnly = true;
            this.cwaktu.Width = 150;
            // 
            // cdurasi
            // 
            this.cdurasi.DataPropertyName = "DurasiPenerbangan";
            this.cdurasi.HeaderText = "Durasi Penerbanagan";
            this.cdurasi.MinimumWidth = 8;
            this.cdurasi.Name = "cdurasi";
            this.cdurasi.ReadOnly = true;
            this.cdurasi.Width = 150;
            // 
            // charga
            // 
            this.charga.DataPropertyName = "HargaPerTiket";
            this.charga.HeaderText = "Harga Pertiket";
            this.charga.MinimumWidth = 8;
            this.charga.Name = "charga";
            this.charga.ReadOnly = true;
            this.charga.Width = 150;
            // 
            // cedit
            // 
            this.cedit.HeaderText = "";
            this.cedit.MinimumWidth = 8;
            this.cedit.Name = "cedit";
            this.cedit.ReadOnly = true;
            this.cedit.Text = "Edit";
            this.cedit.UseColumnTextForButtonValue = true;
            this.cedit.Width = 150;
            // 
            // cdelete
            // 
            this.cdelete.HeaderText = "";
            this.cdelete.MinimumWidth = 8;
            this.cdelete.Name = "cdelete";
            this.cdelete.ReadOnly = true;
            this.cdelete.Text = "Delete";
            this.cdelete.UseColumnTextForButtonValue = true;
            this.cdelete.Width = 150;
            // 
            // frmjadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 626);
            this.Controls.Add(this.cmbMaskapai);
            this.Controls.Add(this.cmbKe);
            this.Controls.Add(this.cmbDari);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.txtDurasi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.txtWaktu);
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
            this.Name = "frmjadwal";
            this.Text = "frmjadwal";
            ((System.ComponentModel.ISupportInitialize)(this.txtHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtHarga;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtWaktu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDurasi;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.ComboBox cmbDari;
        private System.Windows.Forms.ComboBox cmbKe;
        private System.Windows.Forms.ComboBox cmbMaskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbandara;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmaskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwaktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdurasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn charga;
        private System.Windows.Forms.DataGridViewButtonColumn cedit;
        private System.Windows.Forms.DataGridViewButtonColumn cdelete;
    }
}