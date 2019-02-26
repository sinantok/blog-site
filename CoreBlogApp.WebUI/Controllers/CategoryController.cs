using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBlogApp.Business;
using CoreBlogApp.Entity.DbEntities;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogApp.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager categoryManager = new CategoryManager();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(categoryManager.GetAll().ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                categoryManager.Insert(model);
                return RedirectToAction("List");
            }
            return View(model);
        }
    }
}