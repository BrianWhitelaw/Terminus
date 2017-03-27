using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        // Calls dsUser class
        dsUser dsUserLogin;
        // Initializes SecurityLevel as a String variable
        string SecurityLevel;
        // Verifies user against approved users from database
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.accdb"),
        Login1.UserName, Login1.Password);
        // If statement to validate login attempt
        if (dsUserLogin.tblUserLogin.Count < 1)
        {
            e.Authenticated = false;

            // Nested if statement to call SendEmail method if an invalid login is attempted.
            if (clsBusinessLayer.SendEmail("MelissaWhitelaw@yahoo.com",
            "C.Brian.Whitelaw@gmail.com", "", "", "Login Incorrect",
            "The login failed for UserName: " + Login1.UserName +
            " Password: " + Login1.Password))
            {
                Login1.FailureText = Login1.FailureText +
                " Your incorrect login information was sent to C.Brian.Whitelaw@gmail.com";
            }
            return;
        }
        // Reassigns SecurityLevel based on database information
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();
        // Switch Case to control SecurityLevel of user
        switch (SecurityLevel)
        {
            case "A":
                // Case A used for validated user = Admin
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "A";
                break;
            case "U":
                // Case U used for validated user = nonAdmin
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "U";
                break;
                // Case default used for invalid users
            default:
                e.Authenticated = false;
                break;
        }
    }
}