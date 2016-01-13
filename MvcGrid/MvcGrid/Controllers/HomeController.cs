using MvcGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcGrid.Controllers
{
    
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var clients = new System.Collections.Generic.List<Client>
            {
                new Client { Id = 1, Name = "Julio Avellaneda", Email = "julito_gtu@hotmail.com" },
                new Client { Id = 2, Name = "Juan Torres", Email = "jtorres@hotmail.com" },
                new Client { Id = 3, Name = "Oscar Camacho", Email = "oscar@hotmail.com" },
                new Client { Id = 4, Name = "Gina Urrego", Email = "ginna@hotmail.com" },
                new Client { Id = 5, Name = "Nathalia Ramirez", Email = "natha@hotmail.com" },
                new Client { Id = 6, Name = "Raul Rodriguez", Email = "rodriguez.raul@hotmail.com" },
                new Client { Id = 7, Name = "Johana Espitia", Email = "johana_espitia@hotmail.com" },
                new Client { Id = 11, Name = "Julio Avellaneda", Email = "julito_gtu@hotmail.com" },
                new Client { Id = 22, Name = "Juan Torres", Email = "jtorres@hotmail.com" },
                new Client { Id = 33, Name = "Oscar Camacho", Email = "oscar@hotmail.com" },
                new Client { Id = 42, Name = "Gina Urrego", Email = "ginna@hotmail.com" },
                new Client { Id = 50, Name = "Nathalia Ramirez", Email = "natha@hotmail.com" },
                new Client { Id = 62121, Name = "Raul Rodriguez", Email = "rodriguez.raul@hotmail.com" },
                new Client { Id = 721, Name = "Johana Espitia", Email = "johana_espitia@hotmail.com" },
                new Client { Id = 121, Name = "Julio Avellaneda", Email = "julito_gtu@hotmail.com" },
                new Client { Id = 221, Name = "Juan Torres", Email = "jtorres@hotmail.com" },
                new Client { Id = 321, Name = "Oscar Camacho", Email = "oscar@hotmail.com" },
                new Client { Id = 421, Name = "Gina Urrego", Email = "ginna@hotmail.com" },
                new Client { Id = 521, Name = "Nathalia Ramirez", Email = "natha@hotmail.com" },
                new Client { Id = 621, Name = "Raul Rodriguez", Email = "rodriguez.raul@hotmail.com" },
                new Client { Id = 72, Name = "Johana Espitia", Email = "johana_espitia@hotmail.com" }
            };
            return View(clients);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}