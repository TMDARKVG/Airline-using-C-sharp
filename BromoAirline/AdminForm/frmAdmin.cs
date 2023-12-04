using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirline.AdminForm
{
    public partial class frmAdmin : Form
    {
            frmLogin login = new frmLogin();
        public frmAdmin()
        {
            InitializeComponent();
        }
        private void Loadform(object form)
        {
            if (this.panel10.Controls.Count > 0) this.panel10.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel10.Controls.Add(f);
            this.panel10.Tag = f;
            f.Show();
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {}
        private void panel8_Click(object sender, EventArgs e)
        {
            login.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            login.ShowDialog();
            label2.Visible = false;
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            Loadform(new frmjadwal());
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Loadform(new frmBandara());
        }
        private void panel4_Click(object sender, EventArgs e)
        {
            Loadform(new frmBandara());
        }
        private void panel5_Click(object sender, EventArgs e)
        {
            Loadform(new frmMaskapai());
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Loadform(new frmPromo());
        }
        private void panel6_Click_1(object sender, EventArgs e)
        {
            Loadform(new frmPromo());
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Loadform(new frmStatus());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Loadform(new frmStatus());
        }

        private void panel7_Click_1(object sender, EventArgs e)
        {
            Loadform(new frmStatus());

        }
    }
}
