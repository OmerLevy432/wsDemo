<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="website.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hello there</h1>

            <asp:Button ID="myButton" runat="server" Text="Press me" OnClick="myButton_Click" />
            <br />

            <asp:TextBox ID="myText" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="myLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
