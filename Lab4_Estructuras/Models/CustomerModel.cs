using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4_Estructuras.Models
{
    public class CustomerModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string casaproductora { get; set; }
        public string precio { get; set; }
        public int existencia { get; set; }
    }
}