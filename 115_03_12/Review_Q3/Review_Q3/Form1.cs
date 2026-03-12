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
using System.Linq;
using System.Windows.Forms;

namespace Review_Q3
{

    public partial class Form1 : System.Windows.Forms.Form
    {
        // arrays to store numbers from file and generated numbers
        private int[] lotteryNumbers = new int[6];
        private int[] myNumbers = new int[6];
        private Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // btnLoad: open file and read lottery numbers, display in listBoxLottery
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "選擇開獎號碼檔案";
            ofd.Filter = "Text Files|*.txt|All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string content = sr.ReadToEnd();
                        // split by any non-digit character
                        var parts = System.Text.RegularExpressions.Regex.Split(content, "[^0-9]+");
                        var nums = parts.Where(p => !string.IsNullOrWhiteSpace(p)).Select(p => int.Parse(p)).ToList();

                        if (nums.Count < 6)
                        {
                            MessageBox.Show("檔案中未包含至少 6 個號碼。請選擇正確的開獎號碼檔案。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // take first 6 numbers
                        for (int i = 0; i < 6; i++)
                        {
                            lotteryNumbers[i] = nums[i];
                        }

                        // show in listBoxLottery
                        listBoxLottery.Items.Clear();
                        for (int i = 0; i < 6; i++)
                        {
                            listBoxLottery.Items.Add("號碼 " + (i + 1) + ": " + lotteryNumbers[i]);
                        }

                        // enable generate button
                        btnGenerate.Enabled = true;
                        labelResult.Text = "已讀取開獎號碼，請按「產生號碼」。";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取檔案時發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // btnGenerate: produce non-repeating random numbers, display, compare, show result
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // generate 6 unique numbers between 1 and 49
            int count = 0;
            while (count < 6)
            {
                int n = rng.Next(1, 50); // 1..49
                bool exists = false;
                for (int j = 0; j < count; j++)
                {
                    if (myNumbers[j] == n)
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    myNumbers[count] = n;
                    count++;
                }
            }

            // display generated numbers in lblNumbers
            for (int i = 0; i < 6; i++)
            {
                lblNumbers[i].Text = myNumbers[i].ToString();
            }

            // compare with lotteryNumbers
            int match = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (myNumbers[i] == lotteryNumbers[j])
                    {
                        match++;
                    }
                }
            }

            // determine prize
            string prize;
            switch (match)
            {
                case 6:
                    prize = "恭喜中一獎！(6 個號碼全中)";
                    break;
                case 5:
                    prize = "中二獎 (5 個號碼)";
                    break;
                case 4:
                    prize = "中三獎 (4 個號碼)";
                    break;
                case 3:
                    prize = "中四獎 (3 個號碼)";
                    break;
                default:
                    prize = "未中獎";
                    break;
            }

            labelResult.Text = "中獎結果：中 " + match + " 個號碼。" + prize;
        }

        // btnExit: close application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
