<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="details.aspx.cs" Inherits="Presentacion.Alumnos.details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h3>Datos del Alumno</h3>
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
                <asp:Button ID="btnIMSS" runat="server" Text="Calcular IMSS" CssClass="btn btn-primary" OnClick="btnIMSS_Click"/>
		    </div>
            <div class="col-md-2">
                <asp:Button ID="btnISR" runat="server" Text="Calcular ISR" CssClass="btn" OnClick="btnISR_Click" />
		    </div>
	    </div>
        <div class="form-group">
            <div class="col-md-2">
                <a href="index.aspx">Regresar a la lista</a>
            </div>
        </div>
        <!-- Modal -->
        <div class="modal fade" id="modal1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">
                            <span aria-hidden="true">&times;</span><span class="sr-only">Cerrar</span>
                        </button>
                        <h4 class="modal-title" id="myModalLabel">
                            <asp:Label ID="lblMdlTitulo" runat="server" Text="Label"></asp:Label>
                        </h4>
                    </div>
                    <div class="modal-body">
                        <div class="row" style="padding:15px">
                            <asp:Label ID="lblMdlBody" runat="server" Text="Label"></asp:Label>                
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-danger" data-dismiss="modal">Cerrar</button>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <script type="text/javascript">
        function openModal1() {
            $('#modal1').modal('show');
        }
        function WSAlumnos(id) {
            $.ajax(
                {
                    type: "POST",
                    url: "http://localhost:51408/WSAlumnos.asmx/CalcularIMSS",
                    data: "{'id':'" + id +"'}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: funcExito,
                    error: errorGenerico
                }
            );
        }
        function funcExito(resultado) {
            try {
                var oRespuesta = resultado.d;
                if (oRespuesta != null) {
                        $("#<%=lblMdlTitulo.ClientID%>").text("Cálculo del IMSS")
                        $("#<%=lblMdlBody.ClientID%>").html("<strong>Enfermedades y Maternidad</strong><br>" +
                            oRespuesta.enfermedadMaternidad.toLocaleString("en", { style: "currency", currency: "USD" }) +
                            "<br><strong>Invalidez y Vida</strong><br>" +
                            oRespuesta.invalidezVida.toLocaleString("en", { style: "currency", currency: "USD" }) +
                            "<br><strong>Retiro</strong><br>" +
                            oRespuesta.retiro.toLocaleString("en", { style: "currency", currency: "USD" }) +
                            "<br><strong>Cesantía</strong><br>" +
                            oRespuesta.cesantia.toLocaleString("en", { style: "currency", currency: "USD" }) +
                            "<br><strong>Infonavit</strong><br>" +
                            oRespuesta.infonavit.toLocaleString("en", { style: "currency", currency: "USD" }));
                    openModal1();
                }
                else {
                    alert('La respuesta recibida del Web Service es incorrecta ' + resultado.d);
                }
            }
            catch (ex) {
                alert('Error al recibir los datos');
            }
        }
        function errorGenerico(jqXHR, estatus, error) {
            var msg = '';
            if (jqXHR.status === 0) {
                msg = 'No está conectado, favor de verificar su conexión.';
            }
            else if (jqXHR.status === 404) {
                msg = 'Página no encontrada [404]';
            }
            else if (jqXHR.status === 500) {
                msg = 'Error no hay conexión al servidor [500]';
            }
            else if (jqXHR.status === 'parseerror') {
                msg = 'El parseo del JSON es erróneo.';
            }
            else if (jqXHR.status === 'timeout') {
                $('body').addClass('loaded');
            }
            else if (jqXHR.status === 'abort') {
                msg = 'La petición Ajax fue abortada.';
            }
            else {
                msg = 'Error no conocido. ';
                console.log(exception);
            }
            alert(msg);
        }
    </script>
</asp:Content>
