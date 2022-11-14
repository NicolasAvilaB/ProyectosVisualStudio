<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Ejemplo_16_Asp_Reservas_Libros.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Reservas de Libros<br />
        <br />
        Seleccione Usuario a Reservar:
        <asp:DropDownList ID="ddlrut" runat="server">
        </asp:DropDownList>
&nbsp;<asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
        <br />
        <br />
        Busque Titulo a Reservar:
        <asp:TextBox ID="txtitulo" runat="server"></asp:TextBox>
        <asp:Button ID="mostrar" runat="server" Text="mostrar" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="762px">
        </asp:GridView>
        <br />
        seleccione codigo del libro:
        <asp:DropDownList ID="ddlcodigo" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        seleccione cantidad de dias de la reserva:
        <asp:DropDownList ID="ddldias" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="reserva" runat="server" Text="reserva" />
        <br />
        <br />
        <asp:Button ID="cancelar" runat="server" Text="cancelar" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
