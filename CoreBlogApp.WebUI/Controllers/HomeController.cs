using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBlogApp.Business;
using CoreBlogApp.Business.Abstract;
using CoreBlogApp.Entity.DbEntities;
using CoreBlogApp.Entity.ResultModel;
using CoreBlogApp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryService _categoryService;
        private IBlogService _blogService;
        //DI
        public HomeController(ICategoryService categoryService, IBlogService blogService)
        {
            _categoryService = categoryService;
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            //Onaylı ve anasayfa onayı olanlar gidecek.

            IndexBlogModel models = new IndexBlogModel();

            models.IndexBlogs = _blogService.GetAllHomePage();
            models.SliderBlogs = _blogService.GetAllSlider();

            return View(models);
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}