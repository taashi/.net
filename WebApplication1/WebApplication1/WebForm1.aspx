﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns = "false"></asp:GridView>
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Checkbox ID =" chkCheckAll" runat ="server" />
                </HeaderTemplate>
            </asp:TemplateField>
        </Columns>
        <div>
        </div>
    </form>
</body>
</html>
