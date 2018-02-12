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
    public partial class WinnerForm : Form
    {
        string path = "$8,000 Win - Who Wants to Be a Millionaire- (online-audio-converter.com).wav";
        SoundPlayer player;
        public WinnerForm(string username)
        {
            InitializeComponent();
            if (!String.IsNullOrEmpty(username))
            addPoints(username);
            player = new SoundPlayer(path);
            player.Play();
        }
        public void addPoints(string user)
        {

            SqlConnection connection = new SqlConnection();
            string path = (Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DataBase\Questions.mdf;Integrated Security=True;User Instance=True";
            string s = "INSERT INTO Points(points, name, date) VALUES(@p, @n, @d)";
            connection.Open();

            using (var cmd = new SqlCommand(s, connection))
            {
                cmd.Parameters.AddWithValue("@p", 15);
                cmd.Parameters.AddWithValue("@n", user);
                cmd.Parameters.AddWithValue("@d", DateTime.Now);

                cmd.ExecuteNonQuery();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Close();
        }
    }
}
