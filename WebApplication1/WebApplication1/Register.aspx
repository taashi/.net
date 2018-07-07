<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    
    <form id="form1"  runat="server" >
        
        
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Registration Page" BackColor ="Blue"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="Label2" runat="server" Text="UserName"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nametxt" Display="Dynamic" ErrorMessage="Email is required" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="nametxt" Display="Dynamic" ErrorMessage="E-mail addresses must be in the format of name@domain.xyz" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="AllValidators" ForeColor="Red">Invalid format!E-mail addresses must be in the format of name@domain.xyz		 </asp:RegularExpressionValidator>

            </p>
        <p>
            
        <asp:Label ID="Label3" runat="server" Text="Password"  type='password'></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;<asp:TextBox ID="passwordtxt"  TextMode =" Password"
                runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            

            <asp:RegularExpressionValidator ID="Regex2" runat="server" ControlToValidate="passwordtxt"
    ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$"
    ErrorMessage="Minimum 8 characters atleast 1 Alphabet, 1 Number and 1 Special Character" ForeColor="Red" />
          
        </p>
        <p>
            
            FirstName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="fname" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="fname" ErrorMessage="Firstname is required"  Display="Dynamic" ForeColor="Red" >*</asp:RequiredFieldValidator>
          
        </p>
        <p>
            
            LastName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="lname" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="lname" ErrorMessage="Firstname is required"  Display="Dynamic" ForeColor="Red" >*</asp:RequiredFieldValidator>
          
        </p>
        <p>
            
            Course&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="course" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="course" ErrorMessage="Firstname is required"  Display="Dynamic" ForeColor="Red" >*</asp:RequiredFieldValidator>
          
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        </p>
        <asp:Label ID="Label4" runat="server" ></asp:Label>
    </form>
</body>
</html>
