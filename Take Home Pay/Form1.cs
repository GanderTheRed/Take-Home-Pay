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
            
            int TaxCalcMarginal()
            {
                // Marginal tax rate area
                int MarginalTax = 0;
                
                //Calculation for marginal tax rate
                //Return to resolve errors for now
                if (YearlyPay < 14398)
                {
                    return 0;
                }
                else if (YearlyPay > 100000) //replace with correct number
                {
                    return 0;
                } 
                else
                {
                    return 0;
                }
            }
             int TaxCalcAlberta()
            {
                //Alberta tax calc
                int AlbertaTax = 0;
                //Return to resolve errors for now
                return 1;
            }

            //





            //Final calc                








            lblOutput.Text = "$" + Convert.ToString(HourlyWage * HoursWorked);
            lblOutput.Visible = true;
            
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