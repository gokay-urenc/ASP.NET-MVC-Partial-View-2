using MVC_21_Partial_Views.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_21_Partial_Views.Controllers
{
    public class DefaultController : Controller
    {
        List<Urun> urunler = new List<Urun>
        {
            new Urun{id=1, ad="Bat", fiyat=30, resimYolu="https://images-na.ssl-images-amazon.com/images/I/71iUAQfsOXL._SX466_.jpg" },
            new Urun{id=1, ad="Axe", fiyat=20, resimYolu="https://vignette.wikia.nocookie.net/silent/images/e/ef/Hatchet.png/revision/latest?cb=20171008180723" },
            new Urun{id=1, ad="Katana", fiyat=50, resimYolu="https://mcishop.azureedge.net/mciassets/w_5_0042040_the-michonne-katana_550.png" }
        };
        public ActionResult Index()
        {
            return View(urunler);
        }

        public ActionResult Sayfa()
        {
            return View();
        }
    }
}