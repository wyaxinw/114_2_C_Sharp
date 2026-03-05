using System.Drawing;
using System.Windows.Forms;

namespace Review_Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.GroupBox gbOilLubrication;
        private System.Windows.Forms.CheckBox chkChangeOil;
        private System.Windows.Forms.CheckBox chkLubrication;

        private System.Windows.Forms.GroupBox gbCleaning;
        private System.Windows.Forms.CheckBox chkRadiatorFlush;
        private System.Windows.Forms.CheckBox chkTransmissionFlush;

        private System.Windows.Forms.GroupBox gbOtherServices;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.CheckBox chkReplaceMuffler;
        private System.Windows.Forms.CheckBox chkWheelAlignment;

        private System.Windows.Forms.GroupBox gbPartsLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblLaborHours;
        private System.Windows.Forms.TextBox txtLaborHours;

        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lblServiceLaborCost;
        private System.Windows.Forms.TextBox txtServiceLaborCost;
        private System.Windows.Forms.Label lblPartsCost;
        private System.Windows.Forms.TextBox txtPartsCost;
        private System.Windows.Forms.Label lblPartsTax;
        private System.Windows.Forms.TextBox txtPartsTax;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtTotalCost;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

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
            gbOilLubrication = new GroupBox();
            chkChangeOil = new CheckBox();
            chkLubrication = new CheckBox();
            gbCleaning = new GroupBox();
            chkRadiatorFlush = new CheckBox();
            chkTransmissionFlush = new CheckBox();
            gbOtherServices = new GroupBox();
            chkInspection = new CheckBox();
            chkReplaceMuffler = new CheckBox();
            chkWheelAlignment = new CheckBox();
            gbPartsLabor = new GroupBox();
            lblParts = new Label();
            txtParts = new TextBox();
            lblLaborHours = new Label();
            txtLaborHours = new TextBox();
            gbSummary = new GroupBox();
            lblServiceLaborCost = new Label();
            txtServiceLaborCost = new TextBox();
            lblPartsCost = new Label();
            txtPartsCost = new TextBox();
            lblPartsTax = new Label();
            txtPartsTax = new TextBox();
            lblTotalCost = new Label();
            txtTotalCost = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            gbOilLubrication.SuspendLayout();
            gbCleaning.SuspendLayout();
            gbOtherServices.SuspendLayout();
            gbPartsLabor.SuspendLayout();
            gbSummary.SuspendLayout();
            SuspendLayout();
            // 
            // gbOilLubrication
            // 
            gbOilLubrication.Controls.Add(chkChangeOil);
            gbOilLubrication.Controls.Add(chkLubrication);
            gbOilLubrication.Location = new Point(16, 16);
            gbOilLubrication.Name = "gbOilLubrication";
            gbOilLubrication.Size = new Size(240, 100);
            gbOilLubrication.TabIndex = 0;
            gbOilLubrication.TabStop = false;
            gbOilLubrication.Text = "機油和潤滑";
            gbOilLubrication.Enter += gbOilLubrication_Enter;
            // 
            // chkChangeOil
            // 
            chkChangeOil.AutoSize = true;
            chkChangeOil.Location = new Point(12, 24);
            chkChangeOil.Name = "chkChangeOil";
            chkChangeOil.Size = new Size(190, 27);
            chkChangeOil.TabIndex = 1;
            chkChangeOil.Text = "更換機油 (NT$780)";
            chkChangeOil.UseVisualStyleBackColor = true;
            chkChangeOil.CheckedChanged += chkChangeOil_CheckedChanged;
            // 
            // chkLubrication
            // 
            chkLubrication.AutoSize = true;
            chkLubrication.Location = new Point(12, 54);
            chkLubrication.Name = "chkLubrication";
            chkLubrication.Size = new Size(190, 27);
            chkLubrication.TabIndex = 2;
            chkLubrication.Text = "潤滑保養 (NT$540)";
            chkLubrication.UseVisualStyleBackColor = true;
            // 
            // gbCleaning
            // 
            gbCleaning.Controls.Add(chkRadiatorFlush);
            gbCleaning.Controls.Add(chkTransmissionFlush);
            gbCleaning.Location = new Point(272, 16);
            gbCleaning.Name = "gbCleaning";
            gbCleaning.Size = new Size(232, 100);
            gbCleaning.TabIndex = 3;
            gbCleaning.TabStop = false;
            gbCleaning.Text = "清洗服務";
            // 
            // chkRadiatorFlush
            // 
            chkRadiatorFlush.AutoSize = true;
            chkRadiatorFlush.Location = new Point(12, 24);
            chkRadiatorFlush.Name = "chkRadiatorFlush";
            chkRadiatorFlush.Size = new Size(190, 27);
            chkRadiatorFlush.TabIndex = 4;
            chkRadiatorFlush.Text = "水箱清洗 (NT$900)";
            chkRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // chkTransmissionFlush
            // 
            chkTransmissionFlush.AutoSize = true;
            chkTransmissionFlush.Location = new Point(12, 54);
            chkTransmissionFlush.Name = "chkTransmissionFlush";
            chkTransmissionFlush.Size = new Size(222, 27);
            chkTransmissionFlush.TabIndex = 5;
            chkTransmissionFlush.Text = "變速箱清洗 (NT$2,400)";
            chkTransmissionFlush.UseVisualStyleBackColor = true;
            // 
            // gbOtherServices
            // 
            gbOtherServices.Controls.Add(chkInspection);
            gbOtherServices.Controls.Add(chkReplaceMuffler);
            gbOtherServices.Controls.Add(chkWheelAlignment);
            gbOtherServices.Location = new Point(16, 128);
            gbOtherServices.Name = "gbOtherServices";
            gbOtherServices.Size = new Size(240, 120);
            gbOtherServices.TabIndex = 6;
            gbOtherServices.TabStop = false;
            gbOtherServices.Text = "其他服務";
            // 
            // chkInspection
            // 
            chkInspection.AutoSize = true;
            chkInspection.Location = new Point(12, 24);
            chkInspection.Name = "chkInspection";
            chkInspection.Size = new Size(154, 27);
            chkInspection.TabIndex = 7;
            chkInspection.Text = "檢驗 (NT$450)";
            chkInspection.UseVisualStyleBackColor = true;
            // 
            // chkReplaceMuffler
            // 
            chkReplaceMuffler.AutoSize = true;
            chkReplaceMuffler.Location = new Point(12, 54);
            chkReplaceMuffler.Name = "chkReplaceMuffler";
            chkReplaceMuffler.Size = new Size(222, 27);
            chkReplaceMuffler.TabIndex = 8;
            chkReplaceMuffler.Text = "更換消音器 (NT$3,000)";
            chkReplaceMuffler.UseVisualStyleBackColor = true;
            // 
            // chkWheelAlignment
            // 
            chkWheelAlignment.AutoSize = true;
            chkWheelAlignment.Location = new Point(12, 84);
            chkWheelAlignment.Name = "chkWheelAlignment";
            chkWheelAlignment.Size = new Size(190, 27);
            chkWheelAlignment.TabIndex = 9;
            chkWheelAlignment.Text = "輪胎定位 (NT$600)";
            chkWheelAlignment.UseVisualStyleBackColor = true;
            // 
            // gbPartsLabor
            // 
            gbPartsLabor.Controls.Add(lblParts);
            gbPartsLabor.Controls.Add(txtParts);
            gbPartsLabor.Controls.Add(lblLaborHours);
            gbPartsLabor.Controls.Add(txtLaborHours);
            gbPartsLabor.Location = new Point(272, 128);
            gbPartsLabor.Name = "gbPartsLabor";
            gbPartsLabor.Size = new Size(232, 120);
            gbPartsLabor.TabIndex = 10;
            gbPartsLabor.TabStop = false;
            gbPartsLabor.Text = "零件和工時";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Location = new Point(12, 30);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(98, 23);
            lblParts.TabIndex = 11;
            lblParts.Text = "零件 (NT$)";
            // 
            // txtParts
            // 
            txtParts.Location = new Point(90, 26);
            txtParts.Name = "txtParts";
            txtParts.Size = new Size(120, 30);
            txtParts.TabIndex = 12;
            // 
            // lblLaborHours
            // 
            lblLaborHours.AutoSize = true;
            lblLaborHours.Location = new Point(12, 66);
            lblLaborHours.Name = "lblLaborHours";
            lblLaborHours.Size = new Size(117, 23);
            lblLaborHours.TabIndex = 13;
            lblLaborHours.Text = "工時數 (小時)";
            // 
            // txtLaborHours
            // 
            txtLaborHours.Location = new Point(120, 62);
            txtLaborHours.Name = "txtLaborHours";
            txtLaborHours.Size = new Size(90, 30);
            txtLaborHours.TabIndex = 14;
            // 
            // gbSummary
            // 
            gbSummary.Controls.Add(lblServiceLaborCost);
            gbSummary.Controls.Add(txtServiceLaborCost);
            gbSummary.Controls.Add(lblPartsCost);
            gbSummary.Controls.Add(txtPartsCost);
            gbSummary.Controls.Add(lblPartsTax);
            gbSummary.Controls.Add(txtPartsTax);
            gbSummary.Controls.Add(lblTotalCost);
            gbSummary.Controls.Add(txtTotalCost);
            gbSummary.Location = new Point(16, 267);
            gbSummary.Name = "gbSummary";
            gbSummary.Size = new Size(496, 113);
            gbSummary.TabIndex = 15;
            gbSummary.TabStop = false;
            gbSummary.Text = "費用摘要";
            // 
            // lblServiceLaborCost
            // 
            lblServiceLaborCost.AutoSize = true;
            lblServiceLaborCost.Location = new Point(12, 24);
            lblServiceLaborCost.Name = "lblServiceLaborCost";
            lblServiceLaborCost.Size = new Size(100, 23);
            lblServiceLaborCost.TabIndex = 16;
            lblServiceLaborCost.Text = "服務與工資";
            // 
            // txtServiceLaborCost
            // 
            txtServiceLaborCost.Location = new Point(120, 20);
            txtServiceLaborCost.Name = "txtServiceLaborCost";
            txtServiceLaborCost.ReadOnly = true;
            txtServiceLaborCost.Size = new Size(120, 30);
            txtServiceLaborCost.TabIndex = 17;
            // 
            // lblPartsCost
            // 
            lblPartsCost.AutoSize = true;
            lblPartsCost.Location = new Point(12, 46);
            lblPartsCost.Name = "lblPartsCost";
            lblPartsCost.Size = new Size(46, 23);
            lblPartsCost.TabIndex = 18;
            lblPartsCost.Text = "零件";
            // 
            // txtPartsCost
            // 
            txtPartsCost.Location = new Point(120, 44);
            txtPartsCost.Name = "txtPartsCost";
            txtPartsCost.ReadOnly = true;
            txtPartsCost.Size = new Size(120, 30);
            txtPartsCost.TabIndex = 19;
            // 
            // lblPartsTax
            // 
            lblPartsTax.AutoSize = true;
            lblPartsTax.Location = new Point(260, 24);
            lblPartsTax.Name = "lblPartsTax";
            lblPartsTax.Size = new Size(99, 23);
            lblPartsTax.TabIndex = 20;
            lblPartsTax.Text = "稅金 (零件)";
            // 
            // txtPartsTax
            // 
            txtPartsTax.Location = new Point(350, 20);
            txtPartsTax.Name = "txtPartsTax";
            txtPartsTax.ReadOnly = true;
            txtPartsTax.Size = new Size(120, 30);
            txtPartsTax.TabIndex = 21;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(260, 46);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(64, 23);
            lblTotalCost.TabIndex = 22;
            lblTotalCost.Text = "總費用";
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(350, 44);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(120, 30);
            txtTotalCost.TabIndex = 23;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(72, 400);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 28);
            btnCalculate.TabIndex = 24;
            btnCalculate.Text = "計算總額";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(210, 400);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 28);
            btnClear.TabIndex = 25;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(348, 400);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 28);
            btnExit.TabIndex = 26;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 608);
            Controls.Add(gbOilLubrication);
            Controls.Add(gbCleaning);
            Controls.Add(gbOtherServices);
            Controls.Add(gbPartsLabor);
            Controls.Add(gbSummary);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "汽車維修服務";
            Click += calculateButton_Click;
            gbOilLubrication.ResumeLayout(false);
            gbOilLubrication.PerformLayout();
            gbCleaning.ResumeLayout(false);
            gbCleaning.PerformLayout();
            gbOtherServices.ResumeLayout(false);
            gbOtherServices.PerformLayout();
            gbPartsLabor.ResumeLayout(false);
            gbPartsLabor.PerformLayout();
            gbSummary.ResumeLayout(false);
            gbSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
