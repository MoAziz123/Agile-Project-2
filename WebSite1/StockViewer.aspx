<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockViewer.aspx.cs" Inherits="AddressViewer_aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 311px">
        </div>
        <asp:Button ID="BtnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
        <asp:Button ID="BtnDelete" runat="server" Text="Delete" />
    </form>
</body>
</html>
