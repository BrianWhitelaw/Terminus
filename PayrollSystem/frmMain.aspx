<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="position: relative; text-align: left">
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/Images/ACITLogo.jpg" TabIndex="2" Width="500px" />
    
    </div>
        <p>
            <asp:ImageButton ID="imgbtnCalculator" runat="server" Height="49px" ImageUrl="~/Images/blue-metallic-orb-icon-business-calculator.png" PostBackUrl="~/frmSalaryCalculator.aspx" TabIndex="3" Width="49px" AccessKey="C" AlternateText="Annual Salary Calculator" />
&nbsp;<asp:LinkButton ID="linkbtnCalculator" runat="server" OnClick="btnAnnualSalaryCalculator_Click" PostBackUrl="~/frmSalaryCalculator.aspx" TabIndex="4" AccessKey="C">Annual Salary Calculator</asp:LinkButton>
        </p>
        <p>
            <asp:ImageButton ID="imgbtnNewEmployee" runat="server" Height="49px" ImageUrl="~/Images/TeamPuzzle.jpg" PostBackUrl="~/frmPersonnel.aspx" TabIndex="5" Width="49px" AccessKey="P" AlternateText="Personnel" />
&nbsp;<asp:LinkButton ID="linkbtnNewEmployee" runat="server" PostBackUrl="~/frmPersonnel.aspx" TabIndex="6" AccessKey="P" ToolTip="Add a new employee" ViewStateMode="Enabled">Add New Employee</asp:LinkButton>
        </p>
        <p>
            <asp:ImageButton ID="imgbtnViewUserActivity" runat="server" AccessKey="U" AlternateText="User Activity" Height="49px" ImageUrl="~/Images/UserActivities.jpg" PostBackUrl="~/frmUserActivity.aspx" TabIndex="7" Width="49px" />
&nbsp;<asp:LinkButton ID="linkbtnViewUserActivity" runat="server" AccessKey="U" PostBackUrl="~/frmUserActivity.aspx" TabIndex="8">View User Activity</asp:LinkButton>
        </p>
        <p>
            <asp:ImageButton ID="imgbtnViewPersonnel" runat="server" AccessKey="E" AlternateText="View Personnel" Height="49px" ImageUrl="~/Images/troops.png" PostBackUrl="~/frmViewPersonnel.aspx" TabIndex="9" Width="49px" />
&nbsp;<asp:LinkButton ID="linkbtnViewPersonnel" runat="server" AccessKey="E" PostBackUrl="~/frmViewPersonnel.aspx" TabIndex="10">View Personnel</asp:LinkButton>
        </p>
        <p>
            <asp:ImageButton ID="imgbtnSearch" runat="server" AccessKey="S" AlternateText="Search" Height="49px" ImageUrl="~/Images/search.png" PostBackUrl="~/frmSearchPersonnel.aspx" TabIndex="11" Width="49px" />
&nbsp;<asp:LinkButton ID="linkbtnSearch" runat="server" AccessKey="S" PostBackUrl="~/frmSearchPersonnel.aspx" TabIndex="12" ToolTip="Search the Database">Search Personnel</asp:LinkButton>
        </p>
        <p>
            <asp:ImageButton ID="imgbtnEditEmployees" runat="server" AlternateText="Edit Employees" Height="49px" ImageUrl="~/Images/editLogo.jpg" PostBackUrl="~/frmEditPersonnel.aspx" TabIndex="13" Width="49px" />
&nbsp;<asp:LinkButton ID="linkbtnEditEmployees" runat="server" AccessKey="E" PostBackUrl="~/frmEditPersonnel.aspx" TabIndex="14" ToolTip="Edit Personnel">Edit Employees</asp:LinkButton>
        </p>
        <p>
            <asp:ImageButton ID="imgbtnManageUsers" runat="server" AlternateText="Manage Users" Height="49px" ImageUrl="~/Images/ManageUsers.png" PostBackUrl="~/frmManageUsers.aspx" TabIndex="13" Width="49px" />
&nbsp;<asp:LinkButton ID="linkbtnManageUsers" runat="server" AccessKey="M" PostBackUrl="~/frmManageUsers.aspx" TabIndex="14" ToolTip="Manage Users">Manage Users</asp:LinkButton>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
