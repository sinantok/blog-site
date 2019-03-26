using System;
using System.Collections.Generic;
using CoreBlogApp.Business.Abstract;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreBlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {

        private IBlogService _blogService;
        //DependecyInjection
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        //publicUI
        public IActionResult Index(int? id, string q)
        {
            if (id != null)
            {
                //seçilen kategorideki bloglar listelensin
                return View(_blogService.GetBlogByCategory(id.Value));

            }
            //searchbox'dan gelen aramaya göre listele
            if (!string.IsNullOrEmpty(q))
            {
                //return View(blogManager.GetAll().Where(x => x.Title.Contains(q) || x.Description.Contains(q) || x.Body.Contains(q)).OrderByDescending(x => x.Date));
                return View(_blogService.GetBlogBySearcBox(q));

            }
            //blogIndex'te bütün onaylı bloglar listelensin
            return View(_blogService.GetAllIsApproved());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            return View(_blogService.GetById(id.Value));
        }

    }
}