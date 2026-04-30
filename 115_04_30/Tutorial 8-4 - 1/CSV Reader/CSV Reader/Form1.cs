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
            // 清除先前顯示的資料
            averagesListBox.Items.Clear();

            try
            {
                // 定義欄位分隔符（逗號）
                char[] delim = { ',' };

                // 依照新的檔案格式：班級,學號,姓名,score1,score2,score3,score4,score5
                // 每一行應該有 8 個欄位
                // 為避免中文亂碼，先嘗試依 BOM 判定編碼；若無 BOM，則使用系統預設編碼（通常為 Big5/ANSI）
                using (FileStream fs = File.OpenRead("scores.csv"))
                {
                    Encoding fileEncoding = Encoding.Default; // 預設為系統 ANSI

                    // 讀取前 4 個位元組以判別常見的 BOM
                    byte[] bom = new byte[4];
                    int n = fs.Read(bom, 0, 4);

                    if (n >= 3 && bom[0] == 0xEF && bom[1] == 0xBB && bom[2] == 0xBF)
                    {
                        // UTF-8 BOM
                        fileEncoding = Encoding.UTF8;
                    }
                    else if (n >= 2 && bom[0] == 0xFF && bom[1] == 0xFE)
                    {
                        // UTF-16 LE
                        fileEncoding = Encoding.Unicode;
                    }
                    else if (n >= 2 && bom[0] == 0xFE && bom[1] == 0xFF)
                    {
                        // UTF-16 BE
                        fileEncoding = Encoding.BigEndianUnicode;
                    }

                    // 將檔案位置復原到開頭，之後交由 StreamReader 讀取
                    fs.Seek(0, SeekOrigin.Begin);

                    using (StreamReader inputFile = new StreamReader(fs, fileEncoding))
                    {
                        string line;

                        // 加入標題列，方便使用者辨識欄位
                        averagesListBox.Items.Add("班級  學號  姓名  平均成績");

                        while (!inputFile.EndOfStream)
                        {
                            line = inputFile.ReadLine();
                          if (string.IsNullOrWhiteSpace(line))
                        {
                            // 跳過空白行
                            continue;
                        }

                        string[] fields = line.Split(delim);

                        if (fields.Length == 8)
                        {
                            // 讀取前 3 個欄位為  班級 / 學號 / 姓名
                            string className = fields[0].Trim();
                            string studentId = fields[1].Trim();
                            string studentName = fields[2].Trim();

                            int total = 0;
                            bool parseError = false;

                            // 後面 5 個欄位為成績，計算總和
                            for (int i = 3; i < 8; i++)
                            {
                                int score;
                                if (int.TryParse(fields[i].Trim(), out score))
                                {
                                    total += score;
                                }
                                else
                                {
                                    // 若有任何分數欄位無法解析為整數，則記錄錯誤並跳過該筆資料
                                    parseError = true;
                                    break;
                                }
                            }

                            if (parseError)
                            {
                                MessageBox.Show("成績欄位格式錯誤: " + line);
                                continue;
                            }

                            // 計算平均（五科），以小數點兩位顯示
                            double average = total / 5.0;

                            // 依輸出格式：班級 學號 姓名 平均成績
                            string output = string.Format("{0}  {1}  {2}  {3:F2}", className, studentId, studentName, average);
                            averagesListBox.Items.Add(output);
                        }
                        else
                        {
                            // 欄位數不符預期時顯示錯誤訊息
                            MessageBox.Show("資料格式錯誤(欄位數量不正確): " + line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 讀取檔案或解析過程發生例外，顯示錯誤訊息
                MessageBox.Show("讀取 CSV 檔案時發生錯誤: " + ex.Message);
            }
        }
    }
}
        