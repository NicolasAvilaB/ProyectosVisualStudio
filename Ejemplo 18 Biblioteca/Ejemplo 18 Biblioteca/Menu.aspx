<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Menu.aspx.vb" Inherits="Ejemplo_18_Biblioteca.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 197px;
        }
        .auto-style2 {
            width: 302px;
            height: 54px;
        }
        .auto-style5 {
            width: 302px;
            height: 61px;
        }
        .auto-style6 {
            height: 61px;
        }
        .auto-style8 {
            width: 302px;
            height: 59px;
        }
        .auto-style9 {
            height: 59px;
        }
        .auto-style10 {
            height: 54px;
        }
        .auto-style11 {
            width: 197px;
            height: 52px;
        }
        .auto-style13 {
            width: 258px;
            height: 54px;
        }
        .auto-style14 {
            width: 258px;
            height: 59px;
        }
        .auto-style15 {
            width: 258px;
            height: 61px;
        }
        .auto-style18 {
            width: 172px;
        }
        .auto-style19 {
            width: 172px;
            height: 52px;
        }
        .auto-style20 {
            width: 214px;
        }
        .auto-style21 {
            width: 214px;
            height: 52px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style20">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style20">
                    <hr noshade="noshade" />
                </td>
                <td class="auto-style18">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style21">
                    <asp:Button ID="Usuarios" runat="server" Text="Mantenedor de Usuarios" Width="231px" />
                </td>
                <td class="auto-style19">
                    <asp:Button ID="Libros" runat="server" Text="Mantenedor de Libros" Width="195px" />
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="Buscar Libro" Width="230px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button2" runat="server" Text="Buscar Usuario" Width="230px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style8">
                    <asp:Button ID="Button3" runat="server" Text="Prestar Libro" Width="230px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button4" runat="server" Text="Regresar Libro" Width="230px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style15"></td>
                <td class="auto-style5"></td>
                <td class="auto-style6"></td>
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
    
    </div>
    </form>
</body>
</html>
