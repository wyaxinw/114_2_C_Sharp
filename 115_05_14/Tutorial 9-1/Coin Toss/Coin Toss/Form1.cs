using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    // 主表單類別：負責 UI 事件處理與元件互動
    public partial class Form1 : Form
    {
        // 建構子：建立表單實例並初始化元件
        public Form1()
        {
            // InitializeComponent 負責建立及配置所有設計工具產生的元件
            InitializeComponent();
        }

        // 擲五次按鈕的事件處理器
        // 當使用者按下「擲五次」按鈕時會觸發此方法，流程如下：
        // 1. 建立一個 Coin 物件
        // 2. 清空顯示結果的 ListBox（避免累積舊結果）
        // 3. 使用迴圈執行 5 次擲硬幣動作，每次呼叫 Coin.Toss()
        // 4. 將每次擲出的結果（SideUp）加入到 ListBox 中顯示
        private void tossButton_Click(object sender, EventArgs e)
        {
            // 建立 Coin 類別的實例，用於模擬擲硬幣
            Coin myCoin = new Coin();

            // 清空列表，準備放入新的擲硬幣結果
            outputListBox.Items.Clear();

            // 重複執行五次擲硬幣
            for (int i = 0; i < 5; i++)
            {
                // 執行一次擲硬幣，更新 myCoin 的 SideUp 屬性
                myCoin.Toss();

                // 將本次擲硬幣的結果（正面或反面）新增到列表中顯示
                outputListBox.Items.Add(myCoin.GetSideUp());
            }
        }

        // 離開按鈕的事件處理器
        // 按下後關閉目前表單並結束應用程式（若為主表單）
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
