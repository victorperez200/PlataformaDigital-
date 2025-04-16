using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaDatos.Database;
using CapaNegocios.Acciones;

namespace PlataformaDigital.Controllers
{
    public class TareasController : Controller
    {
        TareaServicio tareaServicio = new TareaServicio();
        CursoServicio cursoServicio = new CursoServicio();

        // GET: Tareas
        public ActionResult Index()
        {
            return View(tareaServicio.GetTareas());
        }

        // GET: Tareas/Details/5
        public ActionResult Details(int id)
        {
            return View(tareaServicio.GetById(id));
        }

        // GET: Tareas/Create
        public ActionResult Create()
        {
            ViewData["CursoId"] = new SelectList(cursoServicio.GetCursos(), "Id", "Descripcion");
            return View();
        }

        // POST: Tareas/Create
        [HttpPost]
        public ActionResult Create(Tareas tareas)
        {
            try
            {
                // TODO: Add insert logic here
                tareaServicio.Add(tareas);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tareas/Edit/5
        public ActionResult Edit(int id)
        {
            ViewData["CursoId"] = new SelectList(cursoServicio.GetCursos(), "Id", "Nombre");
            return View(tareaServicio.GetById(id));
        }

        // POST: Tareas/Edit/5
        [HttpPost]
        public ActionResult Edit(Tareas tareas)
        {
            try
            {
                // TODO: Add update logic here
                tareaServicio.Update(tareas);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tareas/Delete/5
        public ActionResult Delete(int id)
        {
            return View(tareaServicio.GetById(id));
        }

        // POST: Tareas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                tareaServicio.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
