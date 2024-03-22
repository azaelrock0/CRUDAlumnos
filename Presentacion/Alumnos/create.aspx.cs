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
    public partial class create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NEstatusAlumno nEstatusAlumno = new NEstatusAlumno();
                List<EstatusAlumno> listaEstatus = new List<EstatusAlumno>();
                listaEstatus = nEstatusAlumno.Consultar();
                ddlEstatus.DataSource = listaEstatus;
                ddlEstatus.DataTextField = "nombre";
                ddlEstatus.DataValueField = "id";
                ddlEstatus.DataBind();

                NEstado nEstado = new NEstado();
                List<Estado> listaEstados = new List<Estado>();
                listaEstados = nEstado.Consultar();
                ddlEstado.DataSource = listaEstados;
                ddlEstado.DataTextField = "nombre";
                ddlEstado.DataValueField = "id";
                ddlEstado.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NAlumno nAlumno = new NAlumno();
            Alumno alumno = new Alumno()
            {
                nombre = tbxNombre.Text,
                primerApellido = tbxPrimerAp.Text,
                segundoApellido = tbxSegundoAp.Text,
                correo = tbxCorreo.Text,
                telefono = tbxTelefono.Text,
                fechaNacimiento = DateTime.Parse(tbxFecha.Text),
                curp = tbxCurp.Text,
                idEstadoOrigen = int.Parse(ddlEstado.SelectedValue),
                idEstatus = int.Parse(ddlEstatus.SelectedValue)
            };
            if(tbxSueldo.Text != "")
            {
                alumno.sueldo = decimal.Parse(tbxSueldo.Text);
            }
            nAlumno.Agregar(alumno);
            Response.Redirect("index");
            
        }
    }
}