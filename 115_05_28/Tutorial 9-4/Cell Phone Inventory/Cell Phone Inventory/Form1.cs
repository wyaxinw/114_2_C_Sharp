using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        // 儲存 CellPhone 物件的清單
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        // GetPhoneData 方法接受一個 CellPhone 物件作為參數。
        // 此方法會將使用者輸入的資料指定給該物件的屬性。
        private void GetPhoneData(CellPhone phone)
        {
            // 暫存價格的變數。
            decimal price;

            // 取得手機的品牌。
            phone.Brand = brandTextBox.Text;

            // 取得手機的型號。
            phone.Model = modelTextBox.Text;

            // 取得手機的價格。
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // 顯示錯誤訊息。
                MessageBox.Show("價格格式不正確");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            CellPhone phone = new CellPhone();
            GetPhoneData(phone);
            phoneList.Add(phone);

            // 更新 ListBox 顯示手機資訊
            phoneListBox.Items.Add($"{phone.Brand} {phone.Model}");

            // 清空輸入欄位
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            // 將焦點設回品牌輸入框
            brandTextBox.Focus();
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = phoneListBox.SelectedIndex;

            MessageBox.Show(phoneList[index].Brand + " " + phoneList[index].Price.ToString("C"));
        }

        // listGroupBox_Enter 事件處理器：當手機列表群組獲得焦點時會觸發。
        // 目前不需在此執行任何動作，但保留此方法以供設計工具的事件綁定使用。
        private void listGroupBox_Enter(object sender, EventArgs e)
        {
            // 暫無實作。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        
       
        }
    }
}
