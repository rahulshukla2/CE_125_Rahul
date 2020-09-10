<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Web_applab7.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Product Id:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="pid" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" ForeColor="Green" OnClick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>
