using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CapaDatos.Database;
using CapaNegocios.Acciones;

namespace PlataformaDigital.Controllers
{
    public class EstudiantesController : Controller
    {
        EstudiantesServicio estudianteServicio = new EstudiantesServicio();
        TipoUsuarioServicio tipoUsuariosService = new TipoUsuarioServicio();
        UsuariosServicio usuarioService = new UsuariosServicio();

        // GET: Estudiantes
        public ActionResult Index()
        {
            return View(estudianteServicio.GetEstudiantes());
        }

        // GET: Estudiantes/Details/5
        public ActionResult Details(int id)
        {
            return View(estudianteServicio.GetById(id));
        }

        // GET: Estudiantes/Create
        public ActionResult Create()
        {
          var tipoUsuarios = tipoUsuariosService.GetList();
          var Usuarios = UsuariosServicio.GetList();


            ViewData["TiposUsuarios"] = new SelectList(tipoUsuarios, "Id", "Nombre");// Pasas la lista al ViewData
           
        ViewData["UsuarioId"] = new SelectList((System.Collections.IEnumerable)usuarioService, "Id", "Nombre");
            return View();
        }

        // POST: Estudiantes/Create
        [HttpPost]
        public ActionResult Create(Estudiantes estudiantes)
        {
            try
            {
                // TODO: Add insert logic here

                estudianteServicio.Add(estudiantes);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiantes/Edit/5
        public ActionResult Edit(int id)
        {
            var estudiantes = EstudiantesServicio.GetList();

            ViewData["EstudianteId"] = new SelectList(estudiantes, "Id", "Nombre");

            var usuario = usuarioService.GetById(id);

            return View(usuario);
        }

        // POST: Estudiantes/Edit/5
        [HttpPost]
        public ActionResult Edit(Estudiantes Estudiantes)
        {
            try
            {
                // TODO: Add update logic here
                estudianteServicio.Update(Estudiantes);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Estudiantes/Delete/5
        public ActionResult Delete(int id)
        {

            return View(estudianteServicio.GetById(id));
        }

        // POST: Estudiantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Estudiantes Estudiantes)
        {
            try
            {
                // El modelo solo trae el Id, recarga el resto desde la base de datos
                var entity = estudianteServicio.GetById(Estudiantes.UsuarioId);
                if (entity == null)
                {
                    return HttpNotFound();
                }

                estudianteServicio.Delete(entity.UsuarioId);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error deleting user: " + ex.Message);
                return View(Estudiantes);

            }
        }
    }
}
