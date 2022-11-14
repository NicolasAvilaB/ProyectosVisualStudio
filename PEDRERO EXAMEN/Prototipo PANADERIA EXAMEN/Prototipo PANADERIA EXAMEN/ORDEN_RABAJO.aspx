<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ORDEN_RABAJO.aspx.vb" Inherits="Prototipo_PANADERIA_EXAMEN.ORDEN_RABAJO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" BackColor="#9E9D24" ForeColor="White" Height="23px" Width="721px">
            PANADERIA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Panel ID="Panel2" runat="server" BackColor="#C0CA33" Height="385px" style="margin-top: 0px" Width="725px">
                ORDEN DE TRABAJO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PRODUCTOS<br />
                <br />
                CODIGO ORDEN&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1<asp:Button ID="Button3" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 130px" Text="NUEVO" Width="88px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CODIGO PRODUCTO
                <asp:TextBox ID="TextBox7" runat="server" Width="96px"></asp:TextBox>
                <br />
                CODIGO SUCURSAL<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button5" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 23px" Text="ELIMINAR" Width="88px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DESCRIPCION PRODUCTO<br /> CODIGO PRODUCTO
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:Button ID="Button4" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 19px" Text="MODIFICAR" Width="88px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox8" runat="server" Height="39px" Width="143px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; COMPROBADOR DE CODIGO...<asp:Button ID="Button6" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 4px" Text="GUARDAR" Width="88px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PRECIO KILO
                <asp:TextBox ID="TextBox9" runat="server" Width="96px"></asp:TextBox>
                <br />
                DESCRIPCION
                <asp:TextBox ID="TextBox5" runat="server" Height="39px" Width="143px"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 49px" Text="CANCELAR" Width="88px" />
                <br />
                CANTIDAD<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <asp:Button ID="Button7" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 106px" Text="VOLVER" Width="88px" />
                <br />
                <br />
                GRILLA<br />
                <asp:Table ID="Table1" runat="server" Height="21px" Width="705px">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                BUSCADOR<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 9px" Text="BUSCAR" Width="88px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; BUSCADOR<asp:TextBox ID="TextBox10" runat="server" Width="99px"></asp:TextBox>
                <asp:Button ID="Button8" runat="server" BackColor="#9E9D24" ForeColor="White" Height="25px" style="margin-left: 9px" Text="BUSCAR" Width="88px" />
                <br />
                TIPO BUSCADOR
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>COD SUCURSAL</asp:ListItem>
                    <asp:ListItem>COD ORDEN</asp:ListItem>
                    <asp:ListItem>COD PRODUCTO</asp:ListItem>
                    <asp:ListItem>DESCRIPCION</asp:ListItem>
                    <asp:ListItem>CANTIDAD</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; TIPO BUSCADOR
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>COD SUCURSAL</asp:ListItem>
                    <asp:ListItem>COD ORDEN</asp:ListItem>
                    <asp:ListItem>COD PRODUCTO</asp:ListItem>
                    <asp:ListItem>DESCRIPCION</asp:ListItem>
                    <asp:ListItem>CANTIDAD</asp:ListItem>
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
    
    </div>
    </form>
</body>
</html>
