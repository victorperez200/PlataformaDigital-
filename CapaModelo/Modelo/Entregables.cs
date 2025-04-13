using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Modelo
{
    public class Entregables
    {
        public int Id { get; set; }
        public int TareaId { get; set; }
        public Tareas Tareas { get; set; }
        public int EstudianteId { get; set; }
        public Estudiantes Estudiantes { get; set; }
        public string NombreDocumento { get; set; }
        public string Extension { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
