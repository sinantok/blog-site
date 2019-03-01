using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBlogApp.Business;
using CoreBlogApp.DataAccess.Concrete.EFCore;
using CoreBlogApp.Entity.DbEntities;
using CoreBlogApp.Entity.ResultModel;
using CoreBlogApp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogManager blogManager = new BlogManager();
        public IActionResult Index()
        {
            //Onaylı ve anasayfa onayı olanlar gidecek.

            //MessageResult<Blog> messageResult = blogManager.Listele(1);
            //Blog blog = messageResult.Result;

            IndexBlogModel models = new IndexBlogModel();
            models.IndexBlogs = blogManager.GetAll().Where(i => i.IsApproved && i.IsHome).OrderByDescending(x => x.Date).ToList();
            models.SliderBlogs = blogManager.GetAll().Where(i => i.IsApproved && i.IsSlider).OrderByDescending(x => x.Date).ToList();

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