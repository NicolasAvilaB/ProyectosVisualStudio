<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PEDIDOS.aspx.vb" Inherits="Prototipo_PANADERIA_EXAMEN.PEDIDOS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" BackColor="#9E9D24" ForeColor="White" Height="23px" Width="794px">
            PANADERIA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Panel ID="Panel2" runat="server" BackColor="#C0CA33" Height="516px" style="margin-top: 0px" Width="797px">
                PEDIDOS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; BOLETA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                CODIGO PEDIDOS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button3" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 14px" Text="NUEVO" Width="88px" />
                &nbsp; CODIGO BOLETA
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                CODIGO SUCURSAL<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button5" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 9px" Text="ELIMINAR" Width="88px" />
                &nbsp; CODIGO SUCURSAL<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> CODIGO PRODUCTO<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 2px" Text="MODIFICAR" Width="88px" />
                &nbsp;&nbsp;&nbsp; CODIGO PRODUCTO<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <br />
                RUT CLIENTE
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;<asp:Button ID="Button10" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 51px" Text="GUARDAR" Width="88px" />
                &nbsp;&nbsp;&nbsp;&nbsp; COMPROBADOR CODIGOS...<br /> TIPO PEDIDO<asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 53px" Text="CANCELAR" Width="88px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CANTIDAD<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                <br />
                TIPO PAN<asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button7" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 82px" Text="VOLVER" Width="88px" />
                &nbsp;&nbsp;&nbsp; TOTAL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -- , -- , --<br /> KILOS PAN<asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> FECHA SOLICITUD<asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;<br /> FECHA HORA RETIRO<asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;<br /> TOTAL<asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                &nbsp;<br /> COMPROBADOR CODIGO S...&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />&nbsp;GRILLA&nbsp;
                <br />
                <asp:Table ID="Table1" runat="server" Height="21px" Width="685px">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <asp:Button ID="Button9" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 563px" Text="FACTURA" Width="132px" />
                <asp:Button ID="Button8" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 554px" Text="DETALLE FACTURA" Width="140px" />
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
