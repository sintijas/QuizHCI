using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
using System.IO;
namespace VP2017
{
    public partial class WrongAnswerForm : Form
    {

        string path = "$2,000 Lose - Who Wants to Be a Millionaire- (online-audio-converter.com).wav";
        SoundPlayer player1;
        int brPrasanje;
        string correct;
        public WrongAnswerForm(int brojPrasanje, string username, string corrAnswer)
        {
            InitializeComponent();
            player1 = new SoundPlayer(path);
            this.brPrasanje = brojPrasanje;
            this.correct = corrAnswer;
            if (!String.IsNullOrEmpty(username))
            addPoints(brPrasanje, username);
            player1.Play();
            timer1.Start();
        }
        public void addPoints(int i, string name)
        {

            SqlConnection connection = new SqlConnection();
            string path = (Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DataBase\Questions.mdf;Integrated Security=True;User Instance=True";
            string s = "INSERT INTO Points(points, name, date) VALUES(@p, @n, @d)";
            connection.Open();

            using (var cmd = new SqlCommand(s, connection))
            {
                cmd.Parameters.AddWithValue("@p", i - 1);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@d", DateTime.Now);

                cmd.ExecuteNonQuery();
            }
        }
        private void WrongAnswerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tbTocenOdgovor.Text = correct;
            //tbOsvoenaSuma.Text = string.Format("Освоена сума: {0:n0} денари",Fill());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player1.Stop();
            this.Close();
        }

        private void WrongAnswerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void tbOtkaziSe_Click(object sender, EventArgs e)
        {

        }

        
    }
}
