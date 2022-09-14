namespace Take_Home_Pay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAveragePay_Click(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Convert all text inputs to integers
            int HourlyWage = Convert.ToInt32(txtWage.Text);
            int HoursWorked = Convert.ToInt32(txtHoursWorked.Text);
            int YearlyPay = Convert.ToInt32(txtYearlyPay.Text);
            int PayPeriod = 0;
            string PayPeriodInput = cmbPayPeriod.Text;
            //Convert pay period input to a number
            if (PayPeriodInput == "Weekly") 
            {
                PayPeriod = 1;
            }
            else if (PayPeriodInput == "Bi-Weekly") 
            {
                PayPeriod = 2;
            }
            else if (PayPeriodInput == "Monthly") 
            {
                PayPeriod = 3;
            } else
            {
                MessageBox.Show("Please enter a value into Pay Period.");
            }
        
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWage_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void msktxtTodays_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Please input a date with the correct formatting");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblExpectedPay_Click(object sender, EventArgs e)
        {

        }
    }
}