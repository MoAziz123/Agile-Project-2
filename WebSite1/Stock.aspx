<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stock.aspx.cs" Inherits="AnAddres" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Height="20px" Text="Product ID" Width="150px"></asp:Label>
            <asp:TextBox ID="Product_ID" runat="server" ></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Height="20px" Text="Find" Width="75px" OnClick="btnFind_Click" />
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Height="20px" Text="Product Name" Width="150px"></asp:Label>
            <asp:TextBox ID="Product_Name" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Height="20px" Text="Product Type" Width="150px"></asp:Label>
            <asp:TextBox ID="Product_Type" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Height="20px" Text="Product Description" Width="150px"></asp:Label>
            <asp:TextBox ID="Product_Description" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Height="20px" Text="Quantity" Width="150px"></asp:Label>
            <asp:TextBox ID="Quantity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="Active" runat="server" />
        </p>
        <p id="                                                                                                                                                                                   ">
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOK" runat="server" Height="20px" Text="OK" Width="75px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Height="20px" Text="Cancel" Width="75px"  />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
