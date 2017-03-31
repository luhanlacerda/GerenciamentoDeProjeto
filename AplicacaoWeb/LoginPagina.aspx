<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPagina.aspx.cs" Inherits="AplicacaoWeb.LoginPagina" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Sistema para Gerenciamento de Projetos - Login</title>



    <link rel="stylesheet" href="logincss/style.css">
</head>

<body>

    <form id="f1" runat="server">
        <header>Login</header>
        <label>Username <span>*</span></label>
        <asp:TextBox ID="textBoxUsername" runat="server"></asp:TextBox>
        <label>Password <span>*</span></label>
        <asp:TextBox ID="textBoxPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="buttonLogin" runat="server" Text="Login" />
        <br />
    </form>


</body>
</html>
