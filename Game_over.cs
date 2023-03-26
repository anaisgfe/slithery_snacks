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
    
    public partial class Game_over : Form
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\anais\Game_over.wav");
        public Game_over()
        {
            InitializeComponent();
        }

        private void Game_over_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            player.Stop(); //stop la musique
        }
    }
}
