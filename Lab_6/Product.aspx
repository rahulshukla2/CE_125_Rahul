<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="WebApplication5.Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="lbl1" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <asp:ListBox ID="ListBox1" runat="server" Height="200px" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        <br />
        <br />
        Cart:<asp:BulletedList ID="cart" runat="server">
        </asp:BulletedList>
        <br />
        <br />
            <asp:Button ID="btn1" runat="server" OnClick="Button1_Click" Text="Place Order" ForeColor="Green" />
        <br />
    </form>
</body>
</html>
