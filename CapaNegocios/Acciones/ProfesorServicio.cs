using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases;
using CapaDatos.Database;

namespace CapaNegocios.Acciones
{
    public class ProfesorServicio
    {
        ProfesorDatos data = new ProfesorDatos();
        public List<Usuarios> GetList()
        {
            return data.GetList();
        }
    }
}
