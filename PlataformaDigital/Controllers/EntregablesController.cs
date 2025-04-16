using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using CapaDatos.Database;
using CapaNegocios.Acciones;

namespace PlataformaDigital.Controllers
{
    public class EntregablesController : Controller
    {
        TareaServicio tareaServicio = new TareaServicio();
        EstudiantesServicio estudianteServicio = new EstudiantesServicio();
        EntregableServicio entregableServicio = new EntregableServicio();


        // GET: Entregables
        public ActionResult Index()
        {
            return View(entregableServicio.GetEntregables());
        }

        // GET: Entregables/Details/5
        public ActionResult Details(int id)
        {
            return View(entregableServicio.GetById(id));
        }

        // GET: Entregables/Create
        public ActionResult Create()
        {
            ViewBag.EstudianteId = new SelectList(estudianteServicio.GetEstudiantes(), "UsuarioId", "Matricula");
            ViewBag.TareaId = new SelectList(tareaServicio.GetTareas(), "Id", "Nombre");
            return View();
        }

        // POST: Entregables/Create
        [HttpPost]
        public ActionResult Create(Entregables entregables)
        {
            try
            {
                // TODO: Add insert logic here
                entregableServicio.Add(entregables);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Entregables/Edit/5
        public ActionResult Edit(int id)
        {
           ViewBag.EstudianteId = new SelectList(estudianteServicio.GetEstudiantes(), "UsuarioId", "Matricula");
           ViewBag.TareaId = new SelectList(tareaServicio.GetTareas(), "Id", "Nombre");
            return View();
        }

        // POST: Entregables/Edit/5
        public ActionResult Edit(Entregables entregables)
        {

            try
            {
                
                entregableServicio.Update(entregables);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Entregables/Delete/5
        public ActionResult Delete(int id)
        {
            return View(entregableServicio.GetById(id));
        }

        // POST: Entregables/Delete/5
        
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                entregableServicio.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
