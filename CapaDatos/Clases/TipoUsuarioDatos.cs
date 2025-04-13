using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Database;

namespace CapaDatos.Clases
{
    public class TipoUsuarioDatos
    {
        PlatformDigitalEntities _context = new PlatformDigitalEntities();
        public List<TipoUsuarios> GetList()
        {
			List<TipoUsuarios> data = new List<TipoUsuarios>();

			try
			{
				data = _context.TipoUsuarios.ToList();
			}
			catch (Exception ex)
			{
				data = Enumerable.Empty<TipoUsuarios>().ToList();
			}

			return data;
        }
    }
}
