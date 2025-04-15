using PlataformaDigital.Models;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PlataformaDigital.Controllers
{
    public class AuthController : Controller
    {
        // Usuarios simulados
        private static List<Usuario> Usuarios = new List<Usuario>
        {
            new Usuario { NombreUsuario = "profesor1", Contraseña = "1234", Rol = "Profesor" },
            new Usuario { NombreUsuario = "alumno1", Contraseña = "1234", Rol = "Alumno" }
        };

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string nombreUsuario, string contraseña)
        {
            var usuario = Usuarios.Find(u => u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña);

            if (usuario != null)
            {
                FormsAuthentication.SetAuthCookie(usuario.NombreUsuario, false);
                Session["Rol"] = usuario.Rol;

                if (usuario.Rol == "Profesor")
                    return RedirectToAction("Index", "Profesor");
                else
                    return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Credenciales incorrectas.";
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}
