namespace Food_Facts
{
    public partial class NutritionForm : Form
    {
        private FoodItem foodItem;

        public NutritionForm(FoodItem foodItem)
        {
            InitializeComponent();
            this.foodItem = foodItem;
            DisplayNutritionInfo();
        }

        private void DisplayNutritionInfo()
        {
            foodLabel.Text = foodItem.Name;
            caloriesLabel.Text = foodItem.Calories.ToString();
            fatLabel.Text = foodItem.Fat.ToString();
            carbLabel.Text = foodItem.Carbohydrates.ToString();
        }

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
            this.label1 = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carbLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            // 食物標題標籤
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "食物";
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // foodLabel
            // 
            // 顯示選擇的食物名稱
            this.foodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodLabel.Location = new System.Drawing.Point(170, 18);
            this.foodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(300, 40);
            this.foodLabel.TabIndex = 1;
            this.foodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foodLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // caloriesLabel
            // 
            // 顯示熱量
            this.caloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesLabel.Location = new System.Drawing.Point(170, 74);
            this.caloriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(300, 40);
            this.caloriesLabel.TabIndex = 3;
            this.caloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.caloriesLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // label3
            // 
            // 熱量文字標籤
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "熱量";
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // fatLabel
            // 
            // 顯示脂肪克數
            this.fatLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fatLabel.Location = new System.Drawing.Point(170, 130);
            this.fatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(300, 40);
            this.fatLabel.TabIndex = 5;
            this.fatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fatLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // label4
            // 
            // 脂肪標籤
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "脂肪 (克)";
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // carbLabel
            // 
            // 顯示碳水化合物克數
            this.carbLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carbLabel.Location = new System.Drawing.Point(170, 186);
            this.carbLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(300, 40);
            this.carbLabel.TabIndex = 7;
            this.carbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.carbLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // label5
            // 
            // 碳水標籤
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "碳水 (克)";
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // closeButton
            // 
            // 關閉按鈕（放置於右下方，字型放大）
            this.closeButton.Location = new System.Drawing.Point(370, 250);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(120, 50);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "關閉";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // NutritionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 調整視窗大小以容納放大後的元件
            this.ClientSize = new System.Drawing.Size(520, 320);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.carbLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NutritionForm";
            this.Text = "營養資訊";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label foodLabel;
        public System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label carbLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeButton;
    }
}