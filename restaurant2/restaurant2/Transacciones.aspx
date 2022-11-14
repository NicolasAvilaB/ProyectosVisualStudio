<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Transacciones.aspx.vb" Inherits="restaurant2.Transacciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="width: 986px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="fabrica_transaccion" runat="server" Text="Crear Pedido" style="margin-top: 0px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="nomesa" runat="server" Enabled="False"></asp:TextBox>
&nbsp;
        <asp:Button ID="cambio" runat="server" Text="Cambiar" />
        <br />
        <asp:Button ID="canc_pedido" runat="server" Text="Cancelar Pedido" />
        <asp:Label ID="Label2" runat="server" Text="Fecha:"></asp:Label>
        <asp:TextBox ID="fecha" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="&lt;- Regresar" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Total $:"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" Enabled="False"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="Boleta:"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" Enabled="False"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="Items:"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server" Width="81px" Enabled="False"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:GridView ID="Grilla_Transaccion" runat="server">
        </asp:GridView>
        <br />
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="bor_seleccion0" runat="server" Text="Agregar Elementos" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Guardar" />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
