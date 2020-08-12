<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication4.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Welcome"></asp:Label>
        </div>
        <p>
            <asp:RadioButtonList ID="Category" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Category_SelectedIndexChanged">
                <asp:ListItem>Electronics</asp:ListItem>
                <asp:ListItem>Books</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:ListBox ID="Items1" runat="server" Height="200px" AutoPostBack="True" OnSelectedIndexChanged="Items1_SelectedIndexChanged"></asp:ListBox>
        </p>
        <p>
            Cart:</p>
        <asp:BulletedList ID="Cart" runat="server">
        </asp:BulletedList>
        <p>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Place Order" />
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
