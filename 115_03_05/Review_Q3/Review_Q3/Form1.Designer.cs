namespace Review_Q3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UI controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label[] lblNumbers;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelLeftResult;
        private System.Windows.Forms.Panel panelRightResult;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Text = "樂透號碼產生器";

            // Title label
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 32);
            this.lblTitle.Text = "樂透號碼產生器";
            this.Controls.Add(this.lblTitle);

            // Number boxes (6)
            this.lblNumbers = new System.Windows.Forms.Label[6];
            int startX = 40;
            int startY = 70;
            int boxSize = 70;
            int spacing = 30;
            for (int i = 0; i < 6; i++)
            {
                var lbl = new System.Windows.Forms.Label();
                lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lbl.Size = new System.Drawing.Size(boxSize, boxSize);
                lbl.Location = new System.Drawing.Point(startX + i * (boxSize + spacing), startY);
                lbl.Name = "lblNumber" + (i + 1);
                lbl.Text = "";
                this.lblNumbers[i] = lbl;
                this.Controls.Add(lbl);
            }

            // Buttons
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            int btnWidth = 180;
            int btnHeight = 60;
            int btnY = startY + boxSize + 30;
            int centerX = (this.ClientSize.Width - (btnWidth * 3 + 40 * 2)) / 2; // spacing 40 between buttons

            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnGenerate.Location = new System.Drawing.Point(centerX, btnY);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Text = "產生號碼";
            this.btnGenerate.UseVisualStyleBackColor = true;

            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnLoad.Location = new System.Drawing.Point(centerX + btnWidth + 40, btnY);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Text = "開獎號碼";
            this.btnLoad.UseVisualStyleBackColor = true;

            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnExit.Location = new System.Drawing.Point(centerX + (btnWidth + 40) * 2, btnY);
            this.btnExit.Name = "btnExit";
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;

            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnExit);

            // Result panels (two large boxes side by side)
            this.panelLeftResult = new System.Windows.Forms.Panel();
            this.panelRightResult = new System.Windows.Forms.Panel();

            int panelTop = btnY + btnHeight + 30;
            int panelWidth = (this.ClientSize.Width - 60) / 2; // 20 margin both sides and 20 between
            int panelHeight = this.ClientSize.Height - panelTop - 40;

            this.panelLeftResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftResult.Location = new System.Drawing.Point(20, panelTop);
            this.panelLeftResult.Size = new System.Drawing.Size(panelWidth, panelHeight);
            this.panelLeftResult.Name = "panelLeftResult";

            this.panelRightResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRightResult.Location = new System.Drawing.Point(40 + panelWidth, panelTop);
            this.panelRightResult.Size = new System.Drawing.Size(panelWidth, panelHeight);
            this.panelRightResult.Name = "panelRightResult";

            this.Controls.Add(this.panelLeftResult);
            this.Controls.Add(this.panelRightResult);

            // Set form font to ensure 18pt readability where applicable
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }

        #endregion
    }
}
