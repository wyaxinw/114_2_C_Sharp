using System;
using System.Windows.Forms;

namespace Account_Simulator
{
    // 將 BankAccount 類別設為 public 以供其他類別存取
    public class BankAccount
    {
        // 使用 decimal 型別來儲存金額，避免浮點數運算造成的誤差。
        private decimal balance;

        // 可選的帳戶編號與持有人名稱欄位
        private string accountNumber = string.Empty;
        private string name = string.Empty;

        // 預設建構子：若未提供初始金額，預設為 0
        public BankAccount()
        {
            balance = 0m;
        }

        // 以初始餘額建立帳戶
        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        // 額外的建構子：允許同時設定帳號、持有人與初始餘額
        public BankAccount(string accountNumber, string name, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.balance = initialBalance;
        }

        // 存款方法：將指定金額加入帳戶餘額。
        // 參數：amount - 要存入的金額（decimal）。
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
        public decimal GetBalance()
        {
            return balance;
        }

        // 另外提供屬性以相容舊版程式碼
        public decimal Balance
        {
            get { return balance; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
    }
}
