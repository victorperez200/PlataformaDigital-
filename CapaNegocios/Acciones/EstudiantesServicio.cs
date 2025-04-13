using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos.Database;

namespace CapaNegocios.Acciones
{
    public class EstudiantesServicio : AccionesBases
    {
        //PlataformaDigitalDataContext _context;
        //public EstudiantesServicio(PlataformaDigitalDataContext context)
        //{
        //    _context = context;
        //}

        //public List<CapaDatos.Database.Estudiantes> Listar()
        //{

        //    return _context.Estudiantes.ToList();

        //}

        //public CapaDatos.Database.Estudiantes ObtenerPorId(int id)
        //{
        //    return CapaDatos.Database.Estudiantes.Select(x => new Alumno()
        //    {
        //        id = x.idAlumno,
        //        Correo = x.
        //    }).FirstOrDefault(c => c.id == id);
        //}

        //public void Agregar(Estudiantes estudiante)
        //{

        //    _context.Estudiantes.InsertOnSubmit(estudiante);
        //    _context.SubmitChanges();
        //}

        //public bool Actualizar(Alumno alumno)
        //{

        //    {
        //        var existente = dbUNIContext.Alumnos.FirstOrDefault(c => c.Id == alumno.Id);
        //        if (existente == null) return false;

        //        existente.Nombre = alumno.Nombre;
        //        existente.Descripcion = alumno.Descripcion;
        //        dbUNIContext.SaveChanges();
        //        return true;
        //    }
        //}

        //public bool Eliminar(int id)
        //{
        //    {
        //        var curso = dbUNIContext.Alumnos.FirstOrDefault(c => c.Id == id);
        //        if (curso == null) return false;

        //        dbUNIContext.Alumnos.Remove(curso);
        //        dbUNIContext.SaveChanges();
        //        return true;
        //    }
        //}

    }
}
