using BromoAirline.AdminForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirline
{
    public partial class frmLogin : Form
    {
        BromoAirlinesEntities db;
        public frmLogin()
        {
            db=new BromoAirlinesEntities();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db = new BromoAirlinesEntities();
            var items = db.Akuns.Where(a => a.Username.Equals(txtUser.Text)).FirstOrDefault();
            if (items != null)
            {
                if (items.Password.Equals(txtPass.Text))
                {
                    if (items.MerupakanAdmin == false)
                    {
                       MessageBox.Show("behisal login");
                        UserForm.frmMain main = new UserForm.frmMain();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        frmAdmin admin = new frmAdmin();
                        admin.Show();
                        MessageBox.Show("berhisil login admin");
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Password salah");
                }
            }
            else 
            {
                MessageBox.Show("Username salah");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegis rgi = new frmRegis();
            rgi.Show();
            this.Hide();
        }
    }
}
