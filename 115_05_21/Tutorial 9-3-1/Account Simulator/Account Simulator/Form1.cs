using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
  public partial class Form1 : Form
    {
        private BankAccount account;

        public Form1()
        {
            InitializeComponent();
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            // balanceLabel.Text = account.Balance.ToString("C");
        }
        private decimal balance;
        public string name;
        private string accountNumber;
        
        public BankAccount(string accountNumber, string name, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            balance = initialBalance;
        }
        
        public decimal Balance  
        {
           get { return balance; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string AccountNumber
        {
            get { return accountNumber; }
        }
    
        // BankAccount field with a $1000 starting balance 
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // balanceLabel.Text = account.Balance.ToString("C");

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
           decimal amount;
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                account.Desposit(amount);
                balanceLabel.Text = account.AccountNumber + "\n "
                                   + account.Name + "\n " 
                                    + account.Balance.ToString("C");
                depositTextBox.Clear();
                
            }
            else
            {
                MessageBox.Show("請輸入有效的存款金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
           decimal amount;
            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
              account.Withdraw(amount))
                balanceLabel.Text = account.AccountNumber + "\n "
                                       + account.Name + "\n "
                                        + account.Balance.ToString("C");
                    withdrawTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("餘額不足，無法完成提款。", "提款失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的提款金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
