using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Modelo
{
    public class Cursos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Seccion { get; set; }
        public int ProfesorId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Estado { get; set; }
        public ICollection<Cursos_Estudiantes> Cursos_Estudiantes { get; set; }
        public ICollection<Tareas> Tareas { get; set; }
    }
}
