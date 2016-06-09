<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Calculator.UI.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/Calculator.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Input 1:" CssClass="label"></asp:Label>
        <asp:TextBox ID="txtInput1" runat="server" CssClass="input"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Input 2:" CssClass="label"></asp:Label>
        <asp:TextBox ID="txtInput2" runat="server" CssClass="input"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Result:" CssClass="label"></asp:Label>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    
        <br />
        <br />
        <asp:Button ID="btnPlus" runat="server" CssClass="buttons" OnClick="btnPlus_Click" Text="+" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubtract" runat="server" CssClass="buttons" OnClick="btnSubtract_Click" Text="-" />
    
    </div>
    </form>
</body>
</html>
