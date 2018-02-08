using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VP2017
{
    public partial class InstructionsForm : Form
    {
        public InstructionsForm()
        {
            //label1.MaximumSize.Height = screen.Height;
            //label1.MaximumSize.Width = screen.Width;
            InitializeComponent();

            Rectangle screen = Screen.PrimaryScreen.Bounds;
            label1.Height = screen.Height - 20;
            label1.Width = (screen.Width / 4) * 3;
            Point quitButtonLocation = new Point(
                (screen.Width - button1.Width - 50),
               50);
            button1.Location = quitButtonLocation;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InstructionsForm_Load(object sender, EventArgs e)
        {
            
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

    }
}
