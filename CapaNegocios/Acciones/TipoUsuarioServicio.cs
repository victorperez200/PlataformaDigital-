using System.Collections.Generic;
using CapaDatos.Clases;
using CapaDatos.Database;

namespace CapaNegocios.Acciones
{
    public class TipoUsuarioServicio
    {
        TipoUsuarioDatos data = new TipoUsuarioDatos();

        public List<TipoUsuarios> GetList()
        {
            return data.GetList();
        }
        
    }
}
