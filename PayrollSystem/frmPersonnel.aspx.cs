using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Threading;


public partial class frmPersonnel : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        // Needed to validate security level of user.
        if (Session["SecurityLevel"] != "A")
        {
            Response.Redirect("frmLogin.aspx");
        }

        // If statement to allow valid SecurityLevel of A (Admin)
        if (Session["SecurityLevel"] == "A")
        {
            btnSubmit.Visible = true;
        }
        // Else portion to be used if user is not approved for Admin rights
        else
        {
            btnSubmit.Visible = false;
        }
    }
    protected void txtPayRate_TextChanged(object sender, EventArgs e)
    {
        //Double payRate = 0.00;
        //payRate = Double.Parse(txtPayRate.Text);
        String payRate = "";
        payRate = txtPayRate.Text;

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        // Initialize variables
        bool error = false;
        lblError.Text = "";

        // Initializes text box colors to white (used to reset color once errors have been corrected.)
        txtFirstName.BackColor = System.Drawing.Color.White;
        txtLastName.BackColor = System.Drawing.Color.White;
        txtPayRate.BackColor = System.Drawing.Color.White;
        txtStartDate.BackColor = System.Drawing.Color.White;
        txtEndDate.BackColor = System.Drawing.Color.White;


        // If statements for data population validation.  
        // %.BackColor... Alters the background color of the mentioned textbox.
        // <br> adds a linebreak in the output of the lblError.
        // &nbsp adds a "no-break space" to the line.
        
        if (txtFirstName.Text.Trim() == "")
        {
            error = true;
            txtFirstName.BackColor = System.Drawing.Color.Yellow;
            lblError.Text = lblError.Text + "<br>&nbsp&nbsp&nbsp You must enter a First Name. &nbsp&nbsp&nbsp";
        }

        if (txtLastName.Text.Trim() == "")
        {
            error = true;
            txtLastName.BackColor = System.Drawing.Color.Yellow;
            lblError.Text = "\n" + lblError.Text + "<br>&nbsp&nbsp&nbsp You must enter a Last Name. &nbsp&nbsp&nbsp";
        }

        if (txtPayRate.Text.Trim() == "")
        {
            error = true;
            txtPayRate.BackColor = System.Drawing.Color.Yellow;
            lblError.Text = lblError.Text + "<br>&nbsp&nbsp&nbsp You must enter a Pay Rate. &nbsp&nbsp&nbsp";
        }

        if (txtStartDate.Text.Trim() == "")
        {
            error = true;
            txtStartDate.BackColor = System.Drawing.Color.Yellow;
            lblError.Text = lblError.Text + "<br>&nbsp&nbsp&nbsp You must enter a Start Date. &nbsp&nbsp&nbsp";
        }

        if (txtEndDate.Text.Trim() == "")
        {
            error = true;
            txtEndDate.BackColor = System.Drawing.Color.Yellow;
            lblError.Text = lblError.Text + "<br>&nbsp&nbsp&nbsp You must enter a End Date. &nbsp&nbsp&nbsp";
        }

        // Date Validation Section if no Error exists

        if (!error)
        {
            try
            {
                // Instantiate DateTime variables.
                DateTime startDate = new DateTime();
                DateTime endDate = new DateTime();

                startDate = DateTime.Parse(txtStartDate.Text);
                endDate = DateTime.Parse(txtEndDate.Text);

                // Nested if statement for invalid dates
                if (DateTime.Compare(startDate, endDate) >= 0)
                {
                    error = true;
                    txtStartDate.BackColor = System.Drawing.Color.Yellow;
                    txtEndDate.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text = lblError.Text + "<br>&nbsp&nbsp&nbsp Start Date must occur before End Date. &nbsp&nbsp&nbsp";
                }
            }

            catch
            {
                lblError.Text = lblError.Text + "<br>&nbsp&nbsp&nbsp You must enter a valid Date. &nbsp&nbsp&nbsp";
            }
        }

        if (!error)
        {
            Session["txtFirstName"] = txtFirstName.Text;
            Session["txtLastName"] = txtLastName.Text;
            Session["txtPayRate"] = txtPayRate.Text;
            Session["txtStartDate"] = txtStartDate.Text;
            Session["txtEndDate"] = txtEndDate.Text;

            Response.Redirect("frmPersonnelVerified.aspx");
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)

    {
       
    }
}