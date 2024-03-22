<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="Presentacion.Alumnos.edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h3>Agregar</h3>
        <div class="form-group">
            <asp:Label ID="Label11" runat="server" Text="Id" class="col-md-2 control-label"></asp:Label>
            <div class="col-md-2">
                <asp:TextBox ID="tbxID" runat="server" class="form-control" disabled></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Nombre" class="col-md-2 control-label"></asp:Label>
            <div class="col-md-2">
                <asp:TextBox ID="tbxNombre" runat="server" class="form-control text-box single-line"></asp:TextBox>
            </div>
            <div>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="El nombre es requerido" CssClass="text-danger" ControlToValidate="tbxNombre"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:RegularExpressionValidator ID="revNombre" runat="server" ErrorMessage="El nombre solo puede tener letras y espacios" CssClass="text-danger" ControlToValidate="tbxNombre" ValidationExpression="^[a-zA-ZÁÉÍÓÚáéíóúÑñ'\s]*$"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Primer Apellido" class="col-md-2 control-label"></asp:Label>
            <div class="col-md-2">
                <asp:TextBox ID="tbxPrimerAp" runat="server" class="form-control text-box single-line"></asp:TextBox>
            </div>
            <div>
                <asp:RequiredFieldValidator ID="rfvPrimerAp" runat="server" ErrorMessage="Los apellidos son requeridos" CssClass="text-danger" ControlToValidate="tbxPrimerAp"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:RegularExpressionValidator ID="revPrimerApellido" runat="server" ErrorMessage="Los apellidos solo pueden tener letras y espacios" CssClass="text-danger" ControlToValidate="tbxPrimerAp" ValidationExpression="^[a-zA-ZÁÉÍÓÚáéíóúÑñ'\s]*$"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Segundo Apellido" class="col-md-2 control-label"></asp:Label>
            <div class="col-md-2">
                <asp:TextBox ID="tbxSegundoAp" runat="server" class="form-control text-box single-line"></asp:TextBox>
            </div>
            <div>
                <asp:RequiredFieldValidator ID="rfvSegundoAp" runat="server" ErrorMessage="Los apellidos son requeridos" CssClass="text-danger" ControlToValidate="tbxSegundoAp"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:RegularExpressionValidator ID="revSegundoApellido" runat="server" ErrorMessage="Los apellidos solo pueden tener letras y espacios" CssClass="text-danger" ControlToValidate="tbxSegundoAp" ValidationExpression="^[a-zA-ZÁÉÍÓÚáéíóúÑñ'\s]*$"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Fecha de Nacimiento" class="col-md-2 control-label"></asp:Label>
                <div class="col-md-2">
                    <asp:TextBox ID="tbxFecha" runat="server" class="form-control" TextMode="Date"></asp:TextBox>
                </div>
            <div>
                <asp:RequiredFieldValidator ID="rfvFecha" runat="server" ErrorMessage="La fecha es requerida" CssClass="text-danger" ControlToValidate="tbxFecha"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:RangeValidator ID="rvFecha" runat="server" ErrorMessage="El año tiene que ser entre 1990 y 2000" MaximumValue="2000-12-31" MinimumValue="1990-01-01" ControlToValidate="tbxFecha" CssClass="text-danger"></asp:RangeValidator>
            </div>
        </div>
        <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Curp" class="col-md-2 control-label"></asp:Label>
                <div class="col-md-2">
                    <asp:TextBox ID="tbxCurp" runat="server" class="form-control text-box single-line"></asp:TextBox>
                </div>
            <div>
                <asp:RequiredFieldValidator ID="rfvCurp" runat="server" ErrorMessage="El curp es requerido" CssClass="text-danger" ControlToValidate="tbxCurp"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Curp inválido" ControlToValidate="tbxCurp" CssClass="text-danger" ValidationExpression="^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$"></asp:RegularExpressionValidator>
            </div>
            <div>
                <asp:CustomValidator ID="cvCurp" runat="server" ErrorMessage="La CURP no coincide con la fecha de nacimiento" ControlToValidate="tbxCurp" CssClass="text-danger" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </div>
        </div>
        <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Correo" class="col-md-2 control-label"></asp:Label>
                <div class="col-md-2">
                    <asp:TextBox ID="tbxCorreo" runat="server" class="form-control text-box single-line"></asp:TextBox>
                </div>
            <div>
                <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ErrorMessage="El correo es requerido" CssClass="text-danger" ControlToValidate="tbxCorreo"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Teléfono" class="col-md-2 control-label"></asp:Label>
                <div class="col-md-2">
                    <asp:TextBox ID="tbxTelefono" runat="server" class="form-control text-box single-line"></asp:TextBox>
                </div>
        </div>
        <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="Sueldo" class="col-md-2 control-label"></asp:Label>
                <div class="col-md-2">
                    <asp:TextBox ID="tbxSueldo" runat="server" class="form-control text-box single-line"></asp:TextBox>
                </div>
            <div>
            <asp:RangeValidator ID="rvSueldo" runat="server" ErrorMessage="El sueldo debe estar entre 10,000 y 40,000" ControlToValidate="tbxSueldo" MinimumValue="10000" MaximumValue="40000" Type="Currency" CssClass="text-danger"></asp:RangeValidator>
            </div>
        </div>
        <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="Estado" class="col-md-2 control-label"></asp:Label>
                <div class="col-md-2">
                    <asp:DropDownList ID="ddlEstado" runat="server" CssClass="form-control single-line"></asp:DropDownList>
                </div>
        </div>
        <div class="form-group">
                <asp:Label ID="Label10" runat="server" Text="Estatus" class="col-md-2 control-label"></asp:Label>
                <div class="col-md-2">
                    <asp:DropDownList ID="ddlEstatus" runat="server" CssClass="form-control single-line"></asp:DropDownList>
                </div>
        </div>
        <div class="form-group">
            <div class="col-md-2">
                <asp:Button class="btn btn-default" ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-2">
                <a href="index.aspx">Regresar a la lista</a>
            </div>
        </div>    
    </div>
</asp:Content>
