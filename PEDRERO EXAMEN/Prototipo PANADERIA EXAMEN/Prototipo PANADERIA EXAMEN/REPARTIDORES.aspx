<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="REPARTIDORES.aspx.vb" Inherits="Prototipo_PANADERIA_EXAMEN.REPARTIDORES" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 943px">
    
        <asp:Panel ID="Panel1" runat="server" BackColor="#9E9D24" ForeColor="White" Height="23px" Width="727px">
            PANADERIA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Panel ID="Panel2" runat="server" BackColor="#C0CA33" Height="400px" style="margin-top: 0px" Width="766px">
                REPARTIDORES&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DESPACHOS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                CODIGO REPARTIDOR<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 14px" Text="NUEVO" Width="88px" />
                &nbsp; CODIGO DESPACHO
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                NOMBRE REPARTIDOR<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button5" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 9px" Text="ELIMINAR" Width="88px" />
                &nbsp; CODIGO SUCURSAL<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                CODIGO SUCURSAL<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; RUT CLIENTE<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp; COMPROBADOR CODIGO S...&nbsp;
                <asp:Button ID="Button4" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 88px" Text="MODIFICAR" Width="88px" />
                &nbsp;&nbsp;&nbsp;CODIGO REPARTIDOR<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button10" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 0px" Text="GUARDAR" Width="88px" />
                &nbsp;FECHA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; - ,&nbsp; --&nbsp; ,&nbsp; ----<br />
                <asp:Button ID="Button2" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 300px" Text="CANCELAR" Width="88px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;HORA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -- , -- , --<br />&nbsp;GRILLA<asp:Button ID="Button7" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 244px" Text="VOLVER" Width="88px" />
                &nbsp;&nbsp;&nbsp;&nbsp; DIRECCION<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                <br />
                <asp:Table ID="Table1" runat="server" Height="21px" Width="685px">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <asp:Button ID="Button9" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 563px" Text="GUIA DESPACHO" Width="132px" />
                <asp:Button ID="Button8" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 522px" Text="DETALLE GUIA DESPACHO" Width="173px" />
                <br />
                BUSCADOR<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 9px" Text="BUSCAR" Width="88px" />
                <br />
                TIPO BUSCADOR
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>COD REPARTIDOR</asp:ListItem>
                    <asp:ListItem>NOMBRE REPARTIDOR</asp:ListItem>
                    <asp:ListItem>COD SUCURSAL</asp:ListItem>
                    <asp:ListItem>COD DESPACHO</asp:ListItem>
                    <asp:ListItem>RUT CLIENTE</asp:ListItem>
                    <asp:ListItem>DIRECCION</asp:ListItem>
                </asp:DropDownList>
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
                <br />
                <br />

                <br />
            </asp:Panel>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:Panel>
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
        <br />
    
    </div>
    </form>
</body>
</html>
