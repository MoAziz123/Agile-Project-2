<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="LstStockList" runat="server" Height="521px" OnSelectedIndexChanged="LstStockList_SelectedIndexChanged" Width="779px"></asp:ListBox>
        </div>
        <asp:Button ID="Add" runat="server" OnClick="Add_Click" Text="Add" />
        <asp:Button ID="Edit" runat="server" OnClick="Edit_Click" Text="Edit" />
        <asp:Button ID="Delete" runat="server" OnClick="Delete_Click" Text="Delete" />
        <asp:Label ID="Label1" runat="server" Text="Enter Product Type:"></asp:Label>
        <asp:TextBox ID="txtProduct_Type" runat="server" OnTextChanged="txtProduct_Type_TextChanged"></asp:TextBox>
        <asp:Button ID="Apply" runat="server" OnClick="Apply_Click" Text="Apply" />
        <asp:Button ID="Clear" runat="server" OnClick="Clear_Click" Text="Clear" />
    </form>
</body>
</html>
