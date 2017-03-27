<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnel.aspx.cs" Inherits="frmPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="position: relative; text-align: left">
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="hypACIT" runat="server" AccessKey="A" Height="150px" ImageUrl="~/Images/ACITLogo.jpg" NavigateUrl="~/frmMain.aspx" TabIndex="2" Width="500px" style="text-align: center"></asp:HyperLink>
        <br />
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="250px" Width="462px">
            <asp:Label ID="lblFirstName" runat="server" Text="First Name: " TabIndex="3" width="76px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" TabIndex="4" ToolTip="Please Enter First Name" Width="128px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Please enter a valid First Name" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Last Name: " width="76px" TabIndex="5"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" TabIndex="6" ToolTip="Please Enter Last Name" width="128px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName" ErrorMessage="Please enter a valid Last Name" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblPayRate" runat="server" Text="Pay Rate: " width="76px" TabIndex="7"></asp:Label>
            <asp:TextBox ID="txtPayRate" runat="server" OnTextChanged="txtPayRate_TextChanged" TabIndex="8" ToolTip="Please Enter Rate of Pay" width="128px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPayRate" runat="server" ControlToValidate="txtPayRate" ErrorMessage="Please enter a valid Pay Rate" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblStartDate" runat="server" Text="Start Date: " width="76px" TabIndex="9"></asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server" TabIndex="10" ToolTip="Please Use mm/dd/yyyy Format" width="128px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revStartDate" runat="server" ControlToValidate="txtStartDate" ErrorMessage="Please use mm/dd/yyyy date format" ForeColor="Red" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="lblEndDate" runat="server" Text="End Date: " width="76px" TabIndex="11"></asp:Label>
            <asp:TextBox ID="txtEndDate" runat="server" TabIndex="12" ToolTip="Please Use mm/dd/yyyy Format" width="128px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revEndDate" runat="server" ControlToValidate="txtEndDate" ErrorMessage="Please use mm/dd/yyyy date format" ForeColor="Red" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" TabIndex="13" Text="Submit" AccessKey="S" OnClick="btnSubmit_Click" />
            &nbsp;&nbsp;
            <br />
            <asp:Label ID="lblError" runat="server" BackColor="Red" Font-Bold="True"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
