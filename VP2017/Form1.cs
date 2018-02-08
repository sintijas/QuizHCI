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
    public partial class Form1 : Form
    {
        #region Variables
        string correctAnswer;
        int i;
        List<int> Pominati;
        int id;
        int corrButton;
        List<int> Answers;
        int SecondAnswer5050;
        bool Clicked_5050;
        public bool isClosed;
        List<int> VrednostiABCD;
        Random random;
        string path = "1001000 music.wav";
        SoundPlayer play;
        #endregion

        #region Constructor_Form1, Load method and Close method
        public Form1()
        {
            InitializeComponent();
            corrButton = 0;
            //BackgroundImageLayout = ImageLayout.Stretch;
            correctAnswer = "";
            i = 1;
            Pominati = new List<int>();
            id = 0;
            Answers = new List<int>();
            SecondAnswer5050 = 0;
            Clicked_5050 = false;
            //Clicked_audience = false;
            //Clicked_phoneFriend = false;
            isClosed = false;
            VrednostiABCD = new List<int>();
            random = new Random();
            play = new SoundPlayer(path);

            btn5050.FlatAppearance.BorderSize = 5;
            btnOtkaziSe.FlatAppearance.BorderSize = 5;
            btnZoomIn.FlatAppearance.BorderSize = 3;
            btnZoomOut.FlatAppearance.BorderSize = 3;
            tbBrojPrasanje.ForeColor = Color.Black;


            Rectangle screen = Screen.PrimaryScreen.Bounds;
            Point panel1Location = new Point(
                 (screen.Width - panel1.Width) / 2,
                (screen.Height - panel1.Height) / 2);
            panel1.Location = panel1Location;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //pb5050.SizeMode = PictureBoxSizeMode.StretchImage;
            //pb5050.Image = imageList1.Images[16];
            //pbAskTheAudience.SizeMode = PictureBoxSizeMode.StretchImage;
            //pbAskTheAudience.Image = imageList1.Images[18];
            //pbCall.SizeMode = PictureBoxSizeMode.StretchImage;
            //pbCall.Image = imageList1.Images[25];
            //pbOtkaziSe.SizeMode = PictureBoxSizeMode.StretchImage;
            //pbOtkaziSe.Image = imageList1.Images[28];
            //pbQuestions.SizeMode = PictureBoxSizeMode.StretchImage;
            //pbQuestions.Image = imageList1.Images[27];
            PopolniPrasanje();
            //dodadeno!!!
            play.PlayLooping();

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //dodadeno!!!
            play.Stop();
            isClosed = true;
        }
        #endregion

        #region Functions

        private void PopolniPrasanje()
        {
            //dodadeno!!!
            play.PlayLooping();
            tbBrojPrasanje.Text = "Прашање: " + i + "/15";
            EnableButtons();
            if (i <= 5)
            {
                PopolniPrasanje1();
            }
            else if (i <= 10)
            {
                if (i == 6)
                {
                    Pominati = new List<int>();
                }
                PopolniPrasanje2();
            }
            else if (i <= 15)
            {
                if (i == 11)
                {
                    Pominati = new List<int>();
                }

                PopolniPrasanje3();
            }
        }
        private void GenerateTryBlockForQuestions(SqlConnection connection, SqlCommand cmd, int k)
        {
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (i <= 5)
            {

                while (sdr.Read())
                {
                    id = (int)sdr["questID"];
                    tbQuestion2.Text = sdr["quest"].ToString();
                    btnAnswerA.Text = sdr["a"].ToString();
                    btnAnswerB.Text = sdr["b"].ToString();
                    btnAnswerC.Text = sdr["c"].ToString();
                    btnAnswerD.Text = sdr["d"].ToString();
                    correctAnswer = sdr["answ"].ToString();
                    if (id == k)
                    {
                        break;
                    }

                }
            }
            else
            {
                while (sdr.Read())
                {
                    id = (int)sdr["quest_id"];
                    tbQuestion2.Text = sdr["quest"].ToString();
                    btnAnswerA.Text = sdr["a"].ToString();
                    btnAnswerB.Text = sdr["b"].ToString();
                    btnAnswerC.Text = sdr["c"].ToString();
                    btnAnswerD.Text = sdr["d"].ToString();
                    correctAnswer = sdr["answ"].ToString();
                    if (id == k)
                    {
                        break;
                    }

                }
            }
        }
        private int GenerateQuestionNumber()
        {
            int k = 0;
            int lowestQuestionID = 0;
            int highestQuestionID = 0;
            if (i <= 5)
            {
                lowestQuestionID = 6;
                highestQuestionID = 38;
            }
            else if (i <= 10)
            {
                lowestQuestionID = 1;
                highestQuestionID = 28;
            }
            else if (i <= 15)
            {
                lowestQuestionID = 1;
                highestQuestionID = 18;
            }
            k = random.Next(lowestQuestionID, highestQuestionID);
            while (Pominati.Contains(k))
            {
                k = random.Next(lowestQuestionID, highestQuestionID);
            }
            Pominati.Add(k);
            return k;
        }
        private void PopolniPrasanje1()
        {
            string sqlStr = "SELECT * FROM Level1";
            SqlConnection connection = new SqlConnection();
            string path = (Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DataBase\Questions.mdf;Integrated Security=True;User Instance=True";
            int k = GenerateQuestionNumber();
            SqlCommand cmd = new SqlCommand(sqlStr, connection);
            try
            {
                GenerateTryBlockForQuestions(connection, cmd, k);
            }
            catch (Exception e)
            {
                tbQuestion2.Text = e.Message;
            }
            finally
            {
                connection.Close();
            }
        }
        private void PopolniPrasanje2()
        {
            string sqlStr = "SELECT * FROM Level2";
            SqlConnection connection = new SqlConnection();
            string path = (Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DataBase\Questions.mdf;Integrated Security=True;User Instance=True";
            int k = GenerateQuestionNumber();
            SqlCommand cmd = new SqlCommand(sqlStr, connection);
            try
            {
                GenerateTryBlockForQuestions(connection, cmd, k);
            }
            catch (Exception e)
            {
                tbQuestion2.Text = e.Message;
            }
            finally
            {
                connection.Close();
            }
        }
        private void PopolniPrasanje3()
        {
            string sqlStr = "SELECT * FROM Level3";
            SqlConnection connection = new SqlConnection();
            string path = (Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DataBase\Questions.mdf;Integrated Security=True;User Instance=True";
            int k = GenerateQuestionNumber();
            SqlCommand cmd = new SqlCommand(sqlStr, connection);
            try
            {
                GenerateTryBlockForQuestions(connection, cmd, k);
            }
            catch (Exception e)
            {
                tbQuestion2.Text = e.Message;
            }
            finally
            {
                connection.Close();
            }
        }
        private void WrongAnswer()
        {
            WrongAnswerForm wrongform = new WrongAnswerForm(i, correctAnswer);
            wrongform.ShowDialog();
            isClosed = true;
            this.Close();
        }
        private void Find5050(string correctAnswer)
        {
            Answers = new List<int>();
            Answers.Add(1);
            Answers.Add(2);
            Answers.Add(3);
            Answers.Add(4);
            if (correctAnswer == btnAnswerA.Text) corrButton = 1;
            else if (correctAnswer == btnAnswerB.Text) corrButton = 2;
            else if (correctAnswer == btnAnswerC.Text) corrButton = 3;
            else if (correctAnswer == btnAnswerD.Text) corrButton = 4;
            Answers.RemoveAt(corrButton - 1);
            SecondAnswer5050 = random.Next(Answers.Count);
            for (int l = 0; l < Answers.Count; l++)
            {
                if (SecondAnswer5050 == l)
                {
                    SecondAnswer5050 = Answers[l];
                    break;
                }
            }
            HelperFunctFor5050(corrButton, SecondAnswer5050);
        }
        private void HelperFunctFor5050(int corrButton, int SecondAnswer5050)
        {
            if (corrButton != 1 && SecondAnswer5050 != 1)
            {
                btnAnswerA.Text = "";
                btnAnswerA.Enabled = false;
            }
            if (corrButton != 2 && SecondAnswer5050 != 2)
            {
                btnAnswerB.Text = "";
                btnAnswerB.Enabled = false;
            }
            if (corrButton != 3 && SecondAnswer5050 != 3)
            {
                btnAnswerC.Text = "";
                btnAnswerC.Enabled = false;
            }
            if (corrButton != 4 && SecondAnswer5050 != 4)
            {
                btnAnswerD.Text = "";
                btnAnswerD.Enabled = false;
            }
        }
        private void EnableButtons()
        {
            btnAnswerA.Enabled = true;
            btnAnswerB.Enabled = true;
            btnAnswerC.Enabled = true;
            btnAnswerD.Enabled = true;
        }

        #endregion

        #region Buttons_Click

        #region A_B_C_D_buttons click
        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            play.Stop();
            btnAnswerA.ForeColor = Color.Orange;
            //FormFinalAnswer form = new FormFinalAnswer(i);
            if (true)
            {
                if (btnAnswerA.Text == correctAnswer)
                {
                    btnAnswerA.ForeColor = Color.Green;
                    if (i == 15)
                    {
                        WinnerForm winner = new WinnerForm();
                        winner.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Status form1 = new Status(i);
                        form1.ShowDialog();
                        i++;
                        PopolniPrasanje();
                    }
                }
                else
                {
                    WrongAnswer();
                }
            }
            else
            {
                play.PlayLooping();
            }
            btnAnswerA.ForeColor = Color.Black;
        }

        private void btnAnswerB_Click(object sender, EventArgs e)
        {
            play.Stop();
            btnAnswerB.ForeColor = Color.Orange;
            //FormFinalAnswer form = new FormFinalAnswer(i);
            if (true)
            {
                if (btnAnswerB.Text == correctAnswer)
                {
                    btnAnswerB.ForeColor = Color.Green;
                    if (i == 15)
                    {
                        WinnerForm winner = new WinnerForm();
                        winner.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Status form1 = new Status(i);
                        form1.ShowDialog();
                        i++;
                        PopolniPrasanje();
                    }
                }
                else
                {
                    WrongAnswer();
                }
            }
            else
            {
                play.PlayLooping();
            }
            btnAnswerB.ForeColor = Color.Black;
        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
            play.Stop();
            btnAnswerC.ForeColor = Color.Orange;
            //FormFinalAnswer form = new FormFinalAnswer(i);
            if (true)
            {
                if (btnAnswerC.Text == correctAnswer)
                {
                    btnAnswerC.ForeColor = Color.Green;
                    if (i == 15)
                    {
                        WinnerForm winner = new WinnerForm();
                        winner.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Status form1 = new Status(i);
                        form1.ShowDialog();
                        i++;
                        PopolniPrasanje();
                    }
                }
                else
                {
                    WrongAnswer();
                }
            }
            else
            {
                play.PlayLooping();
            }
            btnAnswerC.ForeColor = Color.Black;
        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            play.Stop();
            btnAnswerD.ForeColor = Color.Orange;
            //FormFinalAnswer form = new FormFinalAnswer(i);
            if (true)
            {
                if (btnAnswerD.Text == correctAnswer)
                {
                    btnAnswerD.ForeColor = Color.Green;
                    if (i == 15)
                    {
                        WinnerForm winner = new WinnerForm();
                        winner.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Status form1 = new Status(i);
                        form1.ShowDialog();
                        i++;
                        PopolniPrasanje();
                    }
                }
                else
                {
                    WrongAnswer();
                }
            }
            else
            {
                play.PlayLooping();
            }
            btnAnswerD.ForeColor = Color.Black;
        }
        #endregion

        #endregion

        private void btn5050_Click(object sender, EventArgs e)
        {
            if (!Clicked_5050)
            {
                Find5050(correctAnswer);
                Clicked_5050 = true;
            }
            btn5050.Enabled = false;
        }

        private void btnOtkaziSe_Click(object sender, EventArgs e)
        {
            ExitForm form = new ExitForm(i, correctAnswer);
            form.ShowDialog();
            isClosed = true;
            this.Close();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
                Font f = new Font(btn5050.Font.FontFamily, btn5050.Font.Size + 2);
                btn5050.Font = f;

                f = new Font(btnOtkaziSe.Font.FontFamily, btnOtkaziSe.Font.Size + 2);
                btnOtkaziSe.Font = f;
                f = new Font(btnAnswerA.Font.FontFamily, btnAnswerA.Font.Size + 2, FontStyle.Bold);
                btnAnswerA.Font = f;
                btnAnswerB.Font = f;
                btnAnswerC.Font = f;
                btnAnswerD.Font = f;
                f = new Font(tbQuestion2.Font.FontFamily, tbQuestion2.Font.Size + 2);
                tbQuestion2.Font = f;
                
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (btnAnswerA.Font.Size >= 8)
            {
                Font f = new Font(btn5050.Font.FontFamily, btn5050.Font.Size - 2);
                btn5050.Font = f;
                f = new Font(btnOtkaziSe.Font.FontFamily, btnOtkaziSe.Font.Size - 2);
                btnOtkaziSe.Font = f;
                f = new Font(btnAnswerA.Font.FontFamily, btnAnswerA.Font.Size - 2, FontStyle.Bold);
                btnAnswerA.Font = f;
                btnAnswerB.Font = f;
                btnAnswerC.Font = f;
                btnAnswerD.Font = f;
                f = new Font(tbQuestion2.Font.FontFamily, tbQuestion2.Font.Size - 2);
                tbQuestion2.Font = f;
            }
                
        }




    }
}
