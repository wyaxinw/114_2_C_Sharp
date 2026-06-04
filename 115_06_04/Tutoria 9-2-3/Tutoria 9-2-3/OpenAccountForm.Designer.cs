namespace Tutoria_9_2_3
{
    partial class OpenAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 260);
            this.Text = "開立帳戶";

            // 建立表單上的控制項：帳號、姓名、初始餘額與建立按鈕
            this.labelAccount = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelInitialBalance = new System.Windows.Forms.Label();
            this.txtInitialBalance = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();

            // labelAccount
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(16, 20);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(80, 20);
            this.labelAccount.Text = "帳號：";

            // txtAccountNumber
            this.txtAccountNumber.Location = new System.Drawing.Point(110, 16);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(280, 26);

            // labelName
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 64);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 20);
            this.labelName.Text = "持有人：";

            // txtName
            this.txtName.Location = new System.Drawing.Point(110, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 26);

            // labelInitialBalance
            this.labelInitialBalance.AutoSize = true;
            this.labelInitialBalance.Location = new System.Drawing.Point(16, 108);
            this.labelInitialBalance.Name = "labelInitialBalance";
            this.labelInitialBalance.Size = new System.Drawing.Size(80, 20);
            this.labelInitialBalance.Text = "初始餘額：";

            // txtInitialBalance
            this.txtInitialBalance.Location = new System.Drawing.Point(110, 104);
            this.txtInitialBalance.Name = "txtInitialBalance";
            this.txtInitialBalance.Size = new System.Drawing.Size(280, 26);

            // btnCreateAccount
            this.btnCreateAccount.Location = new System.Drawing.Point(110, 150);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(120, 36);
            this.btnCreateAccount.Text = "建立帳戶";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);

            // 加入 Controls
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelInitialBalance);
            this.Controls.Add(this.txtInitialBalance);
            this.Controls.Add(this.btnCreateAccount);
        }

        #endregion
    }
}