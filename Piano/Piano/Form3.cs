using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace Piano
{
    public partial class Form3 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Form3()
        {
            InitializeComponent();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            Form2 Window2 = new Form2();
            Window2.ShowDialog();
        }

        private void bGuitar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Window1 = new Form1();
            Window1.ShowDialog();
        }

        private void bC_Click(object sender, EventArgs e)
        {
            player.URL = "CG.wav";
            player.controls.play();
        }

        private void bC1_Click(object sender, EventArgs e)
        {
            player.URL = "C#G.mp3";
            player.controls.play();
        }

        private void bD_Click(object sender, EventArgs e)
        {
            player.URL = "DG.wav";
            player.controls.play();
        }

        private void bD1_Click(object sender, EventArgs e)
        {
            player.URL = "D#G.wav";
            player.controls.play();
        }

        private void bE_Click(object sender, EventArgs e)
        {
            player.URL = "EG.wav";
            player.controls.play();
        }

        private void bF_Click(object sender, EventArgs e)
        {
            player.URL = "FG.wav";
            player.controls.play();
        }

        private void bF1_Click(object sender, EventArgs e)
        {
            player.URL = "F#G.wav";
            player.controls.play();
        }

        public void bG_Click(object sender, EventArgs e)
        {
            player.URL = "GG.wav";
            player.controls.play();
        }

        private void bG1_Click(object sender, EventArgs e)
        {
            player.URL = "G#G.wav";
            player.controls.play();
        }

        private void bA_Click(object sender, EventArgs e)
        {
            player.URL = "AG.wav";
            player.controls.play();
        }

        private void bB_Click(object sender, EventArgs e)
        {
            player.URL = "BG.wav";
            player.controls.play();
        }

        private void bH_Click(object sender, EventArgs e)
        {
            player.URL = "HG.wav";
            player.controls.play(); ;
        }

        private void bC2_Click(object sender, EventArgs e)
        {
            player.URL = "C2G.wav";
            player.controls.play();
        }
    }
}
