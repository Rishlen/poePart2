<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddFarmer.aspx.cs" Inherits="AddFarmer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Farmer</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add Farmer</h2>
            <label>Name:</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <label>Email:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <label>Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnAddFarmer" runat="server" Text="Add Farmer" OnClick="btnAddFarmer_Click" />
        </div>
    </form>
</body>
</html>

