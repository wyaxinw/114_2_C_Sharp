using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seating_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayPriceButton_Click(object sender, EventArgs e)
        {
            // 座位票價矩陣：每一列代表一個 row，每一行代表一個 column
            decimal[,] seatPrices = { { 450m, 450m, 450m, 450m },
                                   { 425m, 425m, 425m, 425m },
                                   { 400m, 400m, 400m, 400m },
                                   { 375m, 375m, 375m, 375m },
                                   { 350m, 350m, 350m, 350m }
                                 };

            // 注意：seatPrices.Length 會回傳整個陣列的元素總數 (ROWS * COLS)，
            // 並非列數或欄數。本程式需要分別取得列數與欄數，應使用 GetLength。
            int maxRows = seatPrices.GetLength(0); // 第一維的長度 = 列數
            int maxCols = seatPrices.GetLength(1); // 第二維的長度 = 欄數

            int row;
            int col;

            // 解析並驗證使用者輸入的列號（從 rowTextBox ）
            if (!int.TryParse(rowTextBox.Text, out row) || row < 1 || row > maxRows)
            {
                MessageBox.Show($"請輸入有效的列號（1 到 {maxRows}）", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 解析並驗證使用者輸入的欄位（從 colTextBox ）
            if (!int.TryParse(colTextBox.Text, out col) || col < 1 || col > maxCols)
            {
                MessageBox.Show($"請輸入有效的欄位（1 到 {maxCols}）", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 若通過驗證，顯示對應座位的價格（注意索引從 0 開始，因此減 1）
            priceLabel.Text = seatPrices[row - 1, col - 1].ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
                {
                    // Close the form.
                    this.Close();
                }
    }
}
