using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BromoAirline.AdminForm
{
    public partial class frmBandara : Form
    {
        BromoAirlinesEntities db;
        string kodei;
        public frmBandara()
        {
            db = new BromoAirlinesEntities();
            InitializeComponent();
            bind();
            load();
            cler();
        }

        private void frmBandara_Load(object sender, EventArgs e)
        {
            bind();
        }
        private void cler()
        {
            txtNama.Text = "";
            txtKode.Text = "";
            txtNegara.Text = "";
            cmbNegara.Text = "";
            txtTerminal.Value = 0;
            txtAlamat.Text = "";
        }
        private void load()
        {
            var kon = from s in db.Negaras
                      join o in db.Bandaras on s.ID equals o.NegaraID
                      select new
                      {
                          Nama = o.Nama,
                          kodeIATA = o.KodeIATA,
                          kota = o.Kota,
                          Negara = s.Nama,
                          JumlahTerminal = o.JumlahTerminal,
                          Alamat = o.Alamat
                      };
            var tes = db.Negaras.Select(a => new { a.Nama }).ToList();
            var obj = db.Bandaras.OrderBy(a => a.Nama).Select(a => new { a.Nama, a.KodeIATA, a.Kota, a.Negara, a.JumlahTerminal, a.Alamat }).ToList();
            dataGridView1.DataSource = kon.ToList();
        }
        private void bind()
        {
            var items = db.Negaras.ToList();
            cmbNegara.DataSource = items;
            cmbNegara.DisplayMember = "Nama";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            var tes = db.Negaras.Where(a => a.Nama == cmbNegara.Text).Select(a => a.ID).FirstOrDefault();
            if (kodei == null)
            {
                if (txtNama.Text.Trim() == "" || txtKode.Text.Trim() == "")
                {
                    MessageBox.Show("isi terlebih dahulu nama dan kode bandara");
                }
                else if (txtNegara.Text.Trim() == "" || cmbNegara.Text.Trim() == "")
                {
                    MessageBox.Show("isi terlebih dahulu untuk negara dan kota nya");
                }
                else if (txtTerminal.Value == 0 || txtAlamat.Text.Trim() == "")
                {
                    MessageBox.Show("isi telebih dahulu untuk terminal dan alamat nya");
                }
                else
                {
                    var items1 = db.Bandaras.Where(a => a.KodeIATA.Equals(txtKode.Text)).FirstOrDefault();
                    if (items1 != null)
                    {
                        MessageBox.Show("sudah ada yang mengunakna kode itu");
                    }
                    else
                    {

                        var items = db.Negaras.Where(a => a.IbukotaNegara.Equals(cmbNegara.Text)).ToList();
                        Bandara bandara = new Bandara
                        {
                            Nama = txtNama.Text,
                            KodeIATA = txtKode.Text,
                            Kota = txtNegara.Text,
                            NegaraID = tes,
                            JumlahTerminal = Convert.ToInt32(txtTerminal.Value),
                            Alamat = txtAlamat.Text,
                        };
                        db.Bandaras.Add(bandara);
                        db.SaveChanges();
                        MessageBox.Show("sudah berhasil di input");
                        load();
                        cler();
                    }
                }
            }
            else
            {
                var items = db.Bandaras.Where(a => a.KodeIATA == kodei).FirstOrDefault();
                if (items != null)
                {
                    items.KodeIATA = txtKode.Text;
                    items.Nama = txtNama.Text;
                    items.Kota = txtNegara.Text;
                    items.NegaraID = tes;
                    items.JumlahTerminal = Convert.ToInt32(txtTerminal.Value);
                    items.Alamat = txtAlamat.Text;
                    db.SaveChanges();
                    MessageBox.Show("telah di upadte done");
                    btnSimpan.Text = "Simpan";
                    btnBatal.Visible = true;
                    load();
                    cler();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string name = dataGridView1.Rows[e.RowIndex].Cells["ckode"].Value.ToString();
                var target = db.Bandaras.Where(a => a.KodeIATA == name).Select(a => a.ID).FirstOrDefault();
                if (e.ColumnIndex == cHapus.Index)
                {
                    if (MessageBox.Show("anda yakin mau mnghapus ini " + name, "konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var bromo = db.Bandaras.Where(a => a.ID == target).FirstOrDefault();
                        db.Bandaras.Remove(bromo);
                        db.SaveChanges();
                        load();
                    }
                }
                if (e.ColumnIndex == cedit.Index)
                {
                    var kode = db.Bandaras.Where(a => a.ID == target).FirstOrDefault();
                    if (MessageBox.Show("anda mau edit ini " + name, "kon", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var select = db.Bandaras.Where(a => a.ID == target).FirstOrDefault();
                        if (kode != null)
                        {

                            txtNama.Text = kode.Nama;
                            txtKode.Text = kode.KodeIATA;
                            txtNegara.Text = kode.Kota;
                            cmbNegara.Text = kode.Negara.ToString();
                            txtTerminal.Value = kode.JumlahTerminal;
                            txtAlamat.Text = kode.Alamat;
                            kodei = kode.KodeIATA;
                            btnSimpan.Text = "Update";
                            btnBatal.Visible = true;

                        }
                    }
                }
            }
        }

        private void txtTerminal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTerminal.Value >= 15)
            {
                MessageBox.Show("Hanya bisa lima belas doang");
            }
        }
    }
}
