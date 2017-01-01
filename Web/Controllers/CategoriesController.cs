using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Data;
using Data.Infrastructure;
using Data.Models;
using Service;

namespace Web.Controllers
{
    public class CategoriesController : Controller
    { 
        private readonly ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        // GET: Categories
        public ActionResult Index()
        {
            var categories = categoryService.GetCategories().ToList();
            return View(categories);
        }
    }
}
