namespace Coin_Toss
{
    partial class Form1
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
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.tossButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // 初始化元件 (繁體中文註解)
            // 以下設定將所有顯示文字改成繁體中文，字型統一設定為 18，並適度調整元件大小與位置
            //
            // outputListBox
            // 列表用於顯示每次擲硬幣的結果，字型改為繁體中文字型並放大至 18
            this.outputListBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 30;
            this.outputListBox.Location = new System.Drawing.Point(200, 40);
            this.outputListBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(380, 302);
            this.outputListBox.TabIndex = 0;
            //
            // tossButton
            // "擲五次" 按鈕：按下後會執行擲硬幣五次的動作，字型改為 18
            this.tossButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tossButton.Location = new System.Drawing.Point(200, 360);
            this.tossButton.Margin = new System.Windows.Forms.Padding(4);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(160, 60);
            this.tossButton.TabIndex = 1;
            this.tossButton.Text = "擲五次";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            //
            // exitButton
            // "離開" 按鈕：關閉表單，文字改為繁體中文，字型改為 18
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(420, 360);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 60);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            //
            // Form1
            // 表單標題改為繁體中文，並設定整體視窗大小以符合放大的元件
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 460);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.outputListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "擲硬幣";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.Button exitButton;
    }
}

