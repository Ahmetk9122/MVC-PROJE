using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
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
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        // GET: Heading
        //Valuemember benim seçmiş olduğum değerin iid si 
        //Displaymember ise seçmiş olduğun değerin görünümü
        // Kategori id valuemember id ye denk gelen kategori adı ise displaymember
        //text ==> display mumber
        //Value ==> value member
        public ActionResult Index()
        {
            var headinvalues = hm.GetList();
            return View(headinvalues);
        }
        [HttpGet]
        public ActionResult  AddHeading()
        {
            //Dropdown olayının backend kısmı 
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vlc = valueCategory;

            List<SelectListItem> valueWriter = (from x in wm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.WriterName +" " +x.WriterSurName,
                                                      Value = x.WriterID.ToString()
                                                  }).ToList();
            ViewBag.vlw = valueWriter;

            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
    }
}