<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LojaOnline.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="pt-br">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="styles/index.css" />
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <section>
            <asp:Image ID="Image1" runat="server" ImageUrl="perfil.png" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Login" Font-Bold="True" Font-Size="Large" ForeColor="#203AA2"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Login"></asp:Label>
            <br />
            <asp:TextBox ID="idusuario" runat="server"  placeholder="Digite seu Login"></asp:TextBox>
            <br />
            
            <asp:Label ID="Label3" runat="server" Text="Senha"></asp:Label>
            <br />
            <asp:TextBox ID="senhausuario" type="password" runat="server" placeholder="Digite sua Senha"></asp:TextBox>
            
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" PostBackUrl="~/autentica.aspx"  />
        </section>
    </form>
    <div class="creditos">
            Este exemplo utiliza como base o desenvolvimento em uma Prova Parcial 
            de Geovanna dos Santos Teixeira. Acrescentamos as opções das páginas 
            gerarXML.aspx e gerarJSON.aspx, foi adicionado uma INNER JOIN para 
            visualização de dados e realizados outros pequenos ajustes.
    </div>
</body>
</html>
