using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4_Estructuras.Controllers
{
    public class SolicitudController : Controller
    {
        private const string V = " ";

        // GET: Solicitud
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CrearArbol()
        {
            Guid g;
            g = Guid.NewGuid();
            Console.WriteLine(g);
            Console.WriteLine(Guid.NewGuid());
            return View();
        }

        //mostrar la solicitud!!
        /*public ActionResult MostrarSolicitud
        {
            get
            {
                TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
                Solicitud sol = new Solicitud() { Nombre = " ", Direccion = " ", ListFarmacos = " ", Nit = " " };
                TimeSpan stop = new TimeSpan(DateTime.Now.Ticks);
            }
        }*/

        // GET: Solicitud/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Solicitud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Solicitud/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Solicitud/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Solicitud/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Solicitud/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Solicitud/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}