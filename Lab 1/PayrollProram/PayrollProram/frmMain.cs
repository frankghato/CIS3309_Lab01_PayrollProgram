/*
Frank Gatto
9/8/21
Lab 1 Part 1
Payroll Program - calculates net pay based on hourly wage, hours work, and tax deductions
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

namespace PayrollProram
{
    public partial class frmMain : Form
    {
        //declaring constants for tax deductions 
        const double STATE_TAX_PERCENTAGE = .035;
        const double FEDERAL_TAX_PERCETANGE = .15;
        const double SOCIAL_SECURITY_TAX_PERCTANGE = .062;
        const double MEDICARE_TAX_PERCTANGE = .029;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clearing any potential text from form
            txtHourlyRate.Text = "";
            txtHoursWorked.Text = "";
            lblDisplay.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculatePay_Click(object sender, EventArgs e)
        {
            //showing an error if calculate is clicked before filling in both text boxes
            if(txtHourlyRate.Equals(""))
            {
                MessageBox.Show("You must enter an hourly rate!", "Hourly Rate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(txtHoursWorked.Equals(""))
            {
                MessageBox.Show("You must the number of hours worked!", "Hours Worked Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //checking if hourly rate and hours worked can be parsed and calculating pay if so
            //if not shows an error message
            double parsedHourlyRate;
            if (double.TryParse(txtHourlyRate.Text, out parsedHourlyRate))
            {
                double parsedHoursWorked;
                if (double.TryParse(txtHoursWorked.Text, out parsedHoursWorked))
                {
                    calculatePay(parsedHourlyRate, parsedHoursWorked);
                }
                else
                {
                    MessageBox.Show("You must enter a number for hours worked!", "Hours Worked Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You must enter a valid number for hourly rate!", "Hourly Rate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void calculatePay(double hourlyRate, double hoursWorked)
        {
            //calculates gross pay, deducts all taxes, and then calculates net pay
            double grossPay = Math.Round(hourlyRate * hoursWorked,2);
            double stateTaxDeduction = Math.Round(grossPay * STATE_TAX_PERCENTAGE,2);
            double federalTaxDeduction = Math.Round(grossPay * FEDERAL_TAX_PERCETANGE,2);
            double ficaDeduction = Math.Round((grossPay * SOCIAL_SECURITY_TAX_PERCTANGE) + (grossPay * MEDICARE_TAX_PERCTANGE),2);
            double netPay = Math.Round(grossPay - stateTaxDeduction - federalTaxDeduction - ficaDeduction,2);
            lblDisplay.Text = "Gross Pay: $" + grossPay + "\nState Tax Deduction: $" + stateTaxDeduction + "\nFederal Tax Deduction: $" + federalTaxDeduction + "\nFICA deductions: $" + ficaDeduction + "\nNet Pay: $" + netPay;
        }
    }
}
