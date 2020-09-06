<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebApplication5.Show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/link.aspx">Home</asp:HyperLink>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display" />
            <br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Label ID="lbl1" runat="server" Text="lbl1" Visible="False"></asp:Label>
    </form>
</body>
</html>
