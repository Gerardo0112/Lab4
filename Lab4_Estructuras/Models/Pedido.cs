using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4_Estructuras.Models
{
    public class Pedido
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string nit { get; set; }
        public string producto { get; set; }
        public string total { get; set; }
    }
}