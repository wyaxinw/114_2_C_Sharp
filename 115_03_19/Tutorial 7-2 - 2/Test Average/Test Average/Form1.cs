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
using System.Windows.Forms.VisualStyles;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Average 方法接受一個 int 陣列作為參數
        // 並回傳該陣列中數值的平均值。
        private double Average(int[] sArray)
        {
            int total = 0;
            for (int i = 0; i < sArray.Length; i++)
            {
                total += sArray[i];
            }
            return (double)total / sArray.Length;
        }

        // Highest 方法接受一個 int 陣列作為參數
        // 並回傳該陣列中的最大值。
        private int Highest(int[] sArray)
        {
          int highScore = sArray[0];
            for (int i = 1; i < sArray.Length; i++)
            {
                if (sArray[i] > highScore)
                {
                    highScore = sArray[i];
                }
            }
            return highScore;
        }

        // Lowest 方法接受一個 int 陣列作為參數
        // 並回傳該陣列中的最小值。
        private int Lowest(int[]sArray, int count)
        {
          int lowScore = sArray[0];
            for (int i = 1; i < sArray.Length; i++)
            {
                if (sArray[i] < lowScore)
                {
                    lowScore = sArray[i];
                }
            }
            return lowScore;
        }

        private int geFileCount()
        {
            int count = 0;
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("TestScores.txt");
                while (!inputFile.EndOfStream)
                {
                    inputFile.ReadLine();
                    count++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show(ex.Message);
            }
            return count;
        }
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            //int size = geFileCount();
            int[] scores = new int[getFilileScoreCount()];
            StreamReader inputFile;
            int index = 0; // declare and initialize index

            try
            {
                inputFile = File.OpenText("TestScores.txt");

                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    scores[index]  =  int.Parse(inputFile.ReadLine());
                    index++;
                }
                inputFile.Close();

                testScoresListBox.Items.Add("學生人數: "+scores); 
                foreach (int score in scores)
                {

                    testScoresListBox.Items.Add(scores[val]);
                }
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show(ex.Message);
            }

            double averageScore = Average(scores);
            averageScoreLabel.Text = Average(scores).ToString("n1");
            highScoreLabel.Text = Highest(scores).ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
