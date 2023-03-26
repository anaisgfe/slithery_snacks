using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Menu
{
   
    public partial class menu : Form
    {
        //Charger le fichier audio en .wav
        SoundPlayer player = new SoundPlayer(@"C:\Users\anais\Slithery_snacks.wav");

        public menu()
        {
            InitializeComponent();
            player.Play();  //jouer la musique
        }
        
        private void Button1_Click(object sender, EventArgs e) //bouton qui amène à la page login
        {
            menulogin menulogin = new menulogin();
            menulogin.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e) //bouton qui amène à la page options
        {
            menuoptions menuoptions = new menuoptions();
            menuoptions.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)  //bouton quitter qui stop l'appli
        {
            this.Close();
            player.Stop(); //stop la musique
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void menu_Resize(object sender, EventArgs e)
        {
            //ClientRectangle.Width
            button3.Location = new Point(0, 0);
        }
    }
}
