using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 檢查是否為有效的電話號碼（僅檢查數字長度）
        //
        // 說明：
        // 此方法接受一個字串參數，並用來判斷該字串是否為一個有效的電話號碼。
        // 在本範例中，驗證條件為字串的長度是否為 10。實務上可加入更嚴謹的
        // 檢查（例如過濾非數字字元、檢查國碼等），但此處僅以字元長度為判斷準則。
        //
        // 範例：
        //  - "1234567890" -> 視為有效 (回傳 true)
        //  - "123-456-7890" -> 若未移除非數字字元則可能視為無效
        //  - "0123456789" -> 視為有效 (回傳 true)
        //
        // 備註：若要支援其他格式，可在呼叫此方法前先將輸入字串中的非數字字元
        // 移除，再傳入判斷；或在本方法內擴充相關邏輯。
        private bool IsValidNumber(string str)
        {
            // Check if the string contains exactly 10 characters.
            if (str.Length != 10)
                return false;
        }

        // The TelephoneFormat method accepts a string argument
        // by reference and formats it as a telephone number.
        private void TelephoneFormat(ref string str)
        {
            //使用字串的 Substring 方法來提取字串的不同部分
            //第一部分:前2位數字(區碼)
            //string part1 = str.Substring(0, 2);
            //第二部分:中間4位數字
            //string Part2 = str.Substring(2, 4);
            //第三部分:最後4位數字
            //string Part3 = str.Substring(6, 4);

            //將各部分組合成電話號碼格式
            //str = $"({part1}) {Part2}-{Part3}";
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            // 「格式化」按鈕的事件處理器
            //
            // 建議流程：
            // 1. 從 numberTextBox 取得使用者輸入的字串。
            // 2. 呼叫 IsValidNumber 驗證輸入是否符合預期（此範例以長度 10 為準）。
            // 3. 若驗證通過，呼叫 TelephoneFormat(ref number) 進行格式化，
            //    並將格式化後的結果放回 numberTextBox 或顯示於介面上。
            // 4. 若驗證失敗，顯示錯誤訊息通知使用者。
            
            // Get the text from the TextBox.
            string number = numberTextBox.Text;

            // Validate the input.
            if (!IsValidNumber(number))
            {
                MessageBox.Show("請輸入 10 位數字。");
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
