using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NEstado
    {
        DEstado crud = new DEstado();
        public List<Estado> Consultar()
        {
            return crud.Consultar();
        }
        public Estado Consultar(int id)
        {
            return crud.Consultar(id);
        }
    }
}
