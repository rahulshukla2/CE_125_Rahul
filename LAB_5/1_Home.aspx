<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication2.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            


            <br />
            


        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show Cookies" />
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Label" Visible="False" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete Cookies" />
        <br />
        <br />
            <asp:Label ID="Label1" runat="server" Text="Full Name:" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Age:" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Gender:" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Mobile no:" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Hobbies:" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="State" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="City" Visible="False"></asp:Label>
    </form>
</body>
</html>
