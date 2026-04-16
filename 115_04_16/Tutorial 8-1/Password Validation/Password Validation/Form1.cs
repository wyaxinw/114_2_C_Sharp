using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        // 表單類別說明（繁體中文註解）：
        // 此類別代表一個用來驗證密碼的 Windows Forms 表單。
        // 表單上包含說明標籤、提示標籤、密碼輸入欄位，以及「檢查密碼」與「離開」按鈕。
        // 使用者在密碼欄位輸入密碼後，按下「檢查密碼」按鈕會觸發檢查程序；
        // 按下「離開」按鈕會關閉此表單。
        public Form1()
        {
            InitializeComponent();
        }

        // 建構子說明（繁體中文註解）：
        // Form1 的建構子負責初始化表單的所有元件。
        // InitializeComponent 方法由設計工具自動產生，會建立並配置表單上的控制項。
        // 在此處不應該放置耗時或需要 UI 完成載入前完成的工作，若需額外初始化可於
        // Form 的 Load 事件或其他非同步初始化中執行。

        // The NumberUpperCase method accepts a string argument
        // and returns the number of uppercase letters it contains.
        // 方法說明（繁體中文註解）：
        // 此方法接收一個字串參數，並應回傳該字串中大寫英文字母的數量。
        // 範例行為：傳入 "AbC1" 應回傳 2（A 與 C 為大寫字母）。
        private int NumberUpperCase(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }

        // The NumberLowerCase method accepts a string argument
        // and returns the number of lowercase letters it contains.
        // 方法說明（繁體中文註解）：
        // 此方法接收一個字串參數，並應回傳該字串中小寫英文字母的數量。
        // 範例行為：傳入 "Abc1" 應回傳 2（b 與 c 為小寫字母）。
        private int NumberLowerCase(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }return count;
        }

        // The NumberDigits method accepts a string argument
        // and returns the number of numeric digits it contains.
        // 方法說明（繁體中文註解）：
        // 此方法接收一個字串參數，並應回傳該字串中數字字元的數量。
        // 範例行為：傳入 "a1b23" 應回傳 3（字元 '1','2','3'）。
        private int NumberDigits(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MinimumLength = 8;
            string password = passwordTextBox.Text;
            if (password.Length < MinimumLength)
            {
                MessageBox.Show($"密碼長度須至少 {MinimumLength} 個字元。");
                return;
            }
            else
            {
                int upperCaseCount = NumberUpperCase(password);
                int lowerCaseCount = NumberLowerCase(password);
                int digitCount = NumberDigits(password);
                if (upperCaseCount < 1)
                {
                    MessageBox.Show("密碼必須至少包含一個大寫字母。");
                    return;
                }
                else if (lowerCaseCount < 1)
                {
                    MessageBox.Show("密碼必須至少包含一個小寫字母");
                    return;
                }
                else if (digitCount < 1)
                {
                    MessageBox.Show("密碼必須至少包含一個數字");
                    return;
                }
                else
                {
                    MessageBox.Show("密碼符合規則！");
                }
                // 事件處理說明（繁體中文註解）：
                // 此事件處理器在使用者按下「檢查密碼」按鈕時被呼叫。
                // 預期行為：從密碼輸入欄位讀取使用者輸入的字串，
                // 使用上方的輔助方法（NumberUpperCase、NumberLowerCase、NumberDigits）
                // 來判斷密碼是否符合規則，最後以訊息或其他方式回饋驗證結果。
                // 注意：目前此方法未實作具體驗證邏輯，僅保留事件簽章以供 UI 綁定。

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
