<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body style="text-align: center; position: relative">
    <form id="form1" runat="server" style="position: relative">
    <div class="auto-style1">
    <asp:HyperLink ID="hypACIT" runat="server" AccessKey="A" Height="150px" ImageUrl="~/Images/ACITLogo.jpg" TabIndex="2" Width="500px"></asp:HyperLink>
        <br />
    </div>
        <asp:Login ID="Login1" runat="server" AccessKey="L" DestinationPageUrl="frmMain.aspx" OnAuthenticate="Login1_Authenticate" TitleText="Please enter your UserName and Password in order to log in to the system.">
        </asp:Login>
    </form>
</body>
</html>
