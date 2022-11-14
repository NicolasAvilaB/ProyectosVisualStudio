<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Ejemplo_15_Asp_DropdownlistconGridview.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Lista de Reservas<br />
        <br />
        Seleccione Usuario para Mostrar Reservas:<br />
        <br />
        Seleccione el
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
&nbsp;<asp:Button ID="Mostrar" runat="server" Text="Mostrar" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="795px">
        </asp:GridView>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
