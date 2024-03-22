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
    public partial class index : System.Web.UI.Page
    {
        List<Alumno> alumnos = new List<Alumno>();
        List<Estado> estados = new List<Estado>();
        List<EstatusAlumno> estatus = new List<EstatusAlumno>();
        NAlumno nAlumno = new NAlumno();
        NEstado nEstado = new NEstado();
        NEstatusAlumno nEstatus = new NEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            alumnos = nAlumno.Consultar();
            estados = nEstado.Consultar();
            estatus = nEstatus.Consultar();
            var oAlumnos = from a in alumnos
                            join est in estatus on a.idEstatus equals est.id
                            join edo in estados on a.idEstadoOrigen equals edo.id
                            select new { id = a.id, nombre = a.nombre, a.primerApellido, a.segundoApellido, a.correo, a.telefono, nombreEstado = edo.nombre, nombreEstatus = est.nombre };
            gview.DataSource = oAlumnos.ToList();
            gview.DataBind();
        }

        protected void gview_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName != "Page")
            {
                int renglon = Convert.ToInt16(e.CommandArgument);
                GridViewRow row = gview.Rows[renglon];
                TableCell celda = row.Cells[0];
                int id = Convert.ToInt16(celda.Text);
                switch (e.CommandName)
                {
                    case "Details":
                        Response.Redirect($"details?id={id}");
                        break;
                    case "Edit":
                        Response.Redirect($"edit?id={id}");
                        break;
                    case "Delete":
                        Response.Redirect($"delete?id={id}");
                        break;
                    default:
                        break;
                }
            }
        }

        protected void gview_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var oAlumnos = from a in alumnos
                           join est in estatus on a.idEstatus equals est.id
                           join edo in estados on a.idEstadoOrigen equals edo.id
                           select new { id = a.id, nombre = a.nombre, a.primerApellido, a.segundoApellido, a.correo, a.telefono, nombreEstado = edo.nombre, nombreEstatus = est.nombre };
            gview.PageIndex = e.NewPageIndex;
            gview.DataSource = oAlumnos.ToList();
            gview.DataBind();
        }
    }
}