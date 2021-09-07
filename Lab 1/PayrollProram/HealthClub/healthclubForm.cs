/*
Frank Gatto
9/8/21
Lab 1 Part 2
Health Club Form - calculates monthly and total fee of a health club member based on membership type, optional additions, and the length of the membership
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthClub
{
    public partial class healthclubForm : Form
    {
        //declaring constants for various fees
        const double ADULT_MEMBERSHIP = 40;
        const double CHILD_MEMBERSHIP = 20;
        const double STUDENT_MEMBERSHIP = 25;
        const double SENIOR_MEMBERSHIP = 30;
        const double YOGA_FEE = 10;
        const double KARATE_FEE = 30;
        const double PERSONAL_TRAINER_FEE = 50;

        public healthclubForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void healthclubForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clearing all potentially filled in fields
            radAdult.Checked = false;
            radChild.Checked = false;
            radSenior.Checked = false;
            radStudent.Checked = false;
            chkYoga.Checked = false;
            chkKarate.Checked = false;
            chkTrainer.Checked = false;
            lblMonthlyFee.Text = "";
            lblTotalFee.Text = "";
            txtMonths.Text =  "";
        }

        private void txtMonths_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //checking if months can be parsed, calculating the total fee if so
            //and showing an error message if not 
            double parsedMonths;
            if(double.TryParse(txtMonths.Text, out parsedMonths))
            {
                calculateTotalFee(parsedMonths);
            }
            else
            {
                MessageBox.Show("You must enter a valid number of months!", "Number of Months Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double calculateMonthlyFee()
        {
            //calculating the monthly fee based on membership type and optional fees
            //or shows an error and exits the function if there is no membership type selected
            double monthlyFee = 0;
            if (radAdult.Checked)
            {
                monthlyFee += ADULT_MEMBERSHIP;
            }
            else if (radChild.Checked)
            {
                monthlyFee += CHILD_MEMBERSHIP;
            }
            else if (radStudent.Checked)
            {
                monthlyFee += STUDENT_MEMBERSHIP;
            }
            else if (radSenior.Checked)
            {
                monthlyFee += SENIOR_MEMBERSHIP;
            }
            else
            {
                MessageBox.Show("You must select a membership type!", "Membership Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if(chkYoga.Checked)
            {
                monthlyFee += YOGA_FEE;
            }
            if(chkKarate.Checked)
            {
                monthlyFee += KARATE_FEE;
            }
            if(chkTrainer.Checked)
            {
                monthlyFee += PERSONAL_TRAINER_FEE;
            }

            monthlyFee = Math.Round(monthlyFee, 2);

            lblMonthlyFee.Text = "$" + monthlyFee.ToString();

            return monthlyFee;
        }
        private void calculateTotalFee(double numMonths)
        {
            double totalFee = Math.Round(calculateMonthlyFee() * numMonths, 2);

            lblTotalFee.Text = "$" + totalFee.ToString();
        } 
    }
}
