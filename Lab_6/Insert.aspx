<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="WebApplication5.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    &nbsp;<br />
        <table style="width:100%;">
        <tr>
            <td>Name:</td>
            <td>
                <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td>Sem:</td>
            <td>
                <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td>Mobile no:</td>
            <td>
                <asp:TextBox ID="txt3" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td>E-mail:</td>
            <td>
                <asp:TextBox ID="txt4" runat="server"></asp:TextBox>
            </td>
            
            <td>&nbsp;</td>
            
        </tr>
    </table>
        <asp:Button ID="Button1" runat="server" ForeColor="Green" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/link.aspx">Home</asp:HyperLink>
        <br />
        <asp:Label ID="lbl1" runat="server" Text="Label" Visible="False"></asp:Label>
    </form>
</body>
</html>
