using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BromoAirline.AdminForm
{
    public partial class frmjadwal : Form
    {
        BromoAirlinesEntities db;
        int update;
        public frmjadwal()
        {
            db = new BromoAirlinesEntities();
            InitializeComponent();
            loadcmb();
            load();
        }
        private void loadcmb()
        {
            var items1 = db.Maskapais.ToList();
            var items = db.Bandaras.ToList();
            cmbDari.DataSource = items;
            cmbDari.DisplayMember = "Nama";
            cmbKe.DataSource = items;
            cmbKe.DisplayMember = "Nama";
            cmbMaskapai.DataSource = items1;
            cmbMaskapai.DisplayMember = "Nama";
        }
        private void load()
        {
            var join = from o in db.Bandaras
                       join e in db.Maskapais on o.ID equals e.ID into JadwalPenerbangans
                       from g in db.JadwalPenerbangans
                       select new
                       {
                           KodePenerbangan = g.KodePenerbangan,
                           BandaraKeberangkatanID = o.Nama,
                           BandaraTujuanID = o.Nama,
                           MaskapaiID = g.MaskapaiID,
                           TanggalWaktuKeberangkatan = g.TanggalWaktuKeberangkatan,
                           Waktuuuu = g.TanggalWaktuKeberangkatan, //belum fix
                           DurasiPenerbangan = g.DurasiPenerbangan,
                           HargaPerTiket = g.HargaPerTiket,
                       };
            dataGridView1.DataSource = join.ToList();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (update == 0)
            {
                JadwalPenerbangan jadwal = new JadwalPenerbangan
                {
                    KodePenerbangan = txtKode.Text,
                    BandaraKeberangkatanID = Convert.ToInt32(cmbDari.Text),
                    BandaraTujuanID = Convert.ToInt32(cmbKe.Text),
                    MaskapaiID = Convert.ToInt32(cmbMaskapai.Text),
                    TanggalWaktuKeberangkatan = dtpTanggal.Value,
                    //TanggalWaktuKeberangkatan = txtWaktu.Text, //masih cari cara
                    DurasiPenerbangan = Convert.ToInt32(txtDurasi.Text),
                    HargaPerTiket = Convert.ToInt32(txtHarga.Value),
                };
                db.JadwalPenerbangans.Add(jadwal);
                db.SaveChanges();
                MessageBox.Show("jadwal telah di input");
            }
            else 
            {
                var items = db.JadwalPenerbangans.Where(a => a.ID == update).FirstOrDefault();
                if (items != null) 
                {
                    items.KodePenerbangan = txtKode.Text;
                    items.BandaraKeberangkatanID = Convert.ToInt32 (cmbDari.Text); // belum fix
                    items.BandaraTujuanID = Convert.ToInt32(cmbKe.Text); //belum fix
                    items.MaskapaiID = Convert.ToInt32(cmbMaskapai.Text); //belum fix
                    items.TanggalWaktuKeberangkatan = (DateTime)dtpTanggal.Value; // belum fix
                    //items.TanggalWaktuKeberangkatan = txtWaktu.Text; // belum fix
                    items.DurasiPenerbangan = Convert.ToInt32(txtDurasi.Text);
                    items.HargaPerTiket = Convert.ToDouble(txtHarga.Text);
                    db.SaveChanges();
                    MessageBox.Show("Berhasil di update");
                    btnBatal.Visible = false;
                    btnSimpan.Text = "Simpan";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridView1.Rows[e.RowIndex].Cells["ckode"].Value.ToString();
            var items = db.JadwalPenerbangans.Where(a => a.KodePenerbangan == name).Select(a => a.ID).FirstOrDefault();
            //int id;
            if (e.RowIndex == 0)
            {
                if (e.ColumnIndex == cdelete.Index)
                {
                    if (MessageBox.Show("Yakin mau hapus ini", "konfimasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var tes = db.JadwalPenerbangans.Where(a => a.ID == items).FirstOrDefault();
                        db.JadwalPenerbangans.Remove(tes);
                        db.SaveChanges();
                        MessageBox.Show("data berhasil di apus");
                    }
                }
                if (e.ColumnIndex == cedit.Index)
                {
                    var items1 = db.JadwalPenerbangans.Where(a => a.ID == items).FirstOrDefault();
                    if (items1 != null)
                    {
                        txtKode.Text = items1.KodePenerbangan;
                        cmbDari.Text = items1.BandaraKeberangkatanID.ToString();
                        cmbKe.Text = items1.BandaraTujuanID.ToString();
                        cmbMaskapai.Text = items1.MaskapaiID.ToString();
                        dtpTanggal.Value = items1.TanggalWaktuKeberangkatan;
                        txtWaktu.Text = items1.TanggalWaktuKeberangkatan.ToString();
                        txtDurasi.Text = items1.DurasiPenerbangan.ToString();
                        txtHarga.Value = Convert.ToInt32(items1.HargaPerTiket);
                        update = items1.ID;
                        btnSimpan.Text = "Update";
                        btnBatal.Visible = true;
                    }
                }
            }
        }
    }
}
