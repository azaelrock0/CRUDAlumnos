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
    public partial class edit : System.Web.UI.Page
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

                int id = Convert.ToInt16(Request.QueryString["id"] ?? "1");
                NAlumno crud = new NAlumno();
                Alumno alumno = new Alumno();
                alumno = crud.Consultar(id);
                tbxID.Text = alumno.id + "";
                tbxNombre.Text = alumno.nombre;
                tbxPrimerAp.Text = alumno.primerApellido;
                tbxSegundoAp.Text = alumno.segundoApellido;
                tbxCorreo.Text = alumno.correo;
                tbxTelefono.Text = alumno.telefono;
                tbxFecha.Text = alumno.fechaNacimiento.ToString("yyyy-MM-dd");
                tbxCurp.Text = alumno.curp;
                tbxSueldo.Text = alumno.sueldo + "";
                ddlEstado.SelectedValue = alumno.idEstadoOrigen + "";
                ddlEstatus.SelectedValue = alumno.idEstatus + "";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int id = Convert.ToInt16(Request.QueryString["id"] ?? "1");
                NAlumno crud = new NAlumno();
                Alumno alumno = new Alumno();
                alumno = crud.Consultar(id);
                if (alumno != null)
                {
                    alumno.nombre = tbxNombre.Text;
                    alumno.primerApellido = tbxPrimerAp.Text;
                    alumno.segundoApellido = tbxSegundoAp.Text;
                    alumno.correo = tbxCorreo.Text;
                    alumno.telefono = tbxTelefono.Text;
                    alumno.fechaNacimiento = Convert.ToDateTime(tbxFecha.Text);
                    alumno.curp = tbxCurp.Text;
                    if (tbxSueldo.Text != "")
                    {
                        alumno.sueldo = decimal.Parse(tbxSueldo.Text);
                    }
                    alumno.idEstadoOrigen = int.Parse(ddlEstado.SelectedValue);
                    alumno.idEstatus = int.Parse(ddlEstatus.SelectedValue);
                    crud.Actualizar(alumno);
                    Response.Redirect("index");
                }
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var fechaFecha = tbxFecha.Text;
            var fechaCurp = args.Value;

            var fecha1 = fechaFecha.Substring(2, 2) + fechaFecha.Substring(5, 2) + fechaFecha.Substring(8, 2);
            var fecha2 = fechaCurp.Substring(4, 6);

            if (fecha1 == fecha2) args.IsValid = true;
            else args.IsValid = false;
        }
    }
}