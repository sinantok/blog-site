using CoreBlogApp.Business;
using CoreBlogApp.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApp.WebUI.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent
    {
       
        private readonly ICategoryService _categoryService;

        public CategoryMenuViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(_categoryService.GetAll().OrderByDescending(x => x.CategoryId));
        }
    }
}
