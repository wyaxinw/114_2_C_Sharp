using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    class BankAccount
    {
        // 使用 decimal 型別來儲存金額，避免浮點數運算造成的誤差。
        private decimal balance;

        // 建構子：設定帳戶的起始餘額。
        // 參數：
        //   initialBalance - 帳戶初始金額（以 decimal 表示）。
        // 備註：呼叫端可在建立前驗證初始金額是否有效（例如非負數）。
        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        // 存款方法：將指定金額加入帳戶餘額。
        // 參數：
        //   amount - 要存入的金額（decimal）。
        // 行為：若 amount 為正值，則加入餘額；否則顯示錯誤訊息。
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                // 顯示使用者友善的錯誤訊息，提示金額必須為正數。
                MessageBox.Show("存款金額必須為正數。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 提款方法：從帳戶餘額中扣除指定金額。
        // 參數：
        //   amount - 要提領的金額（decimal）。
        // 行為：若 amount 為正值，則從餘額扣除；否則顯示錯誤訊息。
        // 備註：此處仍允許透支（餘額變為負值）。若需禁止透支，請在此加入檢查或在呼叫端驗證。
        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                balance -= amount;
            }
            else
            {
                MessageBox.Show("提款金額必須為正數。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 取得目前餘額：回傳帳戶的現有金額（decimal）。
        // 備註：此方法僅回傳值，不會修改狀態。
        public decimal GetBalance()
        {
            return balance;
        }
    }
}
