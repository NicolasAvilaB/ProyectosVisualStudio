<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="GUIA_DESPACHO.aspx.vb" Inherits="Prototipo_PANADERIA_EXAMEN.GUIA_DESPACHO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" BackColor="#9E9D24" ForeColor="White" Height="23px" Width="445px">
            PANADERIA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Panel ID="Panel2" runat="server" BackColor="#C0CA33" Height="431px" style="margin-top: 0px" Width="441px">
                GUIA DESPACHO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                CODIGO GUIA<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 74px" Text="NUEVO" Width="88px" />
                &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                COD REPARTIDOR<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button5" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 41px" Text="ELIMINAR" Width="88px" />
                &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                CODIGO PEDIDO<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                &nbsp;&nbsp;<asp:Button ID="Button4" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 48px" Text="MODIFICAR" Width="88px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> RUT CLIENTE<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 78px" Text="CANCELAR" Width="88px" />
                <br />
                COD SUCURSAL<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <asp:Button ID="Button7" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 62px" Text="VOLVER" Width="88px" />
                <br />
                NUMERO GUIA<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <asp:Button ID="Button8" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 62px" Text="GUARDAR" Width="88px" />
                <br />
                COMPROBADOR CODIGO S...&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> DIRECCION<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <br />
                TOTAL<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                &nbsp;GUIA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />GRILLA<br />
                <asp:Table ID="Table1" runat="server" Height="21px" Width="292px">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                BUSCADOR<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 9px" Text="BUSCAR" Width="88px" />
                <br />
                TIPO BUSCADOR
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>COD GUIA</asp:ListItem>
                    <asp:ListItem>COD REPARTIDOR</asp:ListItem>
                    <asp:ListItem>COD PEDIDO</asp:ListItem>
                    <asp:ListItem>RUT CLIENTE</asp:ListItem>
                    <asp:ListItem>COD SUCURSAL</asp:ListItem>
                    <asp:ListItem>NUMERO GUIA</asp:ListItem>
                    <asp:ListItem>DIRECCION</asp:ListItem>
                    <asp:ListItem>TOTAL GUIA</asp:ListItem>
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
    
    </div>
    </form>
</body>
</html>
