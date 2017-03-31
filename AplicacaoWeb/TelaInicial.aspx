<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelaInicial.aspx.cs" Inherits="AplicacaoWeb.TelaInicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tela Inicial</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
            </asp:Login>
        </p>
    </div>
    </form>
</body>
</html>
