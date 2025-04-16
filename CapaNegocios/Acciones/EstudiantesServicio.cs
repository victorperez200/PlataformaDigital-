using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos.Database;
using CapaDatos.Clases;
using System.Collections;

namespace CapaNegocios.Acciones
{
    public class EstudiantesServicio 
    {
        EstudianteDatos data = new EstudianteDatos();

        public List<Estudiantes> GetEstudiantes()
        {
            return data.GetEstudiantes();
        }

        public void Add(Estudiantes estudiantes)
        {
            data.Add(estudiantes);
        }

        public void Delete(int id)
        {
            data.Delete(id);
        }
        public Estudiantes GetById(int id)
        {
            return data.GetById(id);
        }

        public void Update(Estudiantes estudiantes)
        {
            data.Update(estudiantes);
        }

        public static IEnumerable GetList()
        {
            throw new NotImplementedException();
        }
    }
}
