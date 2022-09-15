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
            this.components = new System.ComponentModel.Container();
            this.lblAvgHourlyWage = new System.Windows.Forms.Label();
            this.lblAveragePay = new System.Windows.Forms.Label();
            this.txtYearlyPay = new System.Windows.Forms.TextBox();
            this.lblExpectedPay = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblHourlyWageOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvgHourlyWage
            // 
            this.lblAvgHourlyWage.AutoSize = true;
            this.lblAvgHourlyWage.Location = new System.Drawing.Point(12, 67);
            this.lblAvgHourlyWage.Name = "lblAvgHourlyWage";
            this.lblAvgHourlyWage.Size = new System.Drawing.Size(147, 15);
            this.lblAvgHourlyWage.TabIndex = 3;
            this.lblAvgHourlyWage.Text = "Avg Hourly Wage (CAD$) :";
            // 
            // lblAveragePay
            // 
            this.lblAveragePay.AutoSize = true;
            this.lblAveragePay.Location = new System.Drawing.Point(12, 9);
            this.lblAveragePay.Name = "lblAveragePay";
            this.lblAveragePay.Size = new System.Drawing.Size(207, 15);
            this.lblAveragePay.TabIndex = 5;
            this.lblAveragePay.Text = "Average Yearly Pay Before Tax (CAD$):";
            this.lblAveragePay.Click += new System.EventHandler(this.lblAveragePay_Click);
            // 
            // txtYearlyPay
            // 
            this.txtYearlyPay.Location = new System.Drawing.Point(242, 6);
            this.txtYearlyPay.Name = "txtYearlyPay";
            this.txtYearlyPay.PlaceholderText = "40000";
            this.txtYearlyPay.Size = new System.Drawing.Size(100, 23);
            this.txtYearlyPay.TabIndex = 6;
            // 
            // lblExpectedPay
            // 
            this.lblExpectedPay.AutoSize = true;
            this.lblExpectedPay.Location = new System.Drawing.Point(12, 274);
            this.lblExpectedPay.Name = "lblExpectedPay";
            this.lblExpectedPay.Size = new System.Drawing.Size(345, 15);
            this.lblExpectedPay.TabIndex = 9;
            this.lblExpectedPay.Text = "Expected Pay This Pay Period (Before Union Dues, Benefits, Etc) :";
            this.lblExpectedPay.Click += new System.EventHandler(this.lblExpectedPay_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(363, 274);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(45, 15);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "Output";
            this.lblOutput.Visible = false;
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(363, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 32);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(242, 93);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 32);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(12, 38);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(141, 15);
            this.lblHoursWorked.TabIndex = 14;
            this.lblHoursWorked.Text = "Hours Worked Per Week :";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(242, 35);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.PlaceholderText = "40";
            this.txtHoursWorked.Size = new System.Drawing.Size(100, 23);
            this.txtHoursWorked.TabIndex = 15;
            this.txtHoursWorked.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblHourlyWageOut
            // 
            this.lblHourlyWageOut.AutoSize = true;
            this.lblHourlyWageOut.Location = new System.Drawing.Point(242, 67);
            this.lblHourlyWageOut.Name = "lblHourlyWageOut";
            this.lblHourlyWageOut.Size = new System.Drawing.Size(38, 15);
            this.lblHourlyWageOut.TabIndex = 16;
            this.lblHourlyWageOut.Text = "label1";
            this.lblHourlyWageOut.Visible = false;
            this.lblHourlyWageOut.Click += new System.EventHandler(this.lblHourlyWageOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 454);
            this.Controls.Add(this.lblHourlyWageOut);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblExpectedPay);
            this.Controls.Add(this.txtYearlyPay);
            this.Controls.Add(this.lblAveragePay);
            this.Controls.Add(this.lblAvgHourlyWage);
            this.Name = "Form1";
            this.Text = "Take Home Pay Calculator 2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblAvgHourlyWage;
        private Label lblAveragePay;
        private TextBox txtYearlyPay;
        private Label lblExpectedPay;
        private Label lblOutput;
        private Button btnExit;
        private Button btnCalculate;
        private Label lblHoursWorked;
        private TextBox txtHoursWorked;
        private ErrorProvider errorProvider1;
        private Label lblHourlyWageOut;
    }
}