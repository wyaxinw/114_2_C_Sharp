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
using System.Threading;

namespace Phonebook
{
    // PhoneBookEntry 結構用來表示電話簿中的一筆資料。
    // 每筆資料包含姓名與電話兩個欄位。
    // 此結構是值型別，適合用於儲存簡單、不會再被延伸的資料項目。
    struct PhoneBookEntry
    {
        // 使用者的姓名
        public string name;
        // 使用者的電話號碼（字串格式以保留前導 0 與特殊符號）
        public string phone;
    }

    public partial class Form1 : Form
    {
        // 儲存電話簿所有項目的集合
        // 使用 List<PhoneBookEntry> 以提供動態加減、索引存取等功能。
        private List<PhoneBookEntry> phoneList = 
            new List<PhoneBookEntry>();

        // 建構子：初始化表單元件
        // InitializeComponent() 由設計工具自動產生，負責建立並配置所有 UI 控制項。
        public Form1()
        {
            InitializeComponent();
        }

        // ReadFile 方法：讀取外部檔案 "PhoneList.txt" 的內容，
        // 將每一筆資料解析為 PhoneBookEntry 結構並加入到 phoneList 中。
        // 預期檔案格式（每行一筆）：
        //   姓名,電話
        // 例如：王小明,0912345678
        // ※ 若檔案不存在或格式不正確，應在呼叫此方法的地方處理例外或顯示錯誤訊息。
        private void ReadFile()
        {
            try 
            {
                StreamReader inputFile;
                string line;
                char[] deline = { ',' };
                PhoneBookEntry entry = new PhoneBookEntry();

                //開啟檔案
                using (inputFile = File.OpenText("PhoneList.txt"))
                {
                    // 逐行讀取檔案內容
                    while (inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine();
                        // 使用逗號分隔姓名與電話號碼
                        string[] fields = line.Split(deline);
                        // 確保每行有兩個部分（姓名與電話）
                        if (fields.Length == 2)
                        {
                            entry.name = tokens[0].Trim();// 去除姓名前後的空白
                            entry.phone =tokens[1].Trim();// 去除電話前後的空白
                            // 將 entry 加入到 phoneList 列表中
                            phoneList.Add(entry);
                        }
                    }
                }
            }
            catch {Exception ex}
            {
                // 顯示錯誤訊息，告知使用者讀取檔案時發生了問題。
                MessageBox.Show("讀取檔案時發生錯誤：" + ex.Message);
            }
        }

        // DisplayNames 方法：將 phoneList 中的姓名逐一加入到介面的 nameListBox 中，
        // 讓使用者能從清單中選取姓名以查看對應的電話號碼。
        // 此方法只負責名稱的顯示，不處理選取時的事件。
        private void DisplayNames()
        {
            
        }

        // Form1_Load 事件處理器：表單載入時會執行的程式碼。
        // 常見作法是在這裡呼叫 ReadFile() 讀取資料，然後呼叫 DisplayNames() 將名稱顯示在清單上，
        // 使介面在一開始就能顯示可選的資料內容。
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        // nameListBox_SelectedIndexChanged 事件處理器：
        // 當使用者在 nameListBox 中選取不同的姓名時觸發。
        // 此處應找到相對應的 PhoneBookEntry 並將電話號碼顯示在 phoneLabel 上。
        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
