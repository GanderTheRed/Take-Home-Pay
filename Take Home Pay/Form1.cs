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
            
            double TaxCalcMarginal()
            {
                
                
                // Marginal tax rate area
                double MarginalTax = 0;
                
                //Calculation for marginal tax rate
              
                    if (YearlyPay < 14398) //Basic personal amount
                    {
                        return MarginalTax = 0;
                    }
                    else if ((YearlyPay > 14398) ^ (YearlyPay <= 50197)) //Tax rates for each amount.
                    {
                        return MarginalTax = 1.25;
                    } 
                    else if ((YearlyPay > 50197) ^ (YearlyPay <= 100392))
                    {
                        return MarginalTax = 1.305;
                    }
                    else if ((YearlyPay > 100392) ^ (YearlyPay <= 131220))
                    {
                        return MarginalTax =  1.36;
                    }
                    else if ((YearlyPay > 131220) ^ (YearlyPay <= 155625))
                    {
                        return MarginalTax = 1.38;
                    }
                    else if ((YearlyPay > 155625) ^ (YearlyPay <= 157464))
                    {
                        return MarginalTax =  1.4138;
                    }
                    else if ((YearlyPay > 157464) ^ (YearlyPay <= 209952))
                    {
                        return MarginalTax = 1.4238;
                    }
                    else if ((YearlyPay > 209952) ^ (YearlyPay <= 221708))
                    {
                        return MarginalTax = 1.4338;
                    }
                    else if ((YearlyPay > 221708) ^ (YearlyPay <= 314928))
                    {
                        return MarginalTax = 1.47;
                    }
                    else if (YearlyPay > 314928)
                    {
                        return MarginalTax = 1.48;
                    }
                    else
                    {
                        MessageBox.Show("Please insert a valid input (Only Numbers)");
                    }
                    return MarginalTax;

                
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