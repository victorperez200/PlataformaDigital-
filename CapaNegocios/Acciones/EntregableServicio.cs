using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases;
using CapaDatos.Database;

namespace CapaNegocios.Acciones
{
    public class EntregableServicio
    {
        EntregablesDatos data = new EntregablesDatos();

        public List<Entregables> GetEntregables()
        {
            return data.GetEntregables();
        }

        public void Add(Entregables entregables)
        {
            data.Add(entregables);
        }

        public void Delete(int id)
        {
            data.Delete(id);
        }
        public Entregables GetById(int id)
        {
            return data.GetById(id);
        }

        public void Update(Entregables  entregables)
        {
            data.Update(entregables);
        }
    }
}
