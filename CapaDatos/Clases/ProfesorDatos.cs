using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Database;

namespace CapaDatos.Clases
{
    public class ProfesorDatos
    {
        PlatformDigitalEntities _context = new PlatformDigitalEntities();

        public List<Usuarios> GetList()
        {
            List<Usuarios> data = new List<Usuarios>();

            try
            {
                //Filtro para que unicamente se traigan los profesores
                data = _context.Usuarios.Where(x => x.TipoUsuarioId == 1).ToList();
            }
            catch (Exception ex)
            {
                data = Enumerable.Empty<Usuarios>().ToList();
            }

            return data;
        }
    }
}
