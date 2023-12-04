using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BromoAirline.AdminForm
{
    public partial class frmPromo : Form
    {
        BromoAirlinesEntities db;
        int update;
        public frmPromo()
        {
            db = new BromoAirlinesEntities();
            InitializeComponent();
            load();
            claer();
        }
        private void load() 
        {
            var items = db.KodePromoes.OrderBy(a => a.Kode).Select(a => new { a.Kode, a.PersentaseDiskon, a.MaksimumDiskon, a.BerlakuSampai, a.Deskripsi }).ToList();
            dataGridView1.DataSource = items;
        }
        private void claer() 
        {
            
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (update == 0)
            {
                KodePromo Promo = new KodePromo
                {
                    Kode = txtkode.Text,
                    PersentaseDiskon = Convert.ToDouble(txtdiskon.Value),
                    MaksimumDiskon = Convert.ToInt32(txtMaksimum.Value),
                    BerlakuSampai = dtpberlaku.Value,
                    Deskripsi = txtAlamat.Text,
                };
                db.KodePromoes.Add(Promo);
                db.SaveChanges();
                MessageBox.Show("Diskon berhasil dimasukan");
                load();
            }
            else 
            {
                var items = db.KodePromoes.Where(a => a.ID == update).FirstOrDefault();
                if (items != null) 
                {
                    items.Kode = txtkode.Text;
                    items.PersentaseDiskon = Convert.ToDouble(txtdiskon.Value);
                    items.MaksimumDiskon = Convert.ToInt32(txtMaksimum.Value);
                    items.BerlakuSampai = dtpberlaku.Value;
                    items.Deskripsi = txtAlamat.Text;
                    db.SaveChanges();
                    MessageBox.Show("berhasil di Update");
                    btnSimpan.Text = "Simpan";
                    btnBatal.Visible = false;
                    load();
                    claer();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridView1.Rows[e.RowIndex].Cells["ckode"].Value.ToString();
            var id = db.KodePromoes.Where(a => a.Kode == name).Select(a => a.ID).FirstOrDefault();
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == cdelete.Index)
                {
                    if (MessageBox.Show("anda mau menghapus ini", "konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var delete = db.KodePromoes.Where(a => a.ID == id).FirstOrDefault();
                        db.KodePromoes.Remove(delete);
                        db.SaveChanges();
                        MessageBox.Show("berhasil di delete");
                        load();
                    }
                }
                if (e.ColumnIndex == cedit.Index)
                {
                    var items = db.KodePromoes.Where(a => a.ID == id).FirstOrDefault();
                    if (items != null) 
                    {
                        txtkode.Text = items.Kode;
                        txtdiskon.Value =Convert.ToInt32( items.PersentaseDiskon);
                        txtMaksimum.Value = Convert.ToInt32(items.MaksimumDiskon);
                        dtpberlaku.Value = (DateTime)items.BerlakuSampai;
                        txtAlamat.Text = items.Deskripsi;
                        update = items.ID;
                        btnBatal.Visible = true;
                        btnSimpan.Text = "Simpan";
                    }
                }
            }
        }
    }
}
