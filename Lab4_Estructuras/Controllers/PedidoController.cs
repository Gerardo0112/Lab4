using Lab4_Estructuras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4_Estructuras.Controllers
{
    public class PedidoController : Controller
    {
        // GET: Pedido
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarPedido()
        {
            Pedido p1 = new Pedido() { nombre = "Gerardo" , direccion = "Mixco", nit = "842701-1", total = "$.540.21" };
            return View(p1);
        }
        public ActionResult CrearPedido()
        {
            return View();

        }
        [HttpPost]
        public ActionResult GuardarInfoPedido(string nombre, string direccion, string nit, string producto, string total)
        {
            Pedido nPedido = new Pedido();
            try
            {
                nPedido.nombre = nombre;
                nPedido.direccion = direccion;
                nPedido.nit = nit;
                nPedido.producto = producto;
                nPedido.total = total;
                return RedirectToAction("/PedidoGuardado", nPedido);
            }
            catch (Exception)
            {
                return View("/MostrarGrado");
            }


        }
        public ActionResult PedidoGuardado(Pedido guardado)
        {
            return View(guardado);

        }
        public ActionResult RegresarNuevaVista()
        {
            Pedido nPedido = new Pedido();
            try
            {
                return RedirectToAction("/PedidoGuardado", nPedido);
            }
            catch
            {
                return View("/Inicial");
            }
        }
    }
}