<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listar.aspx.cs" Inherits="LojaOnline.listar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="pt-br">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Lista de Produtos</title>
   <link rel="stylesheet" href="styles/lista.css" />
</head>
<body>
    <section>
    <form id="form1" runat="server">
        
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#203AA2" Text="Nossos produtos"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" OnRowDataBound="GridView1_RowDataBound" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin:auto;">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Voltar" OnClick="Button1_Click"  />
        
    </form>

    </section>

    <br /><br /><br />
</body>
</html>
