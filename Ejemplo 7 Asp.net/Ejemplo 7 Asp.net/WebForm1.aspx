<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Ejemplo_7_Asp.net.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 315px">
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Estado Civil"></asp:Label>
        <br />
        <br />
&nbsp;<asp:Panel ID="Panel1" runat="server" Width="181px">
            <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True">
                <asp:ListItem>Si</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Panel ID="Panel2" runat="server" Width="175px">
                <asp:RadioButtonList ID="RadioButtonList3" runat="server" AutoPostBack="True" Visible="False">
                    <asp:ListItem>Soltero</asp:ListItem>
                    <asp:ListItem>Casado</asp:ListItem>
                    <asp:ListItem>Separado</asp:ListItem>
                </asp:RadioButtonList>
            </asp:Panel>
        </asp:Panel>
&nbsp;<asp:Panel ID="Panel3" runat="server">
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </asp:Panel>
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
