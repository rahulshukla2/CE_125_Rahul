<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication5.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            User-Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="utxt" runat="server"></asp:TextBox>
            <br />
            <br />
            Password:&nbsp;
            <asp:TextBox ID="ptxt" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lbl1" runat="server" Text="Label" ForeColor="Red" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
