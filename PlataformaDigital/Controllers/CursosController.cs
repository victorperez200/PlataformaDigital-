using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaDatos.Database;
using CapaNegocios.Acciones;

namespace PlataformaDigital.Controllers
{
    public class CursosController : Controller
    {
        CursoServicio cursoServicio = new CursoServicio();
        ProfesorServicio profesorServicio = new ProfesorServicio();

        // GET: Cursos
        public ActionResult Index()
        {
            return View(cursoServicio.GetCursos());
        }

        // GET: Cursos/Details/5
        public ActionResult Details(int id)
        {
            return View(cursoServicio.GetById(id));
        }

        // GET: Cursos/Create
        public ActionResult Create()
        {
            var profesores = profesorServicio.GetList();

            ViewData["ProfesorId"] = new SelectList(profesores, "Id", "Nombre");
            return View();
        }

        // POST: Cursos/Create
        [HttpPost]
        public ActionResult Create(Cursos cursos)
        {
            try
            {
                // TODO: Add insert logic here
                cursoServicio.Add(cursos);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cursos/Edit/5
        public ActionResult Edit(int id)
        {
            var profesores = profesorServicio.GetList();

            ViewData["ProfesorId"] = new SelectList(profesores, "Id", "Nombre");

            var curso = cursoServicio.GetById(id);

            return View(curso);
        }

        // POST: Cursos/Edit/5
        [HttpPost]
        public ActionResult Edit(Cursos cursos)
        {
            try
            {
                // TODO: Add update logic here
                cursoServicio.Update(cursos);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cursos/Delete/5
        public ActionResult Delete(int id)
        {
            return View(cursoServicio.GetById(id));
        }

        // POST: Cursos/Delete/5
        [HttpPost]
        public ActionResult Delete(Cursos curso)
        {
            try
            {
                // TODO: Add delete logic here

                var entity = cursoServicio.GetById(curso.Id);
                if (entity == null)
                {
                    return HttpNotFound();
                }
                cursoServicio.Delete(entity.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Cursos/CursosPorProfesor/5
        public ActionResult CursosPorProfesor(int profesorId)
        {
            var cursos = cursoServicio.GetCursos().Where(c => c.ProfesorId == profesorId).ToList();
            return View(cursos);
        }
    }
}
