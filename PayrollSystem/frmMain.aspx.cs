using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Creates a path to the database from the main page
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), "frmPersonnel");

        // Initialize all Admin controls to off at page load event
        linkbtnCalculator.Visible = true;
        imgbtnCalculator.Visible = true;
	    linkbtnNewEmployee.Visible = false;
        imgbtnNewEmployee.Visible = false;
        linkbtnViewUserActivity.Visible = false;
        imgbtnViewUserActivity.Visible = false;
        linkbtnViewPersonnel.Visible = true;
        imgbtnViewPersonnel.Visible = true;
        linkbtnSearch.Visible = true;
        imgbtnSearch.Visible = true;
        linkbtnEditEmployees.Visible = false;
        imgbtnEditEmployees.Visible = false;
        linkbtnManageUsers.Visible = false;
        imgbtnManageUsers.Visible = false;
        
        // If statement to verify Admin rights.  Adds adminstrative buttons for Admin users.
        if (Session["SecurityLevel"] == "A")
        {
            linkbtnNewEmployee.Visible = true;
            imgbtnNewEmployee.Visible = true;
            linkbtnViewUserActivity.Visible = true;
            imgbtnViewUserActivity.Visible = true;
            linkbtnEditEmployees.Visible = true;
            imgbtnEditEmployees.Visible = true;
            linkbtnManageUsers.Visible = true;
            imgbtnManageUsers.Visible = true;
        }
    }
    protected void btnAnnualSalaryCalculator_Click(object sender, EventArgs e)
    {

    }
}