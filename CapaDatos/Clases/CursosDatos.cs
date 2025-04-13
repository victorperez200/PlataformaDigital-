using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Database;

namespace CapaDatos.Clases
{
    public class CursosDatos
    {
        PlatformDigitalEntities _context = new PlatformDigitalEntities();


        public List<Cursos> GetCursos()
        {
            return _context.Cursos.ToList();
        }
        public void Add(Cursos cursos)
        {
            try
            {
                _context.Cursos.Add(cursos);
                _context.SaveChanges();
                
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            var curso = _context.Cursos.Find(id);
            _context.Cursos.Remove(curso);
            _context.SaveChanges();
        }

        public Cursos GetById(int id)
        {
            return _context.Cursos.Find(id);
        }


        public void Update(Cursos cursoActualizado)
        {
            var cursoExistente = _context.Cursos.Find(cursoActualizado.Id);

            if (cursoExistente != null)
            {
                // Actualiza las propiedades necesarias
                cursoExistente.Descripcion = cursoActualizado.Descripcion;
                cursoExistente.Seccion = cursoActualizado.Seccion;
                cursoExistente.ProfesorId = cursoActualizado.ProfesorId;
                cursoExistente.FechaInicio = cursoActualizado.FechaInicio;
                cursoExistente.FechaFin = cursoActualizado.FechaFin;
                cursoExistente.Estado = cursoActualizado.Estado;

                _context.SaveChanges();
            }
        }
    }
}
