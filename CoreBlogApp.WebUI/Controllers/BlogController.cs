using System;
using System.Collections.Generic;
using System.Linq;
using CoreBlogApp.Business;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace CoreBlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private BlogManager blogManager = new BlogManager();

        //publicUI
        public IActionResult Index(int? id, string q)
        {
            if (id != null)
            {
                //seçilen kategorideki bloglar listelensin
                return View(blogManager.GetAll().Where(x => x.IsApproved && x.CategoryId == id.Value).OrderByDescending(x => x.Date));

            }
            //searchbox'dan gelen aramaya göre listele
            if (!string.IsNullOrEmpty(q))
            {
                //return View(blogManager.GetAll().Where(x => x.Title.Contains(q) || x.Description.Contains(q) || x.Body.Contains(q)).OrderByDescending(x => x.Date));
                return View(blogManager.GetAll().Where(x => EF.Functions.Like(x.Title, "%" + q + "%") || EF.Functions.Like(x.Description, "%" + q + "%") || EF.Functions.Like(x.Body, "%" + q + "%")).Where(x => x.IsApproved).OrderByDescending(x => x.Date));

            }
            //blogIndex'te bütün onaylı bloglar listelensin
            return View(blogManager.GetAll().Where(x => x.IsApproved).OrderByDescending(x => x.Date));
        }

        public IActionResult Details(int? id)
        {
            if(id==null)
            {
                return new BadRequestResult();
            }

            return View(blogManager.GetById(x => x.BlogId == id.Value));
        }

    }
}