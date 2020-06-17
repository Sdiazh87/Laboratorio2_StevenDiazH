<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Laboratorio2_SDH.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>LOGIN</title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <h3>Usuario</h3>

            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <br />
            <h3>Contraseña</h3>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnIngresar" Text="Ingresar" runat="server" OnClick="btnIngresar_Click"/>

        </div>
    </form>
</body>
</html>
