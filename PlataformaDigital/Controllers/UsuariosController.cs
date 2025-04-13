using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using CapaDatos.Database;
using CapaNegocios.Acciones;

namespace PlataformaDigital.Controllers
{
    public class UsuariosController : Controller
    {
        UsuariosServicio usuarioService = new UsuariosServicio();
        TipoUsuarioServicio tipoUsuariosService = new TipoUsuarioServicio();

        // GET: Usuarios
        public ActionResult Index()
        {
            var usuarios = usuarioService.GetUsuarios();
            return View(usuarios);
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int id)
        {
            return View(usuarioService.GetById(id));
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            var tipoUsuarios = tipoUsuariosService.GetList();
            
            ViewData["TiposUsuarios"] = new SelectList(tipoUsuarios, "Id", "Nombre"); // Pasas la lista al ViewData
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(Usuarios usuario)
        {
            try
            {
                // TODO: Add insert logic here

                usuarioService.Add(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            var usuario = usuarioService.GetById(id);
            var tipoUsuarios = tipoUsuariosService.GetList();
            ViewData["TipoUsuarioId"] = new SelectList(tipoUsuarios, "Id", "Nombre", usuario.TipoUsuarioId);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(Usuarios usuario)
        {
            try
            {
                // TODO: Add update logic here
                usuarioService.Update(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View(usuarioService.GetById(id));
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Usuarios usuario)
        {
            try
            {
                // El modelo solo trae el Id, recarga el resto desde la base de datos
                var entity = usuarioService.GetById(usuario.Id);
                if (entity == null)
                {
                    return HttpNotFound();
                }

                usuarioService.Delete(entity.Id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error deleting user: " + ex.Message);
                return View(usuario);
            }
        }

    }
}
