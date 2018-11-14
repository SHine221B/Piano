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
    public partial class Form1 : Form

    {

        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bC_Click(object sender, EventArgs e)
        {
            player.URL = "C.wav";
            player.controls.play();
        }

        private void bC1_Click(object sender, EventArgs e)
        {
            player.URL = "C#.wav";
            player.controls.play();
        }

        private void bD_Click(object sender, EventArgs e)
        {
            player.URL = "D.wav";
            player.controls.play();
        }

        private void bD1_Click(object sender, EventArgs e)
        {
            player.URL = "D#.wav";
            player.controls.play();
        }

        private void bE_Click(object sender, EventArgs e)
        {
            player.URL = "E.wav";
            player.controls.play();
        }

        private void bF_Click(object sender, EventArgs e)
        {
            player.URL = "F.wav";
            player.controls.play();
        }

        private void bF1_Click(object sender, EventArgs e)
        {
            player.URL = "F#.wav";
            player.controls.play();
        }

        public void bG_Click(object sender, EventArgs e)
        {
            player.URL = "G.wav";
            player.controls.play();
        }

        private void bG1_Click(object sender, EventArgs e)
        {
            player.URL = "G#.wav";
            player.controls.play();
        }

        private void bA_Click(object sender, EventArgs e)
        {
            player.URL = "A.wav";
            player.controls.play();
        }

        private void bB_Click(object sender, EventArgs e)
        {
            player.URL = "B.wav";
            player.controls.play();
        }

        private void bH_Click(object sender, EventArgs e)
        {
            player.URL = "H.wav";
            player.controls.play();;
        }

        private void bC2_Click(object sender, EventArgs e)
        {
            player.URL = "C2.wav";
            player.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Window3 = new Form3();
            Window3.ShowDialog();
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            Form2 Window2 = new Form2();
            Window2.ShowDialog();
        }

        
    }
}
