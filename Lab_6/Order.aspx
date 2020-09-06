<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="WebApplication5.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <h1>Your Cart:</h1></center>
            <hr />
            <br />
        </div>
        <p>
            <asp:Label ID="lbl1" runat="server" Text="Label" Font-Size="Large"></asp:Label>
        </p>
        <p>
            <h3>Total amount payable:&nbsp;&nbsp; <asp:Label ID="lbl2" runat="server" Text="Label"></asp:Label>
        </h3>
        &nbsp;
        </p>
    </form>
</body>
</html>
