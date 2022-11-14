<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Ejemplo_12_Asp.Net_Correo_Electronico.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 337px">
    
        Destinatario:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Asunto:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Height="127px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BTNENVIAR" runat="server" Text="Enviar" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
