<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Button1 {
            height: 27px;
            width: 84px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 264px; width: 852px">
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Ejercicio N°1"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server">Hola Hola Hola Hola</asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Cambiar" Width="68px" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="NDIAZ"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton - Ejercicio 2</asp:LinkButton>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
