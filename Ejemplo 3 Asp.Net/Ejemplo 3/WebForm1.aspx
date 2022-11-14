<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Ejemplo_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 272px">
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Producto"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Descuento"></asp:Label>
&nbsp;<asp:DropDownList ID="Desc" runat="server">
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Neto"></asp:Label>
&nbsp;<asp:TextBox ID="Neto" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Iva"></asp:Label>
&nbsp;<asp:TextBox ID="Iva" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Total"></asp:Label>
&nbsp;<asp:TextBox ID="Total" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Calcular" runat="server" Text="Calcular" Width="837px" />
        <br />
    
    </div>
    </form>
</body>
</html>
