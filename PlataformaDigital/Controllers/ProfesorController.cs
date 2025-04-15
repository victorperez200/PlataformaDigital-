using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaDatos.Database;
using CapaNegocios.Acciones;

namespace PlataformaDigital.Controllers
{
    public class ProfesorController : Controller
    {
        ProfesorServicio profesorServicio = new ProfesorServicio();

        // GET: Profesor
        public ActionResult Index()
        {
            var profesores = profesorServicio.GetList();
            return View(profesores);
        }

        // GET: Profesor/Details/5
        public ActionResult Details(int id)
        {
            var profesor = profesorServicio.GetList().FirstOrDefault(p => p.Id == id);
            if (profesor == null)
            {
                return HttpNotFound();
            }
            return View(profesor);
        }
    }
}
