<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Ejemplo_18_Biblioteca.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 114px;
        }
        .auto-style3 {
            width: 96px;
        }
        .auto-style4 {
            width: 100%;
            height: 153px;
        }
        .auto-style5 {
            width: 114px;
            height: 49px;
        }
        .auto-style7 {
            width: 96px;
            height: 49px;
        }
        .auto-style8 {
            width: 10px;
        }
        .auto-style9 {
            width: 10px;
            height: 49px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <table class="auto-style4">
            <tr>
                <td class="auto-style1">Nombre Usuario:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox1" runat="server" Width="270px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Contraseña:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox2" runat="server" Width="268px"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="Aceptar" runat="server" Height="23px" Text="Ingreso" Width="231px" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Salir" runat="server" Text="Salir" Width="190px" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
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
