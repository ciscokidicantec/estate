<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="estate.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="estateid">
                <Columns>
                    <asp:BoundField DataField="estateid" HeaderText="estateid" ReadOnly="True" SortExpression="estateid" />
                    <asp:BoundField DataField="postcode" HeaderText="postcode" SortExpression="postcode" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:gitpropertyConnectionString %>" SelectCommand="SELECT * FROM [estate]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/images/helen.jpg" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
            <br />
            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataKeyNames="userid" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="userid" HeaderText="userid" ReadOnly="True" SortExpression="userid" />
                    <asp:BoundField DataField="estateid" HeaderText="estateid" SortExpression="estateid" />
                    <asp:BoundField DataField="vendorfirstname" HeaderText="vendorfirstname" SortExpression="vendorfirstname" />
                    <asp:BoundField DataField="vendorlastname" HeaderText="vendorlastname" SortExpression="vendorlastname" />
                    <asp:BoundField DataField="vendoremail" HeaderText="vendoremail" SortExpression="vendoremail" />
                    <asp:BoundField DataField="vendorstatus" HeaderText="vendorstatus" SortExpression="vendorstatus" />
                    <asp:BoundField DataField="vendorfirstlineaddress" HeaderText="vendorfirstlineaddress" SortExpression="vendorfirstlineaddress" />
                    <asp:BoundField DataField="vendoraddressname" HeaderText="vendoraddressname" SortExpression="vendoraddressname" />
                    <asp:BoundField DataField="vendoraddressnumber" HeaderText="vendoraddressnumber" SortExpression="vendoraddressnumber" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:gitpropertyConnectionString %>" SelectCommand="SELECT * FROM [vendors]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
