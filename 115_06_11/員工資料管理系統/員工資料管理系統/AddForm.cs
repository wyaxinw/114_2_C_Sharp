using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace 員工資料管理系統
{
    public class AddForm : Form
    {
        private List<Employee> employeeList;
        private TextBox txtId, txtName, txtDept, txtPosition, txtMsg;
        private Button btnAdd, btnClose;

        public AddForm(List<Employee> employeeList)
        {
            this.employeeList = employeeList ?? throw new ArgumentNullException(nameof(employeeList));
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "新增員工";
            Width = 420; Height = 370; StartPosition = FormStartPosition.CenterParent;

            var lblId = new Label() { Text = "工號：", Left = 12, Top = 14, AutoSize = true };
            txtId = new TextBox() { Left = 120, Top = 12, Width = 260 };

            var lblName = new Label() { Text = "姓名：", Left = 12, Top = 48, AutoSize = true };
            txtName = new TextBox() { Left = 120, Top = 46, Width = 260 };

            var lblDept = new Label() { Text = "部門：", Left = 12, Top = 82, AutoSize = true };
            txtDept = new TextBox() { Left = 120, Top = 80, Width = 260 };

            var lblPos = new Label() { Text = "職稱：", Left = 12, Top = 116, AutoSize = true };
            txtPosition = new TextBox() { Left = 120, Top = 114, Width = 260 };

            btnAdd = new Button() { Text = "新增", Left = 120, Top = 150, Width = 100 };
            btnClose = new Button() { Text = "離開", Left = 240, Top = 150, Width = 100 };
            btnAdd.Click += BtnAdd_Click;
            btnClose.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

            txtMsg = new TextBox() { Left = 12, Top = 190, Width = 368, Height = 130, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical };

            Controls.AddRange(new Control[] { lblId, txtId, lblName, txtName, lblDept, txtDept, lblPos, txtPosition, btnAdd, btnClose, txtMsg });
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtMsg.Clear();
            var idText = txtId.Text.Trim();
            if (!int.TryParse(idText, out int id))
            {
                txtMsg.Text = "工號必須為整數。";
                return;
            }
            if (employeeList.Any(x => x.IdNumber == id))
            {
                txtMsg.Text = "工號已存在，無法新增。";
                return;
            }
            string name = txtName.Text.Trim();
            string dept = txtDept.Text.Trim();
            string pos = txtPosition.Text.Trim();

            Employee emp;
            if (string.IsNullOrEmpty(dept) || string.IsNullOrEmpty(pos))
                emp = new Employee(name, id);
            else
                emp = new Employee(name, id, dept, pos);

            employeeList.Add(emp);
            txtMsg.Text = "新增完成：" + Environment.NewLine + $"員工編號：{emp.IdNumber} 姓名：{emp.Name}";
            DialogResult = DialogResult.OK;
            // keep form open so user can add more; still set OK so caller may choose to refresh
        }
    }
}
