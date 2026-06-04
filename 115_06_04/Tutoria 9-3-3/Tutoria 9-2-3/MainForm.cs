using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutoria_9_2_3.Account_Simulator;

namespace Tutoria_9_2_3
{
    public partial class MainForm : Form
    {
        // 主表單持有所有帳戶的集合
        public List<BankAccount> accounts = new List<BankAccount>();

        public MainForm()
        {
            InitializeComponent();

            // 連接按鈕事件（Designer 已建立按鈕名稱）
            try
            {
                this.btnDeposit.Click += BtnDeposit_Click;
                this.btnOpenAccount.Click += BtnOpenAccount_Click;
                this.btnExit.Click += BtnExit_Click;
            }
            catch { }
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            // 開啟存款表單，並傳入帳戶列表
            using (var f = new DepositForm(this.accounts))
            {
                f.ShowDialog(this);
            }
        }

        private void BtnOpenAccount_Click(object sender, EventArgs e)
        {
            // 開啟開戶表單，讓使用者建立新帳戶
            using (var f = new OpenAccountForm(this.accounts))
            {
                f.ShowDialog(this);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
