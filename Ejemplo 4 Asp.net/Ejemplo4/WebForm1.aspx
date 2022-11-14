<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Ejemplo4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 212px">
    
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="30px" Width="247px">
            Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Agregar" />
        <asp:Button ID="Delete" runat="server" Text="Borrar Todo " />
        <asp:Button ID="Borrar" runat="server" Text="Borrar" />
        <br />
        <br />
        <asp:Panel ID="Panel2" runat="server" Height="25px" Width="283px">
            <asp:DropDownList ID="List" runat="server" Height="85px" Width="263px">
            </asp:DropDownList>
        </asp:Panel>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
