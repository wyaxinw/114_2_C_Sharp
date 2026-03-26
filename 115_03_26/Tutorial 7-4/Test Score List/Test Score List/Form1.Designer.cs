namespace Test_Score_List
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
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.avgScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.aboveAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.belowAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.aboveAverageLabel = new System.Windows.Forms.Label();
            this.belowAverageLabel = new System.Windows.Forms.Label();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchDescriptionLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.ItemHeight = 45;
            this.testScoresListBox.Location = new System.Drawing.Point(47, 60);
            this.testScoresListBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(416, 319);
            this.testScoresListBox.TabIndex = 0;
            // 
            // avgScoreDescriptionLabel
            // 
            this.avgScoreDescriptionLabel.AutoSize = true;
            this.avgScoreDescriptionLabel.Location = new System.Drawing.Point(513, 69);
            this.avgScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.avgScoreDescriptionLabel.Name = "avgScoreDescriptionLabel";
            this.avgScoreDescriptionLabel.Size = new System.Drawing.Size(200, 45);
            this.avgScoreDescriptionLabel.TabIndex = 1;
            this.avgScoreDescriptionLabel.Text = "平均分數：";
            // 
            // aboveAvgDescriptionLabel
            // 
            this.aboveAvgDescriptionLabel.AutoSize = true;
            this.aboveAvgDescriptionLabel.Location = new System.Drawing.Point(513, 175);
            this.aboveAvgDescriptionLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.aboveAvgDescriptionLabel.Name = "aboveAvgDescriptionLabel";
            this.aboveAvgDescriptionLabel.Size = new System.Drawing.Size(380, 45);
            this.aboveAvgDescriptionLabel.TabIndex = 2;
            this.aboveAvgDescriptionLabel.Text = "高於平均的成績數量：";
            // 
            // belowAvgDescriptionLabel
            // 
            this.belowAvgDescriptionLabel.AutoSize = true;
            this.belowAvgDescriptionLabel.Location = new System.Drawing.Point(513, 272);
            this.belowAvgDescriptionLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.belowAvgDescriptionLabel.Name = "belowAvgDescriptionLabel";
            this.belowAvgDescriptionLabel.Size = new System.Drawing.Size(380, 45);
            this.belowAvgDescriptionLabel.TabIndex = 3;
            this.belowAvgDescriptionLabel.Text = "低於平均的成績數量：";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(884, 45);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(324, 92);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboveAverageLabel
            // 
            this.aboveAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboveAverageLabel.Location = new System.Drawing.Point(884, 161);
            this.aboveAverageLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.aboveAverageLabel.Name = "aboveAverageLabel";
            this.aboveAverageLabel.Size = new System.Drawing.Size(324, 92);
            this.aboveAverageLabel.TabIndex = 5;
            this.aboveAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // belowAverageLabel
            // 
            this.belowAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.belowAverageLabel.Location = new System.Drawing.Point(884, 272);
            this.belowAverageLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.belowAverageLabel.Name = "belowAverageLabel";
            this.belowAverageLabel.Size = new System.Drawing.Size(324, 92);
            this.belowAverageLabel.TabIndex = 6;
            this.belowAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getScoresButton
            // 
            this.getScoresButton.Location = new System.Drawing.Point(400, 608);
            this.getScoresButton.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(373, 110);
            this.getScoresButton.TabIndex = 7;
            this.getScoresButton.Text = "取得成績";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(824, 621);
            this.exitButton.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(373, 110);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchDescriptionLabel
            // 
            this.searchDescriptionLabel.AutoSize = true;
            this.searchDescriptionLabel.Location = new System.Drawing.Point(84, 412);
            this.searchDescriptionLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.searchDescriptionLabel.Name = "searchDescriptionLabel";
            this.searchDescriptionLabel.Size = new System.Drawing.Size(200, 45);
            this.searchDescriptionLabel.TabIndex = 9;
            this.searchDescriptionLabel.Text = "搜尋成績：";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(312, 412);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(275, 55);
            this.searchTextBox.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(70, 608);
            this.searchButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(280, 110);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "搜尋";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchResultLabel.Location = new System.Drawing.Point(277, 493);
            this.searchResultLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(744, 107);
            this.searchResultLabel.TabIndex = 12;
            this.searchResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 750);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchDescriptionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.belowAverageLabel);
            this.Controls.Add(this.aboveAverageLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.belowAvgDescriptionLabel);
            this.Controls.Add(this.aboveAvgDescriptionLabel);
            this.Controls.Add(this.avgScoreDescriptionLabel);
            this.Controls.Add(this.testScoresListBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "Form1";
            this.Text = "成績清單";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label avgScoreDescriptionLabel;
        private System.Windows.Forms.Label aboveAvgDescriptionLabel;
        private System.Windows.Forms.Label belowAvgDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label aboveAverageLabel;
        private System.Windows.Forms.Label belowAverageLabel;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
        // 新增的搜尋元件宣告
        private System.Windows.Forms.Label searchDescriptionLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchResultLabel;
    }
}

