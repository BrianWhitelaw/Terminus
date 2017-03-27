/*
 *CIS_407A_Week1_iLab
 *Developed By: Brian Whitelaw
 *Prepared For: Prof. Jon Jensen
 *DeVry University Online
 *Program Name: Salary Calculator
 *Nature and Necessity: The intent of this program is to allow users to input
 *  values into textboxes.  The "Calculate Pay" button can be pushed which will
 *  display a value equal to the annual salary of an employee.
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmSalaryCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCalculateSalary_Click(object sender, EventArgs e)
    {
        // Declare variables
        Double annHours = 0.00;     // Hours per year
        Double payRate = 0.00;      // Hourly pay rate
        Double annSalary = 0.00;    // Annual salary

        // Gather inputs
        annHours = Double.Parse(txtAnnualHours.Text);
        payRate = Double.Parse(txtPayRate.Text);

        // Perform calculations
        annSalary = annHours * payRate;

        // Display outputs in numerical format USD
        lblAnnualSalary.Text = "Annual Salary is: $ " + annSalary.ToString("N");
    }
    protected void txtAnnualHours_TextChanged(object sender, EventArgs e)
    {
     
    }
}