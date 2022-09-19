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
            //Form inputs
            //Convert all text inputs to integers
            double HoursWorked = Convert.ToDouble(txtHoursWorked.Text);
            double YearlyPay = Convert.ToDouble(txtYearlyPay.Text);
            double OvertimeRate = Convert.ToDouble(txtOvertimeRate.Text);
            double OvertimeHours = Convert.ToDouble(txtOvertimeHours.Text);
            
            //Coverts Yearly Pay to an Average Hourly Wage
            double HourlyWageCalc()
            {
                double HourlyWage = YearlyPay / (HoursWorked * 52);
                return HourlyWage;
            }


            //Methods
                double TaxCalcMarginal()
                {                        
                    // Marginal tax rate area
                    double MarginalTax = 0;
                
                    //Calculation for marginal tax rate based off of 2021 rates
              
                        if (YearlyPay <= 14398) //Basic personal amount
                        {
                            return MarginalTax = 1;
                        }
                        else if ((YearlyPay > 14398) ^ (YearlyPay <= 50197)) //Tax rates for each range.
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
                double TaxCalcAlberta()
                {                                               
                    //Alberta tax calc
                    double AlbertaTax = 0;
                    //Calculation for Alberta tax based off of 2021 rates.
                        if (YearlyPay <= 19369) //Basic personal amount
                        {
                            return AlbertaTax = 1;
                        }
                        else if ((YearlyPay > 19369) ^ (YearlyPay <= 131220)) //Tax rates for each range.
                        {
                            return AlbertaTax = 1.10;
                        }
                        else if ((YearlyPay > 131220) ^ (YearlyPay <= 157464))
                        {
                            return AlbertaTax = 1.12;
                        }
                        else if ((YearlyPay > 157464) ^ (YearlyPay <= 209952))
                        {
                            return AlbertaTax = 1.13;
                        }
                        else if ((YearlyPay > 209952) ^ (YearlyPay <= 314928))
                        {
                            return AlbertaTax = 1.14;
                        }
                        else if (YearlyPay > 314928)
                        {
                            return AlbertaTax = 1.15;
                        }
                        else
                        {
                            MessageBox.Show("Please insert a valid input (Only Numbers)");
                        }
                    return AlbertaTax;
                }

            //Overtime calculations.
                double OvertimeCalc()
            {
                if(OvertimeHours == 0)
                {
                    return 1;
                }
                else if (OvertimeHours < 0)
                {
                    MessageBox.Show("Please enter a positive value for Overtime Hours.");
                    return 0;
                }
                else
                {
                    //Calculates overtime pay based off of Hourly Wage calculation.
                    return (OvertimeHours * (HourlyWageCalc() * OvertimeRate));
                                }
            }
            
            //Calculations
            double HourlyWage = HourlyWageCalc();

            //Method storage
                //Tax Rates
                double TaxRateAlberta = TaxCalcAlberta();
                    double TaxRateMarginal = TaxCalcMarginal();
                    double PayPeriod = HourlyWageCalc() * HoursWorked;
           

            //Final calculation                
            double FinalCalc()
            {   
                if (OvertimeHours > 0)
                {
                    //Involves Overtime Calculation
                    double FinalPayPeriod = PayPeriod - (PayPeriod - (PayPeriod * TaxRateAlberta)) + (PayPeriod - (PayPeriod * TaxRateMarginal));
                    double FinalOvertime = OvertimeCalc();
                    return FinalPayPeriod + FinalOvertime;
                } else
                {
                    //Doesn`t involve Overtime Calculation
                    double FinalPayPeriod = PayPeriod - (PayPeriod - (PayPeriod * TaxRateAlberta)) + (PayPeriod - (PayPeriod * TaxRateMarginal));
                    return FinalPayPeriod;
                }
                
            }

            //Formatting of Final Calculations to two decimal points
            lblOutput.Text = "$" + String.Format("{0:0.00}", FinalCalc());

            //Invisible until calculate button has been pressed
            lblOutput.Visible = true;
            lblHourlyWageOut.Visible = true;
            lblHourlyWageOut.Text = "$" + String.Format("{0:0.00}", HourlyWage);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblHourlyWageOut_Click(object sender, EventArgs e)
        {

        }

        private void lblHoursWorked_Click(object sender, EventArgs e)
        {

        }
    }
}