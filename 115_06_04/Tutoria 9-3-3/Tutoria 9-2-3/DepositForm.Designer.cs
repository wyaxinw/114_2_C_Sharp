namespace Tutoria_9_2_3
{
    partial class DepositForm
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
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Text = "存款";

            // 建立並設定帳號輸入欄位
            this.labelAccount = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            // 建立並設定存入金額欄位
            this.labelAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            // 建立存入按鈕
            this.btnDeposit = new System.Windows.Forms.Button();

            // labelAccount
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(16, 20);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(80, 20);
            this.labelAccount.Text = "帳號：";

            // txtAccountNumber
            this.txtAccountNumber.Location = new System.Drawing.Point(110, 16);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(260, 26);

            // labelAmount
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(16, 64);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(80, 20);
            this.labelAmount.Text = "金額：";

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(110, 60);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(260, 26);

            // btnDeposit
            this.btnDeposit.Location = new System.Drawing.Point(110, 110);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(100, 36);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "存入";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);

            // 加入 Controls
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnDeposit);
        }

        #endregion
    }
}