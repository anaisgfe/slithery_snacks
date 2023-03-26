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
   
    public partial class menuoptions : Form
    {

        public menuoptions()
        {
            InitializeComponent();
            
        }

        private void menuoptions_Load(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }
  
        private void trackBar1_Scroll(object sender, EventArgs e)  /*soundplayer n'utilise pas de fonction Volume 
            donc on utilise waveOutSetVolume qui prend en entrée un pointeur vers le périphérique audio et un entier 
            non signé de 32 bits qui prends les 16 état de chaque canaux qui sont les niveaux de volume*/
        {
            int newVolume = (ushort.MaxValue / 100) * trackBar1.Value;
            uint newVolumeAllChannels = (((uint)newVolume & 0x0000ffff) | ((uint)newVolume << 16)); /*conversion des niveaux de volume actuels de la trackbar en un entier non signé de 32 bits*/
            NativeMethods.waveOutSetVolume(IntPtr.Zero, newVolumeAllChannels); //régle les niveaux de volume

            // Récupérer la valeur actuelle de la trackbar
            int value = trackBar1.Value;

            // Mettre à jour le texte du label avec la nouvelle valeur
            label3.Text = value.ToString();
        }
        static class NativeMethods //classe qui permet de faire appel à des fonctions non managées qui sont définies dans des bibliothèques externes telles que winmm.dll
        {
            [System.Runtime.InteropServices.DllImport("winmm.dll")]
            public static extern uint waveOutSetVolume(IntPtr hwo, uint dwVolume); //ici on va faire appel à la fonction waveOutSetVolume qui s'occupe du réglage du volume du périphérique
            public static uint WaveOutSetVolume(IntPtr hwo, ushort leftChannel, ushort rightChannel)
            {
                uint dwVolume = ((uint)leftChannel) << 16 | (uint)rightChannel;
                return waveOutSetVolume(IntPtr.Zero, dwVolume);
            }
        }
        /*On a été obligé de faire appel à des fonctions non managées car on ne travaillait pas sur un projet WPF qui aurait permis 
         d'utiliser mediaplayer pour le réglage du volume, de plus la fonction SoundPlayer n'a pas de définition de la propriété 
         Volume il est donc également impossible d'utiliser ce biais là. Donc la seule solution trouvée était d'utiliser des 
         classes et des méthodes non managées*/
    }
}
