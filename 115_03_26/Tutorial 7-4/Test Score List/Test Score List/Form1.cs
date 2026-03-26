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
        public Form1()
        {
            InitializeComponent();
        }





        private void getScoresButton_Click(object sender, EventArgs e)
        {
            string filePath = "test_scores.txt"; // 檔案路徑
            try
            {
                // 開啟檔案以讀取分數
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    // 逐行讀取檔案直到結尾
                    while (!reader.EndOfStream)
                    {
                        //將每行文字轉換為整數並加入List
                        scoresList..Add(int.Parse(reader.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                // 若讀取檔案過程中發生任何錯誤，顯示錯誤訊息
                MessageBox.Show("讀取分數檔案時發生錯誤: " + ex.Message);
            }
        }

        //Display Scores : 將 List 中的分數逐一加入 ListBox 中顯示
        private void DisplayScores(List<int> scoresList)
        {
           foreach (int score in scoresList)
           {
               testScoresListBox.Items.Add(score.ToString());
            }

        // 搜尋按鈕事件處理
        // 使用者在 searchTextBox 輸入欲搜尋的分數，按下「搜尋」後會在 testScoresListBox 中搜尋
        // 若找到，於 searchResultLabel 顯示所在位置（以 1 為起始）；若找不到則顯示「分數不存在」
        private void searchButton_Click(object sender, EventArgs e)
        {
            // 取得並嘗試解析使用者輸入的分數
            string input = searchTextBox.Text.Trim();
            int targetScore;
            if (!int.TryParse(input, out targetScore))
            {
                // 無法解析為整數則視為搜尋失敗
                searchResultLabel.Text = "分數不存在";
                return;
            }

            // 在 ListBox 中逐項比對（ListBox 內容預期為分數的文字表示）
            for (int i = 0; i < testScoresListBox.Items.Count; i++)
            {
                int itemScore;
                if (int.TryParse(testScoresListBox.Items[i].ToString(), out itemScore))
                {
                    if (itemScore == targetScore)
                    {
                        // 找到時顯示位置（以 1 為起始）
                        searchResultLabel.Text = (i + 1).ToString();
                        return;
                    }
                }
            }

            // 若整個清單都沒有找到，顯示「分數不存在」
            searchResultLabel.Text = "分數不存在";
        }
    }
}
