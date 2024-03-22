using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;
using Datos;
using System.Configuration;
using Newtonsoft.Json;

namespace Negocio
{
    public class NAlumno
    {
        DAlumno dAlumno = new DAlumno();
        public List<Alumno> Consultar()
        {
            return dAlumno.Consultar();
        }
        public Alumno Consultar(int id)
        {
            return dAlumno.Consultar(id);
        }
        public void Agregar(Alumno alumno)
        {
            dAlumno.Agregar(alumno);
        }
        public void Actualizar(Alumno alumno)
        {
            dAlumno.Actualizar(alumno);
        }
        public void Eliminar(int id)
        {
            dAlumno.Eliminar(id);
        }
        public ItemTablaISR CalcularISR(int id)
        {
            ItemTablaISR itemRes = new ItemTablaISR();
            try
            {
                Negocio.RefWSAlumnos.WSAlumnosSoapClient WSalumnos = new RefWSAlumnos.WSAlumnosSoapClient();
                var itemResJson = JsonConvert.SerializeObject(WSalumnos.CalcularISR(id));
                itemRes =JsonConvert.DeserializeObject<ItemTablaISR>(itemResJson);
            } catch (Exception)
            {
                Alumno alumno = dAlumno.Consultar(id);
                decimal sueldo = Convert.ToDecimal(alumno.sueldo);
                if (alumno.sueldo != null)
                {
                    List<ItemTablaISR> tablaISR = new List<ItemTablaISR>();
                    tablaISR = dAlumno.ConsultarTablaISR();
                    decimal sueldoQuincenal = sueldo / 2;
                    int fila = 0;
                    itemRes = tablaISR.Find(x => x.limiteInferior <= sueldoQuincenal && x.limiteSuperior >= sueldoQuincenal);
                    itemRes.ISR = (sueldoQuincenal - itemRes.limiteInferior) * (itemRes.excedente / 100) + itemRes.cuotaFija - itemRes.subsidio;
                }
                else
                {
                    itemRes = new ItemTablaISR()
                    {
                        limiteInferior = 0,
                        limiteSuperior = 0,
                        cuotaFija = 0,
                        excedente = 0,
                        subsidio = 0
                    };
                }
            }
            return itemRes;
        }
        public AportacionesIMSS CalcularIMSS(int id)
        {
            Alumno alumno = dAlumno.Consultar(id);
            decimal SBC = Convert.ToDecimal(alumno.sueldo);
            string strUMA = ConfigurationManager.AppSettings["UMA"];
            decimal UMA = decimal.Parse(strUMA);
            AportacionesIMSS aportaciones = new AportacionesIMSS();
            if (SBC != 0)
                aportaciones.enfermedadMaternidad = (SBC - (3 * UMA)) / 100 * 0.4m;
            else
                aportaciones.enfermedadMaternidad = 0;
            aportaciones.invalidezVida = SBC / 100 * 0.625m;
            aportaciones.retiro = 0;
            aportaciones.cesantia = SBC / 100 * 1.125m;
            aportaciones.infonavit = 0;
            return aportaciones;
        }
    }
}
