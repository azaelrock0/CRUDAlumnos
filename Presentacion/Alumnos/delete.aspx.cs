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
    public partial class delete : System.Web.UI.Page
    {
        NAlumno nAlumno = new NAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt16(Request.QueryString["id"] ?? "1");
                
                Alumno alumno = new Alumno();
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
                    lblSueldo.Text = alumno.sueldo + "";
                else
                    lblSueldo.Text = "NULL";
                lblEstado.Text = estado.nombre;
                lblEstatus.Text = estatus.nombre;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["id"] ?? "1");
            nAlumno.Eliminar(id);
            Response.Redirect("index");
        }
    }
}