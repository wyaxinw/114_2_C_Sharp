namespace Multiform_Practice
{
    partial class MainForm
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
            this.displayFormButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // --------------------------------------------------
            // 以下為元件屬性設定（已將文字改為繁體中文、字型大小統一為18pt）
            // 以避免元件在大字型下互相遮蓋，適度調整按鈕大小與位置
            // --------------------------------------------------
            // 
            // displayFormButton
            // 設定「顯示表單」按鈕的屬性：
            // - 文字改為繁體中文
            // - 調整按鈕位置與大小以容納 18pt 字型
            // - 保留原本的事件處理器
            // 
            this.displayFormButton.Location = new System.Drawing.Point(80, 40);
            this.displayFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayFormButton.Name = "displayFormButton";
            this.displayFormButton.Size = new System.Drawing.Size(180, 56);
            this.displayFormButton.TabIndex = 0;
            this.displayFormButton.Text = "顯示表單";
            this.displayFormButton.UseVisualStyleBackColor = true;
            this.displayFormButton.Click += new System.EventHandler(this.displayFormButton_Click);
            // 
            // exitButton
            // 設定「結束」按鈕的屬性：
            // - 文字改為繁體中文
            // - 調整按鈕位置與大小以避免與其他元件重疊
            // - 保留原本的事件處理器
            // 
            this.exitButton.Location = new System.Drawing.Point(280, 40);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 56);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 主窗體設定：
            // - 將整個表單的字型設定為 18pt（使用繁體中文常見字型，以確保顯示效果）
            // - 保持原本 ClientSize，但元件位置已調整以避免遮蓋
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 設定整個表單的字型為 18pt，讓所有子元件繼承此字型大小
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClientSize = new System.Drawing.Size(727, 526);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayFormButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            // 將表單標題改為繁體中文
            this.Text = "多重表單練習";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayFormButton;
        private System.Windows.Forms.Button exitButton;
    }
}

