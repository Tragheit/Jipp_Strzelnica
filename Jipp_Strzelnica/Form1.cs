using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jipp_Strzelnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            home1.BringToFront();
        }

        private void HomeButtonClick(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\rrble\source\repos\Jipp_Strzelnica\Sounds\GunSound.wav");
            player.Play();

            home1.BringToFront();
        }

        private void BronieButton_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\rrble\source\repos\Jipp_Strzelnica\Sounds\GunSound.wav");
            player.Play();

            bronie1.BringToFront();
        }

        private void StanowiskaButton_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\rrble\source\repos\Jipp_Strzelnica\Sounds\GunSound.wav");
            player.Play();

            stanowiska1.BringToFront();
        }

        private void TrenerzyButton_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\rrble\source\repos\Jipp_Strzelnica\Sounds\GunSound.wav");
            player.Play();

            //trenerzy1.BringToFront();
        }

        private void KarnetyButton_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\rrble\source\repos\Jipp_Strzelnica\Sounds\GunSound.wav");
            player.Play();

            karnety1.BringToFront();
        }

        private void OnasButton_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\rrble\source\repos\Jipp_Strzelnica\Sounds\GunSound.wav");
            player.Play();

            oNas1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\rrble\source\repos\Jipp_Strzelnica\Sounds\GunSound.wav");
            player.Play();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bronie1_Load(object sender, EventArgs e)
        {

        }
    }
}
