<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="iniciosesion.aspx.vb" Inherits="restaurant2.iniciosesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        <br />
        <asp:TextBox ID="nombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
        <br />
        <asp:TextBox ID="clave" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="aceptar" runat="server" Text="Aceptar" />
        <asp:Button ID="salir" runat="server" Text="Salir" Width="69px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
