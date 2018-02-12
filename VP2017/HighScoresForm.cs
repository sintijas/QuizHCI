using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;
using System.Configuration;
using System.Configuration.Assemblies;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Web;
using System.IO;

namespace VP2017
{
    public partial class HighScoresForm : Form
    {
        List<int> scores;
        List<string> names;
        List<string> dates;

        public HighScoresForm()
        {
            InitializeComponent();
            scores = new List<int>();
            names = new List<string>();
            dates = new List<string>();

            Rectangle screen = Screen.PrimaryScreen.Bounds;
            Point quitButtonLocation = new Point(
                (screen.Width - quitButton.Width - 50),
               50);
            quitButton.Location = quitButtonLocation;

            Point tableLocation = new Point(
                 (screen.Width - tableLayoutPanel1.Width) / 2,
                (screen.Height - tableLayoutPanel1.Height) / 2);
            tableLayoutPanel1.Location = tableLocation;
        }

        private void HighScoresForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            PopolniTabela();
            PopolniLabel();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PopolniTabela() {
            string sqlStr = "SELECT * FROM Points ORDER BY points DESC";
            SqlConnection connection = new SqlConnection();
            string path = (Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DataBase\Questions.mdf;Integrated Security=True;User Instance=True";
            SqlCommand cmd = new SqlCommand(sqlStr, connection);
            try
            {
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string name = sdr["name"].ToString();
                    int points = (int)sdr["points"];
                    string date = sdr["date"].ToString();
                    try
                    {
                        names.Add(name);
                        scores.Add(points);
                        dates.Add(date);
                    }
                    catch
                    {
                        Console.WriteLine("Adding to lists failed");
                    }
                }

            }
            catch (Exception e)
            {
                label1.Text = e.Message;
            }
            finally
            {
                connection.Close();
            }
            
        }

        private void PopolniNames()
        {
            Label[] labelsName = new[] { label6, label7, label8, label9, label10 };
            int j = 0;
            if (labelsName.Length < 5)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    labelsName[j].Text = names[i];
                    j++;
                } 
            }
            if (labelsName.Length >= 5)
            {
                for (int i = 0; i < labelsName.Length; i++)
                {
                    labelsName[j].Text = names[i];
                    j++;
                } 
            }
            
 
        }

        private void PopolniScores()
        {
            Label[] labelsPoints = new[] { label11, label12, label13, label14, label15 };
            int j = 0;
            if (labelsPoints.Length < 5)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    labelsPoints[j].Text = scores[i].ToString();
                    j++;
                }
            }
            else
            {
                for (int i = 0; i < labelsPoints.Length; i++)
                {
                    labelsPoints[j].Text = scores[i].ToString();
                    j++;
                }
            }
           
          
        }

        private void PopolniDates()
        {
            Label[] labelsDates = new[] { label16, label17, label18, label19, label20 };
           
            int j = 0;
            if (labelsDates.Length < 5)
            {
                for (int i = 0; i < dates.Count; i++)
                {
                    labelsDates[j].Text = dates[i].ToString();
                    j++;
                }
            }
            else
            {
                for (int i = 0; i < labelsDates.Length; i++)
                {
                    labelsDates[j].Text = dates[i].ToString();
                    j++;
                }
            }
        }

        private void PopolniLabel()
        {
            PopolniNames();
            PopolniScores();
            PopolniDates();
        }
    }
}
