<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Login page"></asp:Label>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Sing up now</asp:HyperLink>
        </p>
        <p>
        <asp:Label ID="Label2" runat="server" Text="UserName"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="usertxt" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="usertxt" Display="Dynamic" ErrorMessage="Email is required" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="usertxt" Display="Dynamic" ErrorMessage="E-mail addresses must be in the format of name@domain.xyz" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="AllValidators">Invalid format!		 </asp:RegularExpressionValidator>
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="pswrdtxt" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label>
    </form>
</body>
</html>
