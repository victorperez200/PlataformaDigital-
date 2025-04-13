using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Modelo
{
    public class Cursos_Estudiantes
    {
        public int CursoId { get; set; }
        public Cursos Cursos { get; set; }
        public int EstudianteId { get; set; }
        public Estudiantes Estudiantes { get; set; }
    }
}
