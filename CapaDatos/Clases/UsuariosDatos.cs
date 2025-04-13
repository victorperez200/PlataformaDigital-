using CapaDatos.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class UsuariosDatos
    {
        PlatformDigitalEntities _context = new PlatformDigitalEntities();
        public List<Usuarios> GetUsers()
        {
            return _context.Usuarios.ToList();
        }

        public void Add(Usuarios usuario)
        {
            try
            {
                // VALOR POR DEFECTO AL CREAR UN NUEVO USUARIO.
                usuario.Activo = true;

                _context.Usuarios.Add(usuario);
                _context.SaveChanges();

                if (usuario.TipoUsuarioId == 2)
                {
                    var estudianteUltimoCreado = _context.Estudiantes.OrderByDescending(x => x.UsuarioId).FirstOrDefault();

                    Estudiantes EstudianteAdd = new Estudiantes()
                    {
                        UsuarioId = usuario.Id
                    };

                    if (estudianteUltimoCreado == null)
                    {
                        // Si no hay estudiantes, asignamos la matrícula inicial
                        EstudianteAdd.Matricula = $"{DateTime.Now.Year}0001"; // Formato Año + 0001
                    }
                    else
                    {
                        // Si ya hay estudiantes, sumamos 1 al último número de matrícula
                        var ultimaMatricula = estudianteUltimoCreado.Matricula;

                        // Eliminamos el guion si existe, y convertimos la matrícula completa a un número
                        var matriculaSinGuion = ultimaMatricula.Replace("-", ""); // Eliminamos el guion
                        var numeroMatricula = int.Parse(matriculaSinGuion); // Convertimos a entero

                        // Sumamos 1 al número de la matrícula
                        var nuevaMatriculaNumero = numeroMatricula + 1;

                        // Reconstruimos la matrícula con el guion después de sumar 1
                        EstudianteAdd.Matricula = $"{nuevaMatriculaNumero.ToString().Insert(4, "-")}"; // Insertamos el guion después del año
                    }

                    _context.Estudiantes.Add(EstudianteAdd);
                    _context.SaveChanges();
                }
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }

        public Usuarios GetById(int id)
        {
            return _context.Usuarios.Find(id);
        }


        public void Update(Usuarios usuarioActualizado)
        {
           var usuarioExistente = _context.Usuarios.Find(usuarioActualizado.Id);

            if(usuarioExistente != null)
            {
                // Actualiza las propiedades necesarias
                usuarioExistente.Nombre = usuarioActualizado.Nombre;
                usuarioExistente.Apellido = usuarioActualizado.Apellido;
                usuarioExistente.Email = usuarioActualizado.Email;
                usuarioExistente.Contrasena = usuarioActualizado.Contrasena;
                usuarioExistente.Activo = usuarioActualizado.Activo;
                usuarioExistente.TipoUsuarioId = usuarioActualizado.TipoUsuarioId;
                usuarioExistente.FechaRegistro = usuarioExistente.FechaRegistro;

                _context.SaveChanges();
            }
        }
    }
}
