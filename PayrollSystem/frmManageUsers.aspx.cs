using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmManageUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Needed to validate security level of user.
        if (Session["SecurityLevel"] != "A")
        {
            Response.Redirect("frmLogin.aspx");
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnAddUser_Click(object sender, EventArgs e)
    {
        clsDataLayer.SaveUser(Server.MapPath("PayrollSystem_DB.accdb"), txtUserName.Text, txtPassword.Text, ddlSecurityLevel.SelectedValue);

        if (clsDataLayer.SaveUser(Server.MapPath("PayrollSystem_DB.accdb"), txtUserName.Text, txtPassword.Text, ddlSecurityLevel.SelectedValue))
        {
            lblError.Text = "The user was successfully added!";
            grdUsers.DataBind();
        } 


    }
}