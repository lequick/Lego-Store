using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegoRepo;
using LegoRepo.Factories;

namespace Lego_Store.Controllers
{
    public class ProduktController : Controller
    {
        // GET: Produkt
        ProduktFac pf = new ProduktFac();
        KategoriFac kf = new KategoriFac();
        public ActionResult ProduktListe(int id)
        {

            ProduktListVM plvm = new ProduktListVM();
            plvm.Produkter = pf.GetBy("KategoriID", id);
            plvm.KategoriNavn = kf.Get(id).Navn;

            return View(plvm);

       
        }

        public ActionResult ProduktKort(int id)
        {
            return View(pf.Get(id));
        }
    }
}