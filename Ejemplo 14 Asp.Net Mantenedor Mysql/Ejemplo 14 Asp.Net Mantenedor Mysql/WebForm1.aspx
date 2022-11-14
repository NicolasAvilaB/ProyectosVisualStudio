<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Ejemplo_14_Asp.Net_Mantenedor_Mysql.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 205px;
        }
        .auto-style4 {
            width: 204px;
        }
        .auto-style6 {
            width: 159px;
        }
        .auto-style7 {
            width: 201px;
        }
        .auto-style8 {
            width: 577px;
        }
        .auto-style9 {
            height: 23px;
        }
        .auto-style10 {
            width: 80px;
        }
        .auto-style11 {
            width: 122px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 285px">
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style10">Rut</td>
                <td class="auto-style3">
                    <asp:TextBox ID="Rut" runat="server" Width="197px"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Buscar" runat="server" style="margin-left: 82px" Text="Buscar" Width="127px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Nombre</td>
                <td class="auto-style3">
                    <asp:TextBox ID="Nombre" runat="server" Enabled="False" ReadOnly="True" Width="195px"></asp:TextBox>
                </td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">Login</td>
                <td class="auto-style3">
                    <asp:TextBox ID="Login" runat="server" Enabled="False" ReadOnly="True" Width="196px"></asp:TextBox>
                </td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style11">Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="Password" runat="server" Enabled="False" ReadOnly="True" Width="193px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">Tipo</td>
                <td class="auto-style4">
                    <asp:TextBox ID="Tipo" runat="server" Enabled="False" ReadOnly="True" Width="192px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">Carrera</td>
                <td class="auto-style4">
                    <asp:TextBox ID="Carrera" runat="server" Enabled="False" ReadOnly="True" Width="193px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="NUevo" runat="server" style="height: 26px" Text="Nuevo" Width="66px" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="Editar" runat="server" Enabled="False" style="margin-bottom: 0px" Text="Editar" Width="86px" />
                </td>
                <td>
                    <asp:Button ID="Elimianr" runat="server" Enabled="False" style="margin-left: 0px" Text="Eliminar" Width="128px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="Guardar" runat="server" Enabled="False" Text="Guardar" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="Actualizar" runat="server" Enabled="False" Text="Actualizar" />
                </td>
                <td>
                    <asp:Label ID="Estado" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
    
    </div>
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" style="margin-left: 228px" Width="446px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style9"></td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
