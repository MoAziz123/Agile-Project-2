<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnAddres.aspx.cs" Inherits="AnAddres" %>

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
            <asp:Label ID="Label1" runat="server" Height="20px" Text="House No/Name" Width="150px"></asp:Label>
            <asp:TextBox ID="txtHouse" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Height="20px" Text="Street" Width="150px"></asp:Label>
            <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Height="20px" Text="Postcode" Width="150px"></asp:Label>
            <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Height="20px" Text="County" Width="150px"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Height="20px" Text="Date added" Width="150px"></asp:Label>
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="Active" runat="server" />
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" Height="20px" Text="OK" Width="75px" />
            <asp:Button ID="btnCancel" runat="server" Height="20px" Text="Cancel" Width="75px" />
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
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
