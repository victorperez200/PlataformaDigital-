using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Database;

namespace CapaDatos.Clases
{
    public class TareasDatos
    {
        PlatformDigitalEntities _context = new PlatformDigitalEntities();


        public List<Tareas> GetTareas()
        {
            return _context.Tareas.ToList();
        }
        public void Add(Tareas tareas)
        {
            try
            {
                _context.Tareas.Add(tareas);
                _context.SaveChanges();

            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            var tarea = _context.Tareas.Find(id);
            _context.Tareas.Remove(tarea);
            _context.SaveChanges();
        }

        public Tareas GetById(int id)
        {
            return _context.Tareas.Find(id);
        }


        public void Update(Tareas tareaActualizado)
        {
            var tareaExistente = _context.Tareas.Find(tareaActualizado.Id);

            if (tareaExistente != null)
            {
                // Actualiza las propiedades necesarias
                tareaExistente.Nombre = tareaActualizado.Nombre;
                tareaExistente.Descripcion = tareaActualizado.Descripcion;
                tareaExistente.CursoId = tareaActualizado.CursoId;
                tareaExistente.FechaCreacion = tareaActualizado.FechaCreacion;
                tareaExistente.FechaVencimiento = tareaActualizado.FechaVencimiento;
               

                _context.SaveChanges();
            }
        }
    }
}
