<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="Web_applab7.product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Product] WHERE [pid] = @pid" InsertCommand="INSERT INTO [Product] ([pid], [pname], [desc], [cost], [category]) VALUES (@pid, @pname, @desc, @cost, @category)" SelectCommand="SELECT * FROM [Product] WHERE ([pid] = @pid)" UpdateCommand="UPDATE [Product] SET [pname] = @pname, [desc] = @desc, [cost] = @cost, [category] = @category WHERE [pid] = @pid">
                <DeleteParameters>
                    <asp:Parameter Name="pid" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="pid" Type="Int32" />
                    <asp:Parameter Name="pname" Type="String" />
                    <asp:Parameter Name="desc" Type="String" />
                    <asp:Parameter Name="cost" Type="Int32" />
                    <asp:Parameter Name="category" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:QueryStringParameter DefaultValue="1" Name="pid" QueryStringField="pid" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="pname" Type="String" />
                    <asp:Parameter Name="desc" Type="String" />
                    <asp:Parameter Name="cost" Type="Int32" />
                    <asp:Parameter Name="category" Type="String" />
                    <asp:Parameter Name="pid" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="pid" DataSourceID="SqlDataSource1" Height="50px" OnPageIndexChanging="DetailsView1_PageIndexChanging" Width="125px">
            <Fields>
                <asp:BoundField DataField="pid" HeaderText="pid" ReadOnly="True" SortExpression="pid" />
                <asp:BoundField DataField="pname" HeaderText="pname" SortExpression="pname" />
                <asp:BoundField DataField="desc" HeaderText="desc" SortExpression="desc" />
                <asp:BoundField DataField="cost" HeaderText="cost" SortExpression="cost" />
                <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
    </form>
</body>
</html>
