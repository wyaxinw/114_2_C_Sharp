using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace 員工資料管理系統
{
    public class ModifyForm : Form
    {
        private Employee target;
        private TextBox txtId, txtName, txtDept, txtPos, txtMsg;
        private Button btnQuery, btnSave, btnClose;

        public ModifyForm(Employee target)
        {
            this.target = target ?? throw new ArgumentNullException(nameof(target));
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "修改員工資料"; Width = 420; Height = 380; StartPosition = FormStartPosition.CenterParent;
            var lblId = new Label() { Text = "工號：", Left = 12, Top = 12, AutoSize = true };
            txtId = new TextBox() { Left = 80, Top = 10, Width = 200, ReadOnly = true };
            var lblName = new Label() { Text = "姓名：", Left = 12, Top = 52, AutoSize = true };
            txtName = new TextBox() { Left = 80, Top = 50, Width = 300 };
            var lblDept = new Label() { Text = "部門：", Left = 12, Top = 92, AutoSize = true };
            txtDept = new TextBox() { Left = 80, Top = 90, Width = 300 };
            var lblPos = new Label() { Text = "職稱：", Left = 12, Top = 132, AutoSize = true };
            txtPos = new TextBox() { Left = 80, Top = 130, Width = 300 };

            btnSave = new Button() { Text = "儲存", Left = 80, Top = 172, Width = 100 };
            btnClose = new Button() { Text = "關閉", Left = 200, Top = 172, Width = 100 };
            btnSave.Click += BtnSave_Click;
            btnClose.Click += (s, e) => Close();

            txtMsg = new TextBox() { Left = 12, Top = 210, Width = 380, Height = 120, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical };

            Controls.AddRange(new Control[] { lblId, txtId, lblName, txtName, lblDept, txtDept, lblPos, txtPos, btnSave, btnClose, txtMsg });

            // populate initial
            txtId.Text = target.IdNumber.ToString();
            txtName.Text = target.Name;
            txtDept.Text = target.Department;
            txtPos.Text = target.Position;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            target.Name = txtName.Text.Trim();
            target.Department = txtDept.Text.Trim();
            target.Position = txtPos.Text.Trim();
            txtMsg.Text = "修改完成。";
            DialogResult = DialogResult.OK;
        }
    }
}
