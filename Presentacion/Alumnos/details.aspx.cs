using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Presentacion.Alumnos
{
    public partial class details : System.Web.UI.Page
    {
        NAlumno nAlumno = new NAlumno();
        Alumno alumno = new Alumno();
        int id = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt16(Request.QueryString["id"] ?? "1");
            NEstado nEstado = new NEstado();
            Estado estado = new Estado();
            NEstatusAlumno nEstatus = new NEstatusAlumno();
            EstatusAlumno estatus = new EstatusAlumno();
            alumno = nAlumno.Consultar(id);
            estado = nEstado.Consultar(alumno.idEstadoOrigen);
            estatus = nEstatus.Consultar(alumno.idEstatus);

            lblId.Text = alumno.id + "";
            lblNombre.Text = alumno.nombre;
            lblPrimerAp.Text = alumno.primerApellido;
            lblSegundoAp.Text = alumno.segundoApellido;
            lblCorreo.Text = alumno.correo;
            lblTelefono.Text = alumno.telefono;
            lblFecha.Text = alumno.fechaNacimiento.ToString("dd/MM/yyyy");
            lblCurp.Text = alumno.curp;
            if (alumno.sueldo.ToString() != "")
                lblSueldo.Text = alumno.sueldo+"";
            else
                lblSueldo.Text = "NULL";
            lblEstado.Text = estado.nombre;
            lblEstatus.Text = estatus.nombre;
        }

        protected void btnIMSS_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", $"WSAlumnos({id});", true);
            /*AportacionesIMSS aportaciones = new AportacionesIMSS();
            aportaciones = nAlumno.CalcularIMSS(id);
            lblMdlTitulo.Text = "Cálculo del IMSS";
            string body = $"<strong>Enfermedades y Maternidad</strong><br>{aportaciones.enfermedadMaternidad.ToString("C2")}<br>" +
                $"<strong>Invalidez y Vida</strong><br>{aportaciones.invalidezVida.ToString("C2")}<br>" +
                $"<strong>Retiro</strong><br>{aportaciones.retiro.ToString("C2")}<br>" +
                $"<strong>Cesantía</strong><br>{aportaciones.cesantia.ToString("C2")}<br>" +
                $"<strong>Infonavit</strong><br>{aportaciones.infonavit.ToString("C2")}";
            lblMdlBody.Text = body;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal1();", true);*/
        }

        protected void btnISR_Click(object sender, EventArgs e)
        {
            ItemTablaISR item = new ItemTablaISR();
            decimal ISR = 0;
            item = nAlumno.CalcularISR(id);
            ISR = Convert.ToDecimal(item.ISR);

            lblMdlTitulo.Text = "Cálculo del ISR";
            string body = $"<strong>Límite Inferior</strong><br>{item.limiteInferior.ToString("C2")}<br>" +
                $"<strong>Límite Superior</strong><br>{item.limiteSuperior.ToString("C2")}<br>" +
                $"<strong>Cuota Fija</strong><br>{item.cuotaFija.ToString("C2")}<br>" +
                $"<strong>Excedente Límite Inferior</strong><br>{item.excedente.ToString("C2")}<br>" +
                $"<strong>Subsidio</strong><br>{item.subsidio.ToString("C2")}<br>" +
                $"<strong>Impuesto</strong><br>{ISR.ToString("C2")}";
            lblMdlBody.Text = body;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal1();", true);
        }
    }
}