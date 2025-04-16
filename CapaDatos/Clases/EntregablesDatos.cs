using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Database;

namespace CapaDatos.Clases
{
    public class EntregablesDatos
    {
        PlatformDigitalEntities _context = new PlatformDigitalEntities();
        
        public List<Entregables> GetEntregables()
        {
            return _context.Entregables.ToList();
        }
        public void Add(Entregables entregables)
        {
            try
            {
                _context.Entregables.Add(entregables);
                _context.SaveChanges();

            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            var entregable = _context.Entregables.Find(id);

         if (entregable != null)
            {
                _context.Entregables.Remove(entregable);
                _context.SaveChanges();
            }
        }

        public Entregables GetById(int id)
        {
            return _context.Entregables.Find(id);
        }


        public void Update(Entregables entregableActualizado)
        {
            var entregableExistente = _context.Entregables.Find(entregableActualizado.Id);

            if (entregableExistente != null)
            {
                // Actualiza las propiedades necesarias
                entregableExistente.TareaId = entregableActualizado.TareaId;
                entregableExistente.EstudianteId = entregableActualizado.EstudianteId;
                entregableExistente.NombreDocumento = entregableActualizado.NombreDocumento;
                entregableExistente.Extension = entregableActualizado.Extension;
                entregableExistente.FechaCreacion = entregableActualizado.FechaCreacion;
                


                _context.SaveChanges();
            }

        }
    }
}
