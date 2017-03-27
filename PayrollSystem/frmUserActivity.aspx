<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmUserActivity.aspx.cs" Inherits="frmUserActivity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="hypACIT" runat="server" AccessKey="A" Height="150px" ImageUrl="~/Images/ACITLogo.jpg" NavigateUrl="~/frmMain.aspx" TabIndex="2" Width="500px" style="text-align: center"></asp:HyperLink>
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="lblUserActivity" runat="server" Text="User Activity" TabIndex="2"></asp:Label>
            <asp:GridView ID="grdUserActivity" runat="server" TabIndex="3">
            </asp:GridView>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
