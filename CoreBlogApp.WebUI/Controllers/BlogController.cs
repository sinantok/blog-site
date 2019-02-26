using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBlogApp.Business;
using CoreBlogApp.Entity.DbEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreBlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private BlogManager blogManager = new BlogManager();
        private CategoryManager categoryManager = new CategoryManager();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(blogManager.GetAll().OrderByDescending(x => x.Date).ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(categoryManager.GetAll().ToList(), "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog model)
        {
            ModelState.Remove("Date");

            model.Date = DateTime.Now;
            if(ModelState.IsValid)
            {
                blogManager.Insert(model);
                return RedirectToAction("List");
            }
            return View(model);
        }

    }
}