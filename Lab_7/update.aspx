<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="Web_applab7.update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            Enter Stdudent Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" ForeColor="Green" OnClick="Button1_Click" Text="Fetch" />
        <p>
            &nbsp;</p>
        <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="lbl1" runat="server" Text="Name:" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt5" runat="server" Visible="False"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl2" runat="server" Text="Sem:" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt2" runat="server" Visible="False"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl3" runat="server" Text="Mobile no:" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt3" runat="server" Visible="False"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl4" runat="server" Text="E-mail:" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt4" runat="server" Visible="False"></asp:TextBox>
            </td>
            
            <td>&nbsp;</td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl5" runat="server" Text="CPI:" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt6" runat="server" Visible="False"></asp:TextBox>
            </td>
            
            <td>&nbsp;</td>
            
        </tr>


    </table>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" ForeColor="Green" OnClick="Button2_Click" Text="Update" />
        </p>
        <asp:Label ID="errlbl" runat="server" Text="Error" Visible="False"></asp:Label>
    </form>
   
</body>
</html>
