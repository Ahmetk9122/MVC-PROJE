using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_PROJE.Controllers
{
    public class WriterPanelController : Controller
    {
        HeadingMenager hm = new HeadingMenager(new EfHeadingDal());
        // GET: WriterPanel
        public ActionResult WriterProfile()
        {

            return View();
        }
        public ActionResult MyHeading ()
        {
          //  id = 4;
            var values = hm.GetListByWriter();
            return View(values);

        }
    }
}