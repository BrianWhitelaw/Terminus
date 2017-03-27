<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnelVerified.aspx.cs" Inherits="frmPersonnelVerified" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="hypACIT" runat="server" AccessKey="A" Height="150px" ImageUrl="~/Images/ACITLogo.jpg" NavigateUrl="~/frmMain.aspx" TabIndex="2" Width="500px" style="text-align: center"></asp:HyperLink>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="250px" Width="650px">
            <asp:Label ID="lblInfoToSubmit" runat="server" Text="Information to Submit   " TabIndex="3"></asp:Label>
            <asp:TextBox ID="txtVerifiedInfo" runat="server" Height="80px" OnTextChanged="txtVerifiedInfo_TextChanged" TabIndex="4" TextMode="MultiLine" Width="400px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx" TabIndex="5" Text="View Personnel" />
        </asp:Panel>
    </form>
</body>
</html>
