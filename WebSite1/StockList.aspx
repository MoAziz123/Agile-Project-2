<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="LstStockList" runat="server" Height="582px" OnSelectedIndexChanged="LstStockList_SelectedIndexChanged" Width="779px"></asp:ListBox>
        </div>
        <asp:Button ID="Add" runat="server" OnClick="Add_Click" Text="Add" />
        <asp:Button ID="Edit" runat="server" OnClick="Edit_Click" Text="Edit" />
        <asp:Button ID="Delete" runat="server" OnClick="Delete_Click" Text="Delete" />
    </form>
</body>
</html>
