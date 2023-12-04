namespace BromoAirline.AdminForm
{
    partial class frmPromo
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
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ckode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDiskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmaskimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cdelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaksimum = new System.Windows.Forms.NumericUpDown();
            this.txtdiskon = new System.Windows.Forms.NumericUpDown();
            this.dtpberlaku = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaksimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiskon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(564, 547);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(138, 39);
            this.btnBatal.TabIndex = 33;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Visible = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(738, 547);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(143, 39);
            this.btnSimpan.TabIndex = 32;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(564, 388);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(317, 83);
            this.txtAlamat.TabIndex = 29;
            // 
            // txtkode
            // 
            this.txtkode.Location = new System.Drawing.Point(162, 388);
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(220, 26);
            this.txtkode.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Deskripsi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Maksimum Diskon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Presntasi Diskon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Berlaku Sampai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kode Promo:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ckode,
            this.cDiskon,
            this.cmaskimum,
            this.claku,
            this.cdes,
            this.cedit,
            this.cdelete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(981, 312);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ckode
            // 
            this.ckode.DataPropertyName = "Kode";
            this.ckode.HeaderText = "Kode";
            this.ckode.MinimumWidth = 8;
            this.ckode.Name = "ckode";
            this.ckode.ReadOnly = true;
            this.ckode.Width = 150;
            // 
            // cDiskon
            // 
            this.cDiskon.DataPropertyName = "PersentaseDiskon";
            this.cDiskon.HeaderText = "PresenstseDiskon";
            this.cDiskon.MinimumWidth = 8;
            this.cDiskon.Name = "cDiskon";
            this.cDiskon.ReadOnly = true;
            this.cDiskon.Width = 150;
            // 
            // cmaskimum
            // 
            this.cmaskimum.DataPropertyName = "MaksimumDiskon";
            this.cmaskimum.HeaderText = "Maksimum Diskon";
            this.cmaskimum.MinimumWidth = 8;
            this.cmaskimum.Name = "cmaskimum";
            this.cmaskimum.ReadOnly = true;
            this.cmaskimum.Width = 150;
            // 
            // claku
            // 
            this.claku.DataPropertyName = "BerlakuSampai";
            this.claku.HeaderText = "Berlaku sampai";
            this.claku.MinimumWidth = 8;
            this.claku.Name = "claku";
            this.claku.ReadOnly = true;
            this.claku.Width = 150;
            // 
            // cdes
            // 
            this.cdes.DataPropertyName = "Deskripsi";
            this.cdes.HeaderText = "Deskripsi";
            this.cdes.MinimumWidth = 8;
            this.cdes.Name = "cdes";
            this.cdes.ReadOnly = true;
            this.cdes.Width = 150;
            // 
            // cedit
            // 
            this.cedit.HeaderText = "";
            this.cedit.MinimumWidth = 8;
            this.cedit.Name = "cedit";
            this.cedit.ReadOnly = true;
            this.cedit.Text = "edit";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Semua Bandara yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Master Kode Promo";
            // 
            // txtMaksimum
            // 
            this.txtMaksimum.Location = new System.Drawing.Point(162, 493);
            this.txtMaksimum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtMaksimum.Name = "txtMaksimum";
            this.txtMaksimum.Size = new System.Drawing.Size(220, 26);
            this.txtMaksimum.TabIndex = 34;
            // 
            // txtdiskon
            // 
            this.txtdiskon.Location = new System.Drawing.Point(162, 457);
            this.txtdiskon.Name = "txtdiskon";
            this.txtdiskon.Size = new System.Drawing.Size(220, 26);
            this.txtdiskon.TabIndex = 35;
            // 
            // dtpberlaku
            // 
            this.dtpberlaku.Location = new System.Drawing.Point(162, 420);
            this.dtpberlaku.Name = "dtpberlaku";
            this.dtpberlaku.Size = new System.Drawing.Size(220, 26);
            this.dtpberlaku.TabIndex = 36;
            // 
            // frmPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 637);
            this.Controls.Add(this.dtpberlaku);
            this.Controls.Add(this.txtdiskon);
            this.Controls.Add(this.txtMaksimum);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtkode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPromo";
            this.Text = "frmPromo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaksimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiskon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtkode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtMaksimum;
        private System.Windows.Forms.NumericUpDown txtdiskon;
        private System.Windows.Forms.DateTimePicker dtpberlaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiskon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmaskimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn claku;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdes;
        private System.Windows.Forms.DataGridViewButtonColumn cedit;
        private System.Windows.Forms.DataGridViewButtonColumn cdelete;
    }
}