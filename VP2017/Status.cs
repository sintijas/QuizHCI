using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace VP2017
{
    public partial class Status : Form
    {
        Color c;
        int i;
        string path = "$8,000 Win - Who Wants to Be a Millionaire- (online-audio-converter.com).wav";
        SoundPlayer player;
        public Status(int i)
        {
            this.i = i;
            c = Color.FromArgb(237, 145, 19);
            InitializeComponent();
            player = new SoundPlayer(path);
            player.Play();
            timer1.Start();
            this.BackColor = Color.Black;
            //timerBoja.Start();
            //timerBoja.Tick += (s, e) =>
            //this.BackColor = this.BackColor == Color.Black ? c : Color.Black;
            //ProveriSuma(i);  
            NapisiTekst(i);
        }


        private void NapisiTekst(int i)
        {
            if (i == 1)
            {
                lblPrasanje.Text = "прашање број 1!";
            }
            else if (i == 2)
            {
                lblPrasanje.Text = "прашање број 2!";
            }
            else if (i == 3)
            {
                lblPrasanje.Text = "прашање број 3!";
            }
            else if (i == 4)
            {
                lblPrasanje.Text = "прашање број 4!";
            }
            else if (i == 5)
            {
                lblPrasanje.Text = "прашање број 5!";
            }
            else if (i == 6)
            {
                lblPrasanje.Text = "прашање број 6!";
            }
            else if (i == 7)
            {
                lblPrasanje.Text = "прашање број 7!";
            }
            else if (i == 8)
            {
                lblPrasanje.Text = "прашање број 8!";
            }
            else if (i == 9)
            {
                lblPrasanje.Text = "прашање број 9!";
            }
            else if (i == 10)
            {
                lblPrasanje.Text = "прашање број 10!";
            }
            else if (i == 11)
            {
                lblPrasanje.Text = "прашање број 11!";
            }
            else if (i == 12)
            {
                lblPrasanje.Text = "прашање број 12!";
            }
            else if (i == 13)
            {
                lblPrasanje.Text = "прашање број 13!";
            }
            else if (i == 14)
            {
                lblPrasanje.Text = "прашање број 14!";
            }
            else if (i == 15)
            {
                lblPrasanje.Text = "прашање број 15!";
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
            player.Stop();
        }

        private void Status_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();

        }

        
    }
}
