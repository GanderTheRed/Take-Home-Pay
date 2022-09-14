namespace Take_Home_Pay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblTodaysDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblHourlyWage = new System.Windows.Forms.Label();
            this.txtWage = new System.Windows.Forms.TextBox();
            this.lblAveragePay = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPayPeriod = new System.Windows.Forms.Label();
            this.cmbPayPeriod = new System.Windows.Forms.ComboBox();
            this.lblExpectedPay = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Location = new System.Drawing.Point(12, 9);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(108, 15);
            this.lblTodaysDate.TabIndex = 1;
            this.lblTodaysDate.Text = "Insert Todays Date :";
            this.lblTodaysDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(175, 6);
            this.txtDate.Name = "txtDate";
            this.txtDate.PlaceholderText = "DD/MM/YYYY";
            this.txtDate.Size = new System.Drawing.Size(236, 23);
            this.txtDate.TabIndex = 2;
            // 
            // lblHourlyWage
            // 
            this.lblHourlyWage.AutoSize = true;
            this.lblHourlyWage.Location = new System.Drawing.Point(12, 38);
            this.lblHourlyWage.Name = "lblHourlyWage";
            this.lblHourlyWage.Size = new System.Drawing.Size(123, 15);
            this.lblHourlyWage.TabIndex = 3;
            this.lblHourlyWage.Text = "Hourly Wage (CAD$) :";
            // 
            // txtWage
            // 
            this.txtWage.Location = new System.Drawing.Point(175, 35);
            this.txtWage.Name = "txtWage";
            this.txtWage.PlaceholderText = "15.00";
            this.txtWage.Size = new System.Drawing.Size(236, 23);
            this.txtWage.TabIndex = 4;
            // 
            // lblAveragePay
            // 
            this.lblAveragePay.AutoSize = true;
            this.lblAveragePay.Location = new System.Drawing.Point(12, 67);
            this.lblAveragePay.Name = "lblAveragePay";
            this.lblAveragePay.Size = new System.Drawing.Size(147, 15);
            this.lblAveragePay.TabIndex = 5;
            this.lblAveragePay.Text = "Average Paycheck (CAD$):";
            this.lblAveragePay.Click += new System.EventHandler(this.lblAveragePay_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "600.00";
            this.textBox1.Size = new System.Drawing.Size(236, 23);
            this.textBox1.TabIndex = 6;
            // 
            // lblPayPeriod
            // 
            this.lblPayPeriod.AutoSize = true;
            this.lblPayPeriod.Location = new System.Drawing.Point(12, 100);
            this.lblPayPeriod.Name = "lblPayPeriod";
            this.lblPayPeriod.Size = new System.Drawing.Size(69, 15);
            this.lblPayPeriod.TabIndex = 7;
            this.lblPayPeriod.Text = "Pay Period :";
            // 
            // cmbPayPeriod
            // 
            this.cmbPayPeriod.FormattingEnabled = true;
            this.cmbPayPeriod.Items.AddRange(new object[] {
            "Weekly",
            "Bi-Weekly",
            "Monthly"});
            this.cmbPayPeriod.Location = new System.Drawing.Point(175, 93);
            this.cmbPayPeriod.Name = "cmbPayPeriod";
            this.cmbPayPeriod.Size = new System.Drawing.Size(236, 23);
            this.cmbPayPeriod.TabIndex = 8;
            // 
            // lblExpectedPay
            // 
            this.lblExpectedPay.AutoSize = true;
            this.lblExpectedPay.Location = new System.Drawing.Point(12, 196);
            this.lblExpectedPay.Name = "lblExpectedPay";
            this.lblExpectedPay.Size = new System.Drawing.Size(166, 15);
            this.lblExpectedPay.TabIndex = 9;
            this.lblExpectedPay.Text = "Expected Pay This Pay Period :";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(184, 196);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(45, 15);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "Output";
            this.lblOutput.Visible = false;
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(303, 241);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 32);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(303, 187);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 32);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 336);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblExpectedPay);
            this.Controls.Add(this.cmbPayPeriod);
            this.Controls.Add(this.lblPayPeriod);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAveragePay);
            this.Controls.Add(this.txtWage);
            this.Controls.Add(this.lblHourlyWage);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblTodaysDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTodaysDate;
        private TextBox txtDate;
        private Label lblHourlyWage;
        private TextBox txtWage;
        private Label lblAveragePay;
        private TextBox textBox1;
        private Label lblPayPeriod;
        private ComboBox cmbPayPeriod;
        private Label lblExpectedPay;
        private Label lblOutput;
        private Button btnExit;
        private Button btnCalculate;
    }
}