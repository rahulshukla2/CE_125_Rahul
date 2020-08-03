<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication1.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Full Name:&nbsp;&nbsp;
            <asp:TextBox ID="fullname" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fullname" ErrorMessage="Full Name is required" ForeColor="Red">Please enter your full name</asp:RequiredFieldValidator>
            <br />
            <br />
            Age:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="age" runat="server"></asp:TextBox>
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="age" ErrorMessage="Age should be in between 18 to 50" ForeColor="Red" MaximumValue="50" MinimumValue="18"></asp:RangeValidator>
            <br />
            <br />
            Password:&nbsp;&nbsp; <asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            Confirm Password:&nbsp;
            <asp:TextBox ID="confpass" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pass" ControlToValidate="confpass" ErrorMessage="Password does not match" ForeColor="Red"></asp:CompareValidator>
            <br />
            <br />
            Gender:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:RadioButtonList ID="gender" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Mobile no:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="mobileno" runat="server"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="mobileno" Display="Dynamic" ErrorMessage="Mobile no should contain 10 digits" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
            <br />
            <br />
            Hobbies:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBoxList ID="hobbies" runat="server">
                <asp:ListItem>Cycling</asp:ListItem>
                <asp:ListItem>Reading</asp:ListItem>
                <asp:ListItem>Rock climbing</asp:ListItem>
                <asp:ListItem>Singing</asp:ListItem>
                <asp:ListItem>Dancing</asp:ListItem>
                <asp:ListItem>Palying cricket</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            State:&nbsp;&nbsp;
            <asp:DropDownList ID="State" runat="server" AutoPostBack="True">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Gujarat</asp:ListItem>
                <asp:ListItem>Maharashtra</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            City:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="City" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            PAN no:&nbsp; <asp:TextBox ID="pan" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Full Name:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Age:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Gender:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Mobile no:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Hobbies:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="State"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="City"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="PAN no:"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
