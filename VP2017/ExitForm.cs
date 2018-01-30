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
    public partial class ExitForm : Form
    {
        string path = "$2,000 Lose - Who Wants to Be a Millionaire- (online-audio-converter.com).wav";
        SoundPlayer player;
        int brojPrasanje;
        string correct;
        public ExitForm(int brojPrasanje, string corrAnswer)
        {
            InitializeComponent();
            player = new SoundPlayer(path);
            this.brojPrasanje = brojPrasanje;
            this.correct = corrAnswer;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void FormFinalAnswer_Load(object sender, EventArgs e)
        {
            tbTocenOdgovor.Text = correct;
            player.Play();
        }

        private void FormFinalAnswer_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Stop();
        }

        private void tbOtkaziSe_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
