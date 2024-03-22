<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Presentacion.Alumnos.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Título</h2>
   <!-- Control asp Label para mensajes -->
    <hr />
    <p><a runat="server" href="create" class="btn btn-primary">Agregar</a></p>
    <asp:GridView ID="gview" runat="server" 
    BorderStyle="None" 
    CssClass="table" 
    GridLines="Horizontal" 
    PageSize="5" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="gview_PageIndexChanging" OnRowCommand="gview_RowCommand">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Id" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="primerApellido" HeaderText="Primer Apellido" />
            <asp:BoundField DataField="segundoApellido" HeaderText="Segundo Apellido" />
            <asp:BoundField DataField="correo" HeaderText="Correo" />
            <asp:BoundField DataField="telefono" HeaderText="Teléfono" />
            <asp:BoundField DataField="nombreEstado" HeaderText="Estado" />
            <asp:BoundField DataField="nombreEstatus" HeaderText="Estatus" />
            <asp:ButtonField ShowHeader="True" Text="Detalles" CommandName="Details">
                <ControlStyle CssClass="btn btn-warning btn-sm" />
            </asp:ButtonField>
		    <asp:ButtonField ShowHeader="True" Text="Editar" CommandName="Edit">
                <ControlStyle CssClass="btn btn-success btn-sm" />
            </asp:ButtonField>
            <asp:ButtonField ShowHeader="True" Text="Eliminar" CommandName="Delete">
                <ControlStyle CssClass="btn btn-danger btn-sm" />
            </asp:ButtonField>
        </Columns>
    </asp:GridView>
</asp:Content>
