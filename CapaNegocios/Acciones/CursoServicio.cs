using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases;
using CapaDatos.Database;


namespace CapaNegocios.Acciones
{
    public class CursoServicio : AccionesBases
    {
        CursosDatos data = new CursosDatos();

        public List<Cursos> GetCursos()
        {
            return data.GetCursos();
        }

        public void Add(Cursos cursos)
        {
            data.Add(cursos);
        }

        public void Delete(int id)
        {
            data.Delete(id);
        }
        public Cursos GetById(int id)
        {
            return data.GetById(id);
        }

        public void Update(Cursos cursos)
        {
            data.Update(cursos);
        }
    }
}
