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

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        // 儲存讀取到的學號清單（與 scoresList 對應）
        private List<string> studentIds = new List<string>();
        // 儲存最後一次顯示在 ListBox 的字串，供搜尋使用
        private List<string> lastScores = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        

       

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // To hold the average score
            int numAboveAverage;    // Number of above average scores
            int numBelowAverage;    // Number of below average scores

            // Create a List to hold the scores.
            List<int> scoresList = new List<int>();

            // Read the scores from the file into the List.
            ReadScores(scoresList);

            // Display the scores.
            DisplayScores(scoresList);

            // Display the average score.
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // Display the number of above average scores.
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // Display the number of below average scores.
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        // 以繁體中文註解：
        // ReadScores 方法會從應用程式執行目錄下的 "TestScores.txt" 檔案讀取資料。
        // 每一列的格式預期為："學號" 空白 "分數"，例如：A114221055 54
        // 讀取時會解析學號與分數，將學號加入 studentIds，分數加入傳入的 scoresList。
        // 若找不到檔案或某列格式不正確，會顯示錯誤訊息並略過該列。
        private void ReadScores(List<int> scoresList)
        {
            // 清除舊資料
            scoresList.Clear();
            studentIds.Clear();

            string fileName = Path.Combine(Application.StartupPath, "TestScores.txt");
            if (!File.Exists(fileName))
            {
                MessageBox.Show("找不到檔案：" + fileName, "讀取錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Trim();
                        if (string.IsNullOrEmpty(line))
                            continue;

                        // 以空白拆分，允許多個空白或製表符
                        string[] parts = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length < 2)
                        {
                            // 格式不符，略過
                            continue;
                        }

                        string id = parts[0];
                        int score;
                        if (int.TryParse(parts[1], out score))
                        {
                            studentIds.Add(id);
                            scoresList.Add(score);
                        }
                        else
                        {
                            // 分數無法解析，略過
                            continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取檔案時發生錯誤：" + ex.Message, "讀取錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 以繁體中文註解：
        // DisplayScores 方法會清空 ListBox，並顯示每一筆資料為 "學號 分數" 的格式。
        private void DisplayScores(List<int> scoresList)
        {
            testScoresListBox.Items.Clear();
            int count = Math.Min(studentIds.Count, scoresList.Count);
            lastScores.Clear();
            for (int i = 0; i < count; i++)
            {
                string display = string.Format("{0} {1}", studentIds[i], scoresList[i]);
                testScoresListBox.Items.Add(display);
                lastScores.Add(display);
            }
        }

        // 以繁體中文註解：
        // 搜尋按鈕事件處理，會搜尋 lastScores 中所有符合搜尋文字的項目（不使用 lambda，使用 LINQ 查詢式）
        // 若搜尋欄為空字串，則會顯示全部項目。
        private void searchButton_Click(object sender, EventArgs e)
        {
            string key = string.Empty;
            if (this.Controls.ContainsKey("searchTextBox"))
            {
                var tb = this.Controls["searchTextBox"] as TextBox;
                if (tb != null)
                    key = tb.Text.Trim();
            }

            testScoresListBox.Items.Clear();

            if (string.IsNullOrEmpty(key))
            {
                // 顯示全部
                foreach (var item in lastScores)
                    testScoresListBox.Items.Add(item);
                return;
            }

            // 使用 LINQ 查詢式搜尋包含 key 的項目（不使用 lambda）
            var query = from s in lastScores
                        where s.IndexOf(key, StringComparison.CurrentCultureIgnoreCase) >= 0
                        select s;

            foreach (var item in query)
            {
                testScoresListBox.Items.Add(item);
            }
        }

        // 計算平均分數，若沒有分數則回傳 0
        private double Average(List<int> scoresList)
        {
            // 使用 LINQ 查詢語法計算平均值（避免使用 lambda）
            if (scoresList == null || scoresList.Count == 0)
                return 0.0;

            var query = from s in scoresList
                        select s;
            // 使用 Enumerable.Average 擴充方法，但查詢本身未使用 lambda
            return query.Average();
        }

        // 計算高於平均分數的人數
        private int AboveAverage(List<int> scoresList, double average)
        {
            // 使用 LINQ 查詢語法來過濾並計數高於平均的分數
            if (scoresList == null)
                return 0;

            var query = from s in scoresList
                        where s > average
                        select s;
            return query.Count();
        }

        // 計算低於平均分數的人數（明確不包含等於平均的）
        private int BelowAverage(List<int> scoresList)
        {
            // 使用 LINQ 查詢語法計算低於平均的人數
            if (scoresList == null)
                return 0;

            double avg = Average(scoresList);
            var query = from s in scoresList
                        where s < avg
                        select s;
            return query.Count();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
