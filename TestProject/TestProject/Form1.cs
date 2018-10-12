using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace TestProject
{
    public partial class Form1 : Form
    {

        private string connectionSql = @"Data Source=.\SQLEXPRESS;Initial Catalog=Text;Integrated Security=True";
        private string nameFile;
        private string allText;
        private string redactor = "\'\'";
        List<int> counter = new List<int>();
        List<string> allSentence = new List<string>();
        List<string> sentenceWord = new List<string>();
        int k, i;        

        public Form1()
        {
            InitializeComponent();
            string sqlRead = "SELECT * FROM SaveText";
            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlRead, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        object text = reader["Sentence"];
                        Sentence.Text += text.ToString() + Environment.NewLine + Environment.NewLine;
                    }

                    reader.Close();
                }

            }
        }
        
        private void OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            nameFile = openFileDialog1.FileName;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (nameFile != null)
            {
                try
                {

                    allText = File.ReadAllText(nameFile);
                    k = 0;
                    for (i = 0; i < allText.Length; i++)
                    {
                        if (i == 0)
                        {
                            allSentence.Add("");
                            allSentence[k] += allText[i].ToString();
                        }
                        else if (allText[i] == '.' || allText[i] == '!' || allText[i] == '?')
                        {
                            allSentence[k] += allText[i].ToString();
                            allSentence.Add("");
                            k++;
                        }
                        else if (allText[i] == '\'')
                        {
                            allSentence[k] += redactor;
                        }
                        else
                        {
                            allSentence[k] += allText[i].ToString();
                        }
                    }

                    if (String.IsNullOrWhiteSpace(Word.Text))
                        MessageBox.Show("Enter word!");
                    else
                    {
                        foreach(string rez in allSentence)
                        {
                            Regex r = new Regex(Word.Text + @"\W", RegexOptions.IgnoreCase);
                            MatchCollection m = r.Matches(rez);
                            if(m.Count > 0)
                            {
                                sentenceWord.Add(rez);
                                counter.Add(m.Count);
                            }
                        }
                    }
                    for (i = 0; i < sentenceWord.Count; i++)
                    {
                        string rez = sentenceWord[i];
                        string sqlAdd = String.Format($"INSERT INTO SaveText (Sentence, Count) VALUES ('{ReverseString(rez)}', '{counter[i]}')");
                        using (SqlConnection connection = new SqlConnection(connectionSql))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(sqlAdd, connection);
                            command.ExecuteNonQuery();
                        }
                        Sentence.Text += ReverseString(rez) + Environment.NewLine + Environment.NewLine;
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("File not selected");
            }

            allSentence.RemoveRange(0, allSentence.Count);
            sentenceWord.RemoveRange(0, sentenceWord.Count);
            Word.Text = "";
            nameFile = null;

        }

        private void Sentence_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
            else
                e.Handled = true;
        }

        private void Word_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я' || c == 'ё' || c == 'Ё' || c == 'ї' || c == 'Ї' || c == ' ' || c == 'і' || c == 'І' || c == (char)Keys.Enter;
        }

        private void deleteS_Click(object sender, EventArgs e)
        {
            string sqlDelete = String.Format("DELETE  FROM SaveText");
            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlDelete, connection);
                command.ExecuteNonQuery();
            }
            Sentence.Text = "";
        }

        public string ReverseString(string reserv)
        {
            char[] arr = reserv.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
