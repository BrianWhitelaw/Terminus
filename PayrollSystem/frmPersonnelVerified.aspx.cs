using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmPersonnelVerified : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
// The code below was provided by Prof. Jon Jensen of DeVry University
        /* 
         * The code below gathers input from frmPersonnel.aspx and displays it 
         *    in a format that resembles the same layout as the input layout. "\n"
         *    creates a new line.
         */
        txtVerifiedInfo.Text = Session["txtFirstName"] +
           "\n" + Session["txtLastName"] +
           "\n" + "$" + Session["txtPayRate"] +
           "\n" + Session["txtStartDate"] +
           "\n" + Session["txtEndDate"];

        // If Else statement to verify the saving of data from frmPersonnel.aspx
        if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.accdb"),
            Session["txtFirstName"].ToString(),
            Session["txtLastName"].ToString(),
            Session["txtPayRate"].ToString(),
            Session["txtStartDate"].ToString(),
            Session["txtEndDate"].ToString()))
            {
                txtVerifiedInfo.Text = txtVerifiedInfo.Text + "\nThe information was successfully saved!";
            }
        else
            {
                txtVerifiedInfo.Text = txtVerifiedInfo.Text + "\nThe information was NOT saved.";
            }
    }
    protected void txtVerifiedInfo_TextChanged(object sender, EventArgs e)
    {
        
    }
}