using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace 員工資料管理系統
{
    public class DeleteForm : Form
    {
        private List<Employee> employeeList;
        private TextBox txtId, txtMsg;
        private Button btnDelete, btnClose;
        private int prefillIndex = -1;

        // index 為選取的員工索引（可選），若提供則介面會預填該員工之工號
        public DeleteForm(List<Employee> employeeList, int index = -1)
        {
            this.employeeList = employeeList ?? throw new ArgumentNullException(nameof(employeeList));
            this.prefillIndex = index;
            InitializeComponent();
            // 若提供了合法 index，就預填工號欄位並顯示該員工資訊
            if (prefillIndex >= 0 && prefillIndex < this.employeeList.Count)
            {
                var e = this.employeeList[prefillIndex];
                txtId.Text = e.IdNumber.ToString();
                txtMsg.Text = $"選取：{e.IdNumber}\t{e.Name}";
            }
        }

        private void InitializeComponent()
        {
            Text = "刪除員工"; Width = 380; Height = 240; StartPosition = FormStartPosition.CenterParent;
            var lbl = new Label() { Text = "工號：", Left = 12, Top = 14, AutoSize = true };
            txtId = new TextBox() { Left = 80, Top = 12, Width = 240 };
            btnDelete = new Button() { Text = "刪除", Left = 80, Top = 44, Width = 100 };
            btnClose = new Button() { Text = "關閉", Left = 200, Top = 44, Width = 100 };
            btnDelete.Click += BtnDelete_Click;
            btnClose.Click += (s, e) => Close();
            txtMsg = new TextBox() { Left = 12, Top = 84, Width = 340, Height = 100, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical };

            Controls.AddRange(new Control[] { lbl, txtId, btnDelete, btnClose, txtMsg });
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            txtMsg.Clear();
            if (!int.TryParse(txtId.Text.Trim(), out int id))
            {
                txtMsg.Text = "請輸入有效工號 (整數)。";
                return;
            }
            var emp = employeeList.FirstOrDefault(x => x.IdNumber == id);
            if (emp == null)
            {
                txtMsg.Text = "查無此員工。";
                return;
            }
            employeeList.Remove(emp);
            txtMsg.Text = $"已刪除：{emp.IdNumber}\t{emp.Name}";
            DialogResult = DialogResult.OK;
        }
    }
}
