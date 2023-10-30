<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="LojaOnline.menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Menu</title>
      <link rel="stylesheet" href="styles/menu.css" />
</head>
<body>
    <form id="form1" runat="server">
        <section>
&nbsp;&nbsp;&nbsp;
            &nbsp;
            &nbsp;
            <asp:Label ID="Label4" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Compras efetuadas anteriormente" Font-Size="Large"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" OnRowDataBound="GridView1_RowDataBound" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sair" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Lista de Produtos" PostBackUrl="~/listar.aspx" />           
            <asp:Button ID="Button3" runat="server" Text="Gerar XML" PostBackUrl="~/geraXML.aspx" />
            <asp:Button ID="Button4" runat="server" Text="Gerar JSON" PostBackUrl="~/geraJSON.aspx" />
            <br />
        </section>
    </form>
</body>
</html>
