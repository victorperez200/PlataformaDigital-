using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Database;

namespace CapaDatos.Clases
{
       public class EstudianteDatos
    {
        PlatformDigitalEntities _context = new PlatformDigitalEntities();


        public List<Estudiantes> GetEstudiantes()
        {
            return _context.Estudiantes.ToList();
        }
        public void Add(Estudiantes estudiantes)
        {
            try
            {
                _context.Estudiantes.Add(estudiantes);
                _context.SaveChanges();

            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            var estudiante = _context.Estudiantes.Find(id);
            _context.Estudiantes.Remove(estudiante);
            _context.SaveChanges();
        }

        public Estudiantes GetById(int id)
        {
            return _context.Estudiantes.Find(id);
        }


        public void Update(Estudiantes estudianteActualizado)
        {
            var estudianteExistente = _context.Estudiantes.Find(estudianteActualizado.UsuarioId);

            if (estudianteExistente != null)
            {
                // Actualiza las propiedades necesarias
                estudianteExistente.UsuarioId = estudianteActualizado.UsuarioId;
                estudianteExistente.Matricula = estudianteActualizado.Matricula;


            _context.SaveChanges();
            }
        }
    }
}
