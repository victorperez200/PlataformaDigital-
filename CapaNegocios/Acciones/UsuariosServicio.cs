using System;
using System.Collections.Generic;
using CapaDatos.Clases;
using CapaDatos.Database;

namespace CapaNegocios.Acciones
{
    public class UsuariosServicio
    {
        UsuariosDatos data = new UsuariosDatos();

        public List<Usuarios> GetUsuarios()
        {
            return data.GetUsers();
        }

        public void Add(Usuarios usuario)
        {
            data.Add(usuario);
        }

        public void Delete(int id)
        {
            data.Delete(id);
        }
        public Usuarios GetById(int id)
        {
            return data.GetById(id);
        }
        
        public void Update(Usuarios usuarios)
        {
            data.Update(usuarios);
        }

        public static object GetList()
        {
            throw new NotImplementedException();
        }
    }
}
