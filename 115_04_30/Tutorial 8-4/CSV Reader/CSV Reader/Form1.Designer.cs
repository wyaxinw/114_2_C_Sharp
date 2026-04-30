namespace CSV_Reader
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
            this.averagesListBox = new System.Windows.Forms.ListBox();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // averagesListBox
            // 
            // 以下為成績顯示的 ListBox 控制項設定。
            // 註：將字型改為繁體中文字型（微軟正黑體）18pt，
            // 並增大清單框的尺寸以容納較大的字體與更多項目。
            this.averagesListBox.FormattingEnabled = true;
            this.averagesListBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.averagesListBox.Location = new System.Drawing.Point(12, 12);
            this.averagesListBox.Name = "averagesListBox";
            this.averagesListBox.Size = new System.Drawing.Size(336, 220);
            this.averagesListBox.TabIndex = 0;
            // 
            // getScoresButton
            // 
            // 以下為「讀取成績」按鈕設定。
            // 註：設定按鈕顯示文字為繁體中文，字型 18pt，並調整尺寸與位置以利點擊。
            this.getScoresButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.getScoresButton.Location = new System.Drawing.Point(48, 248);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(120, 40);
            this.getScoresButton.TabIndex = 1;
            this.getScoresButton.Text = "讀取成績";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            // 以下為「離開」按鈕設定。
            // 註：設定按鈕顯示文字為繁體中文，字型 18pt，並調整尺寸與位置以利使用者操作。
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(192, 248);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 以下為表單本身的設定。
            // 註：將視窗標題改為繁體中文，並擴大表單大小以配合放大後的控制項與字型。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 310);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averagesListBox);
            this.Name = "Form1";
            this.Text = "CSV 檔案讀取器"; // 視窗標題：繁體中文
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox averagesListBox;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
    }
}

