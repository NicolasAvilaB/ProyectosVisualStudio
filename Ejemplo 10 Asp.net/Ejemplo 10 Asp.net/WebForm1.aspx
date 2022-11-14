<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Ejemplo_10_Asp.net.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 452px">
    
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Registro de Usuarios"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre de Usuario: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Nomb" runat="server" MaxLength="10" Width="209px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Nomb" ErrorMessage="Ingrese Nombre de Usuario..."></asp:RequiredFieldValidator>
        <br />
        <br />
        Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Pasw" runat="server" MaxLength="12" Width="209px"></asp:TextBox>
&nbsp;
        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="Pasw" ErrorMessage="Imngrese 8 a 12 caracteres"></asp:RangeValidator>
        <br />
        <br />
        Repetir Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Rep_Pas" runat="server" Width="209px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Pasw" ControlToValidate="Rep_Pas" ErrorMessage="Password no Valida"></asp:CompareValidator>
        <br />
        <br />
        Nombre Completo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Nombre_Completo" runat="server" Width="209px"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Nombre_Completo" ErrorMessage="INgrese Nombre Completo.."></asp:RequiredFieldValidator>
        <br />
        <br />
        Edad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Edad" runat="server" MaxLength="3" Width="209px"></asp:TextBox>
&nbsp;
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Edad" ErrorMessage="Valor entre 1 a 100" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        <br />
        <br />
        Correo Electronico:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Correo" runat="server" Width="209px"></asp:TextBox>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Correo" ErrorMessage="Correo Electronico no Valido..." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        Region:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Width="220px">
            <asp:ListItem>Selecion de Region</asp:ListItem>
            <asp:ListItem>I Region</asp:ListItem>
            <asp:ListItem>II Region</asp:ListItem>
            <asp:ListItem>III Region</asp:ListItem>
            <asp:ListItem>IV Region</asp:ListItem>
            <asp:ListItem>V Region</asp:ListItem>
            <asp:ListItem>VI Region</asp:ListItem>
            <asp:ListItem>VII Region</asp:ListItem>
            <asp:ListItem>VIII Region</asp:ListItem>
            <asp:ListItem>IX Region</asp:ListItem>
            <asp:ListItem>X Region</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Selecion de Region.." InitialValue="Selecion de Region"></asp:RequiredFieldValidator>
        <br />
        <br />
        Valor de Inscripcion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="vin" runat="server" Width="84px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="vin" ErrorMessage="Ingrese Inscripcion..."></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Regis" runat="server" Text="Registrar" Width="111px" />
&nbsp;&nbsp;
        <asp:Button ID="Limp" runat="server" Text="Limpiar" Width="121px" />
        <br />
    
    </div>
    </form>
</body>
</html>
