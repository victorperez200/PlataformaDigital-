using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Database;

namespace CapaModelo.Modelo
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public int TipoUsuarioId { get; set; }
        public TipoUsuarios TipoUsuarios { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public ICollection<Estudiantes> Estudiantes { get; set; }
    }
}
