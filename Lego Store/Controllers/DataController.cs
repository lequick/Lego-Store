using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegoRepo.Factories;

namespace Lego_Store.Controllers
{
    public class DataController : Controller
    {
        KategoriFac kf = new KategoriFac();

        [ChildActionOnly]




        public ActionResult Menu()
        {
            return PartialView(kf.GetAll());
        }
    }
}