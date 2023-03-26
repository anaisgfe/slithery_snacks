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
using Menu.Models;

namespace Menu
{
    public partial class form_authentification : Form
    {
        public static bool etatlogin = false;

        public form_authentification()
        {
            InitializeComponent();
        }
        
        void login()
        {
            menulogin f1 = new menulogin();
            f1.MdiParent = this;
            f1.Show();

        }
        void form_authentification_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menulogin menulogin = new menulogin();
            menulogin.Show();
            this.Hide();
        }
    }
}
