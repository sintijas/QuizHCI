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
    public partial class StartForm : Form
    {
        string path = "Theme_Main_-_Who_Wants_to_Be_a_Millionaire-.wav";
        string username;
        SoundPlayer player;
        public StartForm()
        {
            InitializeComponent();
            //BackgroundImageLayout = ImageLayout.Stretch;
            player = new SoundPlayer(path);
            btnPlay.FlatAppearance.BorderSize = 5;
            btnInstructions.FlatAppearance.BorderSize = 5;
            btnZoomIn.FlatAppearance.BorderSize = 4;
            btnZoomOut.FlatAppearance.BorderSize = 4;
            label1.Text = "";
            label1.Visible = false;


            Rectangle screen = Screen.PrimaryScreen.Bounds;
            Point groupboxLocation = new Point(
                 (screen.Width - panel1.Width) / 2,
                ((screen.Height - panel1.Height) / 4)*3);
            panel1.Location = groupboxLocation;

            Point quitButtonLocation = new Point(
                 (screen.Width - quitButton.Width - 50),
                50);
            quitButton.Location = quitButtonLocation;

            Point logoPictureBoxLocation = new Point(
                 (screen.Width - logoPictureBox.Width) / 2,
                10);
            logoPictureBox.Location = logoPictureBoxLocation;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Stop();
            Form1 form1 = new Form1(username);
            this.Visible = false;
            form1.ShowDialog();
            if (form1.isClosed)
            {
                this.Visible = true;
                player.Dispose();
                player = new SoundPlayer(path);
                player.PlayLooping();
            }

        }

        private void StartForm_Load(object sender, EventArgs e)
        {

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            player.PlayLooping();

        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Stop();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            InstructionsForm form = new InstructionsForm();
            form.ShowDialog();
        }


        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (btnPlay.Font.Size < 48)
            {
                Font f = new Font(btnPlay.Font.FontFamily, btnPlay.Font.Size + 2, FontStyle.Bold);
                btnInstructions.Font = f;
                btnPlay.Font = f;
                button1.Font = f;
                quitButton.Font = f;
                if (!String.IsNullOrEmpty(name.Text))
                    name.Font = f;
            }
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (btnPlay.Font.Size > 20)
            {
                Font f = new Font(btnPlay.Font.FontFamily, btnPlay.Font.Size - 2, FontStyle.Bold);
                btnInstructions.Font = f;
                btnPlay.Font = f;
                button1.Font = f;
                quitButton.Font = f;
                if (!String.IsNullOrEmpty(name.Text))
                    name.Font = f;
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.username = name.Text;
            this.name.Visible = false;
            this.button1.Visible = false;
            this.label1.Text = "Здраво " + this.username; 
            this.label1.Visible = true;
        }

        private void highScoresButton_Click(object sender, EventArgs e)
        {
            HighScoresForm form = new HighScoresForm();
            form.ShowDialog();
        }

      
    }
}
