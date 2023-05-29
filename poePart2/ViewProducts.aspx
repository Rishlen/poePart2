<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewProducts.aspx.cs" Inherits="ViewProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Products</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>View Products</h2>
            <label>FarmerID:</label>
            <asp:TextBox ID="txtFarmerID" runat="server"></asp:TextBox>
            <br />
            <label>Start Date:</label>
            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
            <br />
            <label>End Date:</label>
            <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnFilterProducts" runat="server" Text="Filter Products" OnClick="btnFilterProducts_Click" />
            <br />
            <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Product Name" />
                    <asp:BoundField DataField="Type" HeaderText="Product Type" />
                    <asp:BoundField DataField="DateSupplied" HeaderText="Date Supplied" DataFormatString="{0:d}" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

