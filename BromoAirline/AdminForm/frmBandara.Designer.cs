namespace BromoAirline.AdminForm
{
    partial class frmBandara
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNegara = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.cmbNegara = new System.Windows.Forms.ComboBox();
            this.txtTerminal = new System.Windows.Forms.NumericUpDown();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.cnama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNegara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Bandara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semua Bandara yang terdaftar akan muncul disini";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnama,
            this.ckode,
            this.ckota,
            this.cNegara,
            this.cTerminal,
            this.calamat,
            this.cedit,
            this.cHapus});
            this.dataGridView1.Location = new System.Drawing.Point(3, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(981, 312);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kode  IATA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kota :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Negara :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Jumlah Terminal :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Alamat :";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(109, 425);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(244, 26);
            this.txtKode.TabIndex = 9;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(109, 393);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(244, 26);
            this.txtNama.TabIndex = 10;
            // 
            // txtNegara
            // 
            this.txtNegara.Location = new System.Drawing.Point(109, 457);
            this.txtNegara.Name = "txtNegara";
            this.txtNegara.Size = new System.Drawing.Size(244, 26);
            this.txtNegara.TabIndex = 11;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(611, 434);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(317, 83);
            this.txtAlamat.TabIndex = 12;
            // 
            // cmbNegara
            // 
            this.cmbNegara.FormattingEnabled = true;
            this.cmbNegara.Location = new System.Drawing.Point(109, 489);
            this.cmbNegara.Name = "cmbNegara";
            this.cmbNegara.Size = new System.Drawing.Size(244, 28);
            this.cmbNegara.TabIndex = 13;
            // 
            // txtTerminal
            // 
            this.txtTerminal.Location = new System.Drawing.Point(611, 393);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(317, 26);
            this.txtTerminal.TabIndex = 14;
            this.txtTerminal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTerminal_KeyPress);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(803, 545);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(125, 39);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(611, 545);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(118, 39);
            this.btnBatal.TabIndex = 16;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Visible = false;
            // 
            // cnama
            // 
            this.cnama.DataPropertyName = "Nama";
            this.cnama.HeaderText = "Nama";
            this.cnama.MinimumWidth = 8;
            this.cnama.Name = "cnama";
            this.cnama.ReadOnly = true;
            this.cnama.Width = 150;
            // 
            // ckode
            // 
            this.ckode.DataPropertyName = "kodeIATA";
            this.ckode.HeaderText = "Kode IATA";
            this.ckode.MinimumWidth = 8;
            this.ckode.Name = "ckode";
            this.ckode.ReadOnly = true;
            this.ckode.Width = 150;
            // 
            // ckota
            // 
            this.ckota.DataPropertyName = "Kota";
            this.ckota.HeaderText = "Kota";
            this.ckota.MinimumWidth = 8;
            this.ckota.Name = "ckota";
            this.ckota.ReadOnly = true;
            this.ckota.Width = 150;
            // 
            // cNegara
            // 
            this.cNegara.DataPropertyName = "Negara";
            this.cNegara.HeaderText = "Negara";
            this.cNegara.MinimumWidth = 8;
            this.cNegara.Name = "cNegara";
            this.cNegara.ReadOnly = true;
            this.cNegara.Width = 150;
            // 
            // cTerminal
            // 
            this.cTerminal.DataPropertyName = "JumlahTerminal";
            this.cTerminal.HeaderText = "Terminal";
            this.cTerminal.MinimumWidth = 8;
            this.cTerminal.Name = "cTerminal";
            this.cTerminal.ReadOnly = true;
            this.cTerminal.Width = 150;
            // 
            // calamat
            // 
            this.calamat.DataPropertyName = "Alamat";
            this.calamat.HeaderText = "Alamat";
            this.calamat.MinimumWidth = 8;
            this.calamat.Name = "calamat";
            this.calamat.ReadOnly = true;
            this.calamat.Width = 150;
            // 
            // cedit
            // 
            this.cedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            // cHapus
            // 
            this.cHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cHapus.HeaderText = "";
            this.cHapus.MinimumWidth = 8;
            this.cHapus.Name = "cHapus";
            this.cHapus.ReadOnly = true;
            this.cHapus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cHapus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cHapus.Text = "Hapus";
            this.cHapus.UseColumnTextForButtonValue = true;
            this.cHapus.Width = 150;
            // 
            // frmBandara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 596);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtTerminal);
            this.Controls.Add(this.cmbNegara);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNegara);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBandara";
            this.Text = "frmBandara";
            this.Load += new System.EventHandler(this.frmBandara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNegara;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.ComboBox cmbNegara;
        private System.Windows.Forms.NumericUpDown txtTerminal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckota;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNegara;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn calamat;
        private System.Windows.Forms.DataGridViewButtonColumn cedit;
        private System.Windows.Forms.DataGridViewButtonColumn cHapus;
    }
}