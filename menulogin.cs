using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu.Metier;

namespace Menu
{
    public partial class menulogin : Form
    {
        public menulogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menulogin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            infoUsers info = new infoUsers();
            if (info.isValide(txtlogin.Text, txtpw.Text))
            {
                form_authentification form_authentification = new form_authentification();
                form_authentification.etatlogin = true;
                form_authentification.Show();
                this.Hide();
            }
            else
            {
                lblMsg.Text = "Login ou mot de passe invalide";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
