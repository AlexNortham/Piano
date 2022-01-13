using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Piano
{
    public partial class Form1 : Form
    {
        private string soundFileLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void keyClicked(object sender, EventArgs e)
        {
            string key = (((Button)sender).Name) + ".wav";
            string dir = Environment.CurrentDirectory;
            soundFileLocation = dir+ @"\piano_notes\"+ key;

            Thread t = new Thread(new ThreadStart(playSound));

            t.Start();
            

           
        }

        private void playSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundFileLocation);
            player.Play();
        }
    }
}
