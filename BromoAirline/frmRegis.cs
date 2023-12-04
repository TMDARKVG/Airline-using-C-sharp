using System;
using System.CodeDom;
using System.Windows.Forms;

namespace BromoAirline
{
    public partial class frmRegis : Form
    {
        BromoAirlinesEntities db;
        public frmRegis()
        {
            db = new BromoAirlinesEntities();
            InitializeComponent();
        }

        private void txtNomor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btndaftar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "" || txtPass.Text.Trim() == "" || txtNomor.Text.Trim() == "" || txtdate.Text.Trim() == "" || txtdate.Text.Trim() == "")
            {
                MessageBox.Show("Isi Terlebih Dahulu Untuk isi Lain nya");
            }
            else
            {
                db = new BromoAirlinesEntities();
                Akun akun = new Akun
                {
                    Username = txtUser.Text,
                    Password = txtPass.Text,
                    Nama = txtName.Text,
                    TanggalLahir = txtdate.Value,
                    NomorTelepon = txtNomor.Text,
                    MerupakanAdmin = false,
                };
                db.Akuns.Add(akun);
                db.SaveChanges();
                MessageBox.Show("Berhail register");
                UserForm.frmMain main = new UserForm.frmMain();
                main.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}
