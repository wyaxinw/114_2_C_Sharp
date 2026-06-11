using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace 員工資料管理系統
{
    public class SearchForm : Form
    {
        private List<Employee> employeeList;
        private TextBox txtId, txtMsg;
        private Button btnQuery, btnClose;

        public SearchForm(List<Employee> employeeList)
        {
            this.employeeList = employeeList ?? throw new ArgumentNullException(nameof(employeeList));
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "查詢員工"; Width = 420; Height = 320; StartPosition = FormStartPosition.CenterParent;
            var lbl = new Label() { Text = "工號：", Left = 12, Top = 12, AutoSize = true };
            txtId = new TextBox() { Left = 80, Top = 10, Width = 200 };
            btnQuery = new Button() { Text = "查詢", Left = 292, Top = 8, Width = 80 };
            btnClose = new Button() { Text = "關閉", Left = 160, Top = 240, Width = 100 };
            btnQuery.Click += BtnQuery_Click;
            btnClose.Click += (s, e) => Close();

            txtMsg = new TextBox() { Left = 12, Top = 44, Width = 380, Height = 180, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical };

            Controls.AddRange(new Control[] { lbl, txtId, btnQuery, txtMsg, btnClose });
        }

        private void BtnQuery_Click(object sender, EventArgs e)
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
            txtMsg.Text = $"員工編號：{emp.IdNumber}{Environment.NewLine}姓名：{emp.Name}{Environment.NewLine}部門：{emp.Department}{Environment.NewLine}職稱：{emp.Position}";
        }
    }
}
