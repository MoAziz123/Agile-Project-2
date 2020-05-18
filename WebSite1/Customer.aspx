<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer.aspx.cs" Inherits="Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 825px;
        }
        .newStyle1 {
            border-color: #FFFFFF;
        }
    </style>
</head>
<body style="width: 1058px; height: 569px">
    <form id="form1" runat="server">
        <br />
        Customers ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerID" runat="server" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Find" />
        <p>
            Customer Firstname&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCustomer_FirstName" runat="server" OnTextChanged="txtCustomer_FirstName_TextChanged"></asp:TextBox>
        </p>
        <p>
            Customer Surname&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomer_Surname" runat="server" OnTextChanged="txtCustomer_Surname_TextChanged"></asp:TextBox>
        </p>
        <p>
            Customer Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomer_Email" runat="server" OnTextChanged="txtCustomer_Email_TextChanged"></asp:TextBox>
        </p>
        <p>
            Customer Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomer_Address" runat="server" OnTextChanged="txtCustomer_Address_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Active" />
        </p>
        <p>
            <asp:Button ID="OK" runat="server" OnClick="Button1_Click" Text="OK" Width="100px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Cancel" runat="server" Text="Cancel" Width="100px" />
        </p>
    </form>
</body>
</html>
