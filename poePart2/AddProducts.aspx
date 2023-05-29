<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddProducts.aspx.cs" Inherits="AddProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Product</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add Product</h2>
            <label>Name:</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <label>Type:</label>
            <asp:TextBox ID="txtType" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAddProduct" runat="server" Text="Add Product" OnClick="btnAddProduct_Click" />
        </div>
    </form>
</body>
</html>

