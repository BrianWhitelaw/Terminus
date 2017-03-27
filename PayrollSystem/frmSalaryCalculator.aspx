<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSalaryCalculator.aspx.cs" Inherits="frmSalaryCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="hypACIT" runat="server" AccessKey="A" Height="150px" ImageUrl="~/Images/ACITLogo.jpg" TabIndex="2" Width="500px" NavigateUrl="~/frmMain.aspx" style="text-align: center"></asp:HyperLink>
        <br />
    
        <asp:Label ID="lblAnnualHours" runat="server" Text="Annual Hours:" TabIndex="2"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtAnnualHours" runat="server" BorderStyle="Ridge" TabIndex="4" ToolTip="Please Enter Hours per Year" Width="47px" AccessKey="H"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblRate" runat="server" Text="Rate:" TabIndex="5"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPayRate" runat="server" BorderStyle="Ridge" TabIndex="5" ToolTip="Please Enter Hourly Pay Rate" Width="47px" AccessKey="R"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCalculateSalary" runat="server" BackColor="Aqua" OnClick="btnCalculateSalary_Click" TabIndex="6" Text="Calculate Salary" Width="159px" AccessKey="C" />
        <br />
        <br />
        <asp:Label ID="lblAnnualSalary" runat="server" AccessKey="$" TabIndex="7" Text="$"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
