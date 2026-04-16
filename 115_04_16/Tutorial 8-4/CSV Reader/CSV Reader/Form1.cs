using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            { 
                StreamReader inputFile;

                using (inputFile = File.OpenText("Grades.csv"))
                {
                    string line;
                    while (!inputFile.EndOfStream)
                    {
                        line= inputFile.ReadLine();
                        string[] fields = line.Split(',');
                       if(fields.Length >= 2)
                        {
                            string name = fields[0];
                            if (double.TryParse(fields[1], out double score))
                            {
                                averagesListBox.Items.Add($"{name}: {score}");
                            }
                            else
                            {
                                averagesListBox.Items.Add($"{name}: Invalid score");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
