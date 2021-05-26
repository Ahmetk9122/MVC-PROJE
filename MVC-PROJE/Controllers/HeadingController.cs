using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_PROJE.Controllers
{
    public class HeadingController : Controller
    {
        HeadingMenager hm = new HeadingMenager(new EfHeadingDal());
        // GET: Heading
        public ActionResult Index()
        {
            var headinvalues = hm.GetList();
            return View(headinvalues);
        }
        //public ActionResult  
    }
}