<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 4px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="Yes" runat="server" OnClick="Button1_Click" Text="Yes" />
        <asp:Button ID="No" runat="server" Text="No" />
    </form>
</body>
</html>
