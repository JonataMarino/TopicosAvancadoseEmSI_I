<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AtividadeWeb.aspx.cs" Inherits="ListaAtividadesWeb.AtividadeWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Atividades</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="header1">
            Lista de Atividades:<br /> Atividade <asp:Label ID="idAtividade" runat="server" Text="0"></asp:Label>
        </div>
        <div id="inputDados">
            <div id="descricao">Descrição da Atividade:<asp:TextBox ID="txtDdescricao" runat="server"></asp:TextBox></div>
            <div id="calendarioCadastro">Data do cadastro de atividade:
                <asp:Calendar ID="dtpDataCriado" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar></div>
            <div id="calendarioAtividade">Data de conclusão: 
                <asp:Calendar ID="dtpAtividade" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar></div>

        <div>
            <asp:Button ID="btnNovo" runat="server" Text="Novo" OnClick="btnNovo_Click"/>
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click"/>
            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click"/> 
        </div>
                    </div>
        <div id="Lista">
            <br />
            <asp:GridView ID="IdGVAtividades" runat="server" AutoGenerateColumns="False" DataSourceID="GDVAtividades" OnSelectedIndexChanged="IdGVAtividades_SelectedIndexChanged" Height="150px" Width="488px">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
                    <asp:BoundField DataField="DataCriado" HeaderText="DataCriado" SortExpression="DataCriado" />
                    <asp:BoundField DataField="DataAtividade" HeaderText="DataAtividade" SortExpression="DataAtividade" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="GDVAtividades" runat="server" ConnectionString="<%$ ConnectionStrings:db_AtividadesConnectionString %>" ProviderName="<%$ ConnectionStrings:db_AtividadesConnectionString.ProviderName %>" SelectCommand="SELECT [Descricao], [DataCriado], [DataAtividade] FROM [Atividades]"></asp:SqlDataSource>
        </div>

    </form>
</body>
</html>
