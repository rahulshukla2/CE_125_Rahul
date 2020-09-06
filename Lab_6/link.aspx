<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="link.aspx.cs" Inherits="WebApplication5.link" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Insert.aspx">Insert data</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Edit.aspx">Edit Data</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Delete.aspx">Delete Data</asp:HyperLink>
            <br />
        </div>
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Show.aspx">Show Data</asp:HyperLink>
    </form>
</body>
</html>
