using Lab4_Estructuras.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4_Estructuras.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new List<CustomerModel>());
        }
        public ActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase postedFile)
        {
            List<CustomerModel> customers = new List<CustomerModel>();
            string filePath = string.Empty;
            if (postedFile != null)
            {
                string path = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                filePath = path + Path.GetFileName(postedFile.FileName);
                string extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(filePath);

                string csvData = System.IO.File.ReadAllText(filePath);
                foreach (string row in csvData.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                        customers.Add(new CustomerModel
                        {
                            id = Convert.ToInt32(row.Split(',')[0]),
                            nombre = row.Split(',')[1],
                            descripcion = row.Split(',')[2],
                            casaproductora = row.Split(',')[3],
                            precio = row.Split(',')[4],
                            existencia = Convert.ToInt32(row.Split(',')[5])

                        });
                    }
                }
            }
            return View(customers);
        }
    }
}