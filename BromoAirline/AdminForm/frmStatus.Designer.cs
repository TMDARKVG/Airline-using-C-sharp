namespace BromoAirline.AdminForm
{
    partial class frmStatus
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdelay = new System.Windows.Forms.TextBox();
            this.ckode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmaskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckebernagkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwaktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdurasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cterkhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUbah = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ckode,
            this.cmaskapai,
            this.ckebernagkatan,
            this.ctujuan,
            this.ctanggal,
            this.cwaktu,
            this.cdurasi,
            this.cstatus,
            this.cterkhir,
            this.cUbah});
            this.dataGridView1.Location = new System.Drawing.Point(6, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(981, 431);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Semau Jadwal penerbangan akan muncul di sini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ubah Status Penerbangan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Status :";
            this.label3.Visible = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(831, 575);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(156, 37);
            this.btnSimpan.TabIndex = 42;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Visible = false;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(653, 575);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(156, 37);
            this.btnBatal.TabIndex = 43;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(76, 530);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(241, 28);
            this.cmbStatus.TabIndex = 44;
            this.cmbStatus.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Perkiraan Durasi Delay :";
            this.label4.Visible = false;
            // 
            // txtdelay
            // 
            this.txtdelay.Location = new System.Drawing.Point(590, 530);
            this.txtdelay.Name = "txtdelay";
            this.txtdelay.Size = new System.Drawing.Size(264, 26);
            this.txtdelay.TabIndex = 46;
            this.txtdelay.Visible = false;
            // 
            // ckode
            // 
            this.ckode.DataPropertyName = "kode";
            this.ckode.HeaderText = "Kode Penerbangan";
            this.ckode.MinimumWidth = 8;
            this.ckode.Name = "ckode";
            this.ckode.ReadOnly = true;
            this.ckode.Width = 150;
            // 
            // cmaskapai
            // 
            this.cmaskapai.DataPropertyName = "Makapai";
            this.cmaskapai.HeaderText = "Maskapai";
            this.cmaskapai.MinimumWidth = 8;
            this.cmaskapai.Name = "cmaskapai";
            this.cmaskapai.ReadOnly = true;
            this.cmaskapai.Width = 150;
            // 
            // ckebernagkatan
            // 
            this.ckebernagkatan.DataPropertyName = "Keberangkatan";
            this.ckebernagkatan.HeaderText = "Bandara keberangkatan";
            this.ckebernagkatan.MinimumWidth = 8;
            this.ckebernagkatan.Name = "ckebernagkatan";
            this.ckebernagkatan.ReadOnly = true;
            this.ckebernagkatan.Width = 150;
            // 
            // ctujuan
            // 
            this.ctujuan.DataPropertyName = "Tujuan";
            this.ctujuan.HeaderText = "Bandara Tujuan";
            this.ctujuan.MinimumWidth = 8;
            this.ctujuan.Name = "ctujuan";
            this.ctujuan.ReadOnly = true;
            this.ctujuan.Width = 150;
            // 
            // ctanggal
            // 
            this.ctanggal.DataPropertyName = "Tanggal";
            this.ctanggal.HeaderText = "Tanggal Keberangkatan";
            this.ctanggal.MinimumWidth = 8;
            this.ctanggal.Name = "ctanggal";
            this.ctanggal.ReadOnly = true;
            this.ctanggal.Width = 150;
            // 
            // cwaktu
            // 
            this.cwaktu.DataPropertyName = "waktu";
            this.cwaktu.HeaderText = "Waktu Keberangkatan";
            this.cwaktu.MinimumWidth = 8;
            this.cwaktu.Name = "cwaktu";
            this.cwaktu.ReadOnly = true;
            this.cwaktu.Width = 150;
            // 
            // cdurasi
            // 
            this.cdurasi.DataPropertyName = "Durasi";
            this.cdurasi.HeaderText = "Durasi Pending";
            this.cdurasi.MinimumWidth = 8;
            this.cdurasi.Name = "cdurasi";
            this.cdurasi.ReadOnly = true;
            this.cdurasi.Width = 150;
            // 
            // cstatus
            // 
            this.cstatus.DataPropertyName = "status";
            this.cstatus.HeaderText = "Status Terakhir";
            this.cstatus.MinimumWidth = 8;
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            this.cstatus.Width = 150;
            // 
            // cterkhir
            // 
            this.cterkhir.DataPropertyName = "terkhir";
            this.cterkhir.HeaderText = "Terakhir di";
            this.cterkhir.MinimumWidth = 8;
            this.cterkhir.Name = "cterkhir";
            this.cterkhir.ReadOnly = true;
            this.cterkhir.Width = 150;
            // 
            // cUbah
            // 
            this.cUbah.HeaderText = "";
            this.cUbah.MinimumWidth = 8;
            this.cUbah.Name = "cUbah";
            this.cUbah.ReadOnly = true;
            this.cUbah.Text = "Ubah";
            this.cUbah.UseColumnTextForButtonValue = true;
            this.cUbah.Width = 150;
            // 
            // frmStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 633);
            this.Controls.Add(this.txtdelay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStatus";
            this.Text = "frmStatus";
            this.Load += new System.EventHandler(this.frmStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmaskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckebernagkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwaktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdurasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cterkhir;
        private System.Windows.Forms.DataGridViewButtonColumn cUbah;
    }
}