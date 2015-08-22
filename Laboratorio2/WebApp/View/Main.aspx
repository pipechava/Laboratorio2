<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebApp.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 2 - Topicos Selectos</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <h1> Laboratorio 2 - Topicos Selectos </h1>

    </div>
        <hr />
    <div>
        
        <h2> Busqueda de Productos </h2>

        <br />

        <row>
            <asp:Label ID="Label1" runat="server" Text="Rango de Fechas: "></asp:Label>
            <asp:TextBox ID="txtFechaInicio" runat="server" Height="16px" Width="191px"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text=" - a - "></asp:Label>
            <asp:TextBox ID="txtFechaFin" runat="server" Height="16px" Width="191px"></asp:TextBox>
        </row>

        <br />
        <br />

        <row>
            <asp:Label ID="Label3" runat="server" Text="Nombre de Producto: "></asp:Label>
            <asp:TextBox ID="txtNombreProducto" runat="server" Height="16px" Width="396px"></asp:TextBox>
        </row>

        <br />
        <br />

        <row>
            <asp:Button ID="btnSelect" runat="server" Text="Select" OnClick="btnSelect_Click"></asp:Button>
        </row>

        <br />

        <hr />

    </div>


        
    <div>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" Height="172px" Width="1009px">
        </asp:GridView>



    </div>
    </form>
</body>
</html>
