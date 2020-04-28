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
    </form>
</body>
</html>
