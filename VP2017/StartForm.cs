﻿using System;
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
        SoundPlayer player;
        public StartForm()
        {
            InitializeComponent();
            //BackgroundImageLayout = ImageLayout.Stretch;
            player = new SoundPlayer(path);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Stop();
            Form1 form1 = new Form1();
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
            }
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (btnPlay.Font.Size > 20)
            {
                Font f = new Font(btnPlay.Font.FontFamily, btnPlay.Font.Size - 2, FontStyle.Bold);
                btnInstructions.Font = f;
                btnPlay.Font = f;
            }          
        }
    }
}
