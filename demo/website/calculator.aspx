<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="website.calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to my Calculator website</h1>

            First number: <asp:TextBox ID="number1" runat="server"></asp:TextBox>
            <br />

            Second number: <asp:TextBox ID="number2" runat="server"></asp:TextBox>
            <br />

            Operator: <asp:TextBox ID="opValue" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="button" runat="server" Text="Calculate" OnClick="button_Click" />
            <br />

            Result: <asp:Label ID="result" runat="server" Text=""></asp:Label>
            <br />

        </div>
    </form>
</body>
</html>
