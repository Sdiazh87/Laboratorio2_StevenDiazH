<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="Laboratorio2_SDH.Pagina1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>INICIO</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h3 runat="server" id="Login"></h3>
            <br />
            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnCalcular" Text="Calcular" runat="server" OnClick="btnCalcular_Click" />
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtRespuesta" runat="server"></asp:TextBox>

        </div>
    </form>
</body>
</html>
