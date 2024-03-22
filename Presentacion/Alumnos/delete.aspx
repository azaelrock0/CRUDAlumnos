<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="Presentacion.Alumnos.delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h3>Eliminar Alumno</h3>
        <h4>¿Está seguro de que desea eliminar al Alumno?</h4>
        <dl class="dl-horizontal">
            <dt>ID</dt>
            <dd><asp:Label ID="lblId" runat="server" Text="Label"></asp:Label></dd>
            <dt>Nombre</dt>
            <dd><asp:Label ID="lblNombre" runat="server" Text="Label"></asp:Label></dd>
            <dt>Primer Apellido</dt>
            <dd><asp:Label ID="lblPrimerAp" runat="server" Text="Label"></asp:Label></dd>
            <dt>Segundo Apellido</dt>
            <dd><asp:Label ID="lblSegundoAp" runat="server" Text="Label"></asp:Label></dd>
            <dt>Fecha de Nacimiento</dt>
            <dd><asp:Label ID="lblFecha" runat="server" Text="Label"></asp:Label></dd>
            <dt>Curp</dt>
            <dd><asp:Label ID="lblCurp" runat="server" Text="Label"></asp:Label></dd>
            <dt>Correo</dt>
            <dd><asp:Label ID="lblCorreo" runat="server" Text="Label"></asp:Label></dd>
            <dt>Telefono</dt>
            <dd><asp:Label ID="lblTelefono" runat="server" Text="Label"></asp:Label></dd>
            <dt>Sueldo Mensual</dt>
            <dd><asp:Label ID="lblSueldo" runat="server" Text="Label"></asp:Label></dd>
            <dt>Estado</dt>
            <dd><asp:Label ID="lblEstado" runat="server" Text="Label"></asp:Label></dd>
            <dt>Estatus</dt>
            <dd><asp:Label ID="lblEstatus" runat="server" Text="Label"></asp:Label></dd>
        </dl>
        <div class="form-group">
            <div class="col-md-2">
                <a href="index.aspx">Regresar a la lista</a>
            </div>
        </div>   
        <div class="form-group">
            <div class="col-md-2">
                <asp:Button class="btn btn-default" ID="Button1" runat="server" Text="Eliminar" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</asp:Content>
