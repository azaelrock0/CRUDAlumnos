using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NEstatusAlumno
    {
        DEstatusAlumno crud = new DEstatusAlumno(); 
        public List<EstatusAlumno> Consultar()
        {
            return crud.Consultar();
        }
        public EstatusAlumno Consultar(int id)
        {
            return crud.Consultar(id);
        }
    }
}
