using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BromoAirline.AdminForm
{
    public partial class frmStatus : Form
    {
        BromoAirlinesEntities db;
        int rubah;
        public frmStatus()
        {
            db = new BromoAirlinesEntities();
            InitializeComponent();
            load();
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {

        }
        private void load()
        {
            var items = from a in db.JadwalPenerbangans
                        join i in db.Maskapais on a.ID equals i.ID into tes
                        from u in db.PerubahanStatusJadwalPenerbangans
                        join e in db.Bandaras on u.ID equals e.ID into kon
                        select new
                        {
                            kode = a.KodePenerbangan,
                            Maskapai = u.ID,
                            Keberangkatan = a.BandaraKeberangkatanID,
                            Tujuan = a.BandaraTujuanID,
                            Tanggal = a.TanggalWaktuKeberangkatan,
                            Durasi = a.DurasiPenerbangan,
                            status = u.WaktuPerubahanTerjadi,
                            terkhir = u.PerkiraanDurasiDelay,
                        };
            dataGridView1.DataSource = items.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (e.RowIndex == cUbah.Index)
                {
                    var items = db.PerubahanStatusJadwalPenerbangans.Where(a => a.ID == rubah).FirstOrDefault();
                    if (items != null)
                    {

                    }
                }
            }
        }
    }
}
