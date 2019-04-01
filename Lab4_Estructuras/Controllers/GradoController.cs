using Lab4_Estructuras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4_Estructuras.Controllers
{
    public class GradoController : Controller
    {
        // GET: Grado
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarGrado()
        {
            Grado g1 = new Grado() { grado = 5 };
            return View(g1);
        }
        public ActionResult CrearGrado()
        {
            return View();

        }
        [HttpPost]
        public ActionResult GuardarInfoGrado(int grado)
        {
            Grado nGrado = new Grado();
            try
            {
                nGrado.grado = grado - 1;
                return RedirectToAction("/GradoGuardado", nGrado);
            }
            catch (Exception)
            {
                return View("/MostrarGrado");
            }


        }
        public ActionResult GradoGuardado(Grado guardado)
        {
            return View(guardado);

        }
        public ActionResult RegresarNuevaVista()
        {
            Grado nGrado = new Grado();
            try
            {
                return RedirectToAction("/GradoGuardado", nGrado);
            }
            catch
            {
                return View("/Inicial");
            }
        }
    }
}