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
    public partial class ExitForm : Form
    {
        string path = "$2,000 Lose - Who Wants to Be a Millionaire- (online-audio-converter.com).wav";
        SoundPlayer player;
        int brojPrasanje;
        string correct;
        public ExitForm(int brojPrasanje, string username, string corrAnswer)
        {
            InitializeComponent();
            player = new SoundPlayer(path);
            this.brojPrasanje = brojPrasanje;
            this.correct = corrAnswer;
            if (!String.IsNullOrEmpty(username))
                addPoints(brojPrasanje, username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private void btnNe_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void FormFinalAnswer_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
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
