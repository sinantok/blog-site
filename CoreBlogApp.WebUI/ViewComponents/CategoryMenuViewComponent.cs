using CoreBlogApp.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApp.WebUI.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager();
        BlogManager blogManager = new BlogManager();
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(categoryManager.GetAll());
        }
    }
}
