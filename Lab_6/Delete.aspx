<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="WebApplication5.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/link.aspx">Home</asp:HyperLink>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Enter Stdudent Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lbl1" runat="server" Text="Label" Visible="False"></asp:Label>
    </form>
</body>
</html>
