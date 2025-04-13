using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Modelo
{
    public class Tareas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaVecimiento { get; set; }
        public int CursoId { get; set; }
        public Cursos Cursos { get; set; }
        public ICollection<Entregables> Entregables { get; set; }
    }
}
