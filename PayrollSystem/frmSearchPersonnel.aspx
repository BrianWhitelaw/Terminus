<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSearchPersonnel.aspx.cs" Inherits="frmSearchPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="hypACIT" runat="server" AccessKey="A" Height="150px" ImageUrl="~/Images/ACITLogo.jpg" NavigateUrl="~/frmMain.aspx" TabIndex="2" Width="500px" style="text-align: center"></asp:HyperLink>
        <br />
        <asp:Label ID="lblSearch" runat="server" TabIndex="3" Text="Search for employee by last name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtSearch" runat="server" AccessKey="L" ToolTip="Enter a Last Name"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSearch" runat="server" AccessKey="S" OnClick="btnSearch_Click" PostBackUrl="~/frmViewPersonnel.aspx" TabIndex="5" Text="Search" />
        <br />
        <asp:Label ID="lblError" runat="server" BackColor="Red"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
