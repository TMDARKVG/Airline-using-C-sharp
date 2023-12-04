using System;
using System.Data;
using System.Data.Entity.Core;
using System.Linq;
using System.Windows.Forms;

namespace BromoAirline.AdminForm
{
    public partial class frmMaskapai : Form
    {
        BromoAirlinesEntities db;
        int update1;
        public frmMaskapai()
        {
            db = new BromoAirlinesEntities();
            InitializeComponent();
            load();
        }
        private void clear() 
        {
            txtNama.Text = "";
            txtPerus.Text = "";
            txtJumalah.Value = 0;
            txtDes.Text = "";
            update1 = 0;
        }
        private void load()
        {
            var items = db.Maskapais.OrderBy(a => a.Nama).Select(a => new { a.Nama, a.Perusahaan, a.JumlahKru, a.Deskripsi }).ToList();
            dataGridView1.DataSource = items;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (update1 == 0)
            {
                Maskapai maskapai = new Maskapai
                {
                    Nama = txtNama.Text,
                    Perusahaan = txtPerus.Text,
                    JumlahKru = Convert.ToInt32(txtJumalah.Value),
                    Deskripsi = txtDes.Text,
                };
                db.Maskapais.Add(maskapai);
                db.SaveChanges();
                MessageBox.Show("telah di input");
                load();
                clear();
            }
            else 
            {
                var update = db.Maskapais.Where(a=>a.ID == update1).FirstOrDefault();
                if (update != null) 
                {
                    update.Nama = txtNama.Text;
                    update.Perusahaan =txtPerus.Text;
                    update.JumlahKru = Convert.ToInt32(txtJumalah.Value);
                    update.Deskripsi = txtDes.Text;
                    db.SaveChanges();
                    btnSimpan.Text = "Simpan";
                    btnBatal.Visible = false;
                    load();
                    clear();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridView1.Rows[e.RowIndex].Cells["cNama"].Value.ToString();
            var kon = db.Maskapais.Where(a=>a.Nama == name).Select(a=>a.ID).FirstOrDefault();
            var tes = (from o in db.Maskapais where o.Nama == name select o.ID).FirstOrDefault();
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == cDelete.Index)
                {
                    if (MessageBox.Show("anda yakin mau meghapus ini", "konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (tes != 0)
                        {
                            var remove = db.Maskapais.Where(a => a.ID == tes).FirstOrDefault();
                            db.Maskapais.Remove(remove);
                            db.SaveChanges();
                            MessageBox.Show("Berhasil di hapus");
                            load();
                            clear();
                        }
                    }
                }
                if (e.ColumnIndex == cedit.Index)
                {
                    var update = db.Maskapais.Where(a => a.ID == tes).FirstOrDefault();
                    if (tes != 0)
                    {
                        txtNama.Text = update.Nama;
                        txtPerus.Text = update.Perusahaan;
                        txtJumalah.Value = update.JumlahKru;
                        txtDes.Text = update.Deskripsi;
                        update1 = update.ID;
                        btnBatal.Visible = true;
                        btnSimpan.Text = "Update";
                    }
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
            btnBatal.Visible= false;
        }
        private void txtJumalah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtJumalah.Value >= 100) 
            {
                MessageBox.Show("Maksimal Hanya seratus");
            }
        }
    }
}
