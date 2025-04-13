using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Modelo
{
    public class Estudiantes
    {
        public int UsuarioId { get; set; }
        public int Matricula { get; set; }
        public Usuarios Usuarios { get; set; }
        public ICollection<Cursos_Estudiantes> Cursos_Estudiantes { get; set; }
        public ICollection<Entregables> Entregables { get; set; }
    }
}
