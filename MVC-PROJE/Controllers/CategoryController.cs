﻿using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_PROJE.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            //var diyoruz çünkü tabloda alfabetik karakter sayı ve değişik karakterler işçerebilir oyüzden bunu kullanıyoruz.
            var categoryvalues = cm.GetAllBL();
            return View(categoryvalues);
        }
    }
}