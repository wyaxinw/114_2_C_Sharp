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
            if (sArray == null || sArray.Length == 0) return 0.0;
            var q = from s in sArray
                    select s;
            return q.Average();
        }

        // Highest 方法接受一個 int 陣列作為參數
        // 並回傳該陣列中的最大值。
        private int Highest(int[] sArray)
        {
            if (sArray == null || sArray.Length == 0) return 0;
            var q = from s in sArray
                    select s;
            return q.Max();
        }

        // Lowest 方法接受一個 int 陣列作為參數
        // 並回傳該陣列中的最小值。
        private int Lowest(int[] sArray)
        {
            if (sArray == null || sArray.Length == 0) return 0;
            var q = from s in sArray
                    select s;
            return q.Min();
        }

        private int getFileCount()
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
            int size = getFileCount();
            if (size == 0)
            {
                MessageBox.Show("沒有成績可讀取。", "資訊");
                return;
            }

            int[] scores = new int[size];
            StreamReader inputFile;
            int index = 0; // declare and initialize index

            try
            {
                inputFile = File.OpenText("TestScores.txt");

                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }
                inputFile.Close();

                testScoresListBox.Items.Clear();
                testScoresListBox.Items.Add("學生人數: " + scores.Length);

                var q = from s in scores
                        select s;

                foreach (int score in q)
                {
                    testScoresListBox.Items.Add(score);
                }
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show(ex.Message);
                return;
            }

            // 使用已定義的方法（內部使用 LINQ 查詢語法）計算並顯示統計
            averageScoreLabel.Text = Average(scores).ToString("n1");
            highScoreLabel.Text = Highest(scores).ToString();
            lowScoreLabel.Text = Lowest(scores).ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
