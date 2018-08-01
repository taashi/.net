<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />
        <div>
        </div>
        &nbsp;<p>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label2" runat="server" Text="You have signed in!"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server"  Width="236px"  >
                <Columns>
                    <asp:BoundField DataField ="Major" HeaderText ="Major" />
                     <asp:BoundField DataField ="CourseID" HeaderText =" Course Id" />
                     <asp:BoundField DataField ="RegisteredCourses" HeaderText =" Registered Courses" />
                    
                </Columns>
                
               
                   
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Add Courses" OnClick="Button2_Click" />
        </p>
    </form>
</body>
</html>
