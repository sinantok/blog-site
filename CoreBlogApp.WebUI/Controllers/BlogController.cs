using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBlogApp.Business;
using CoreBlogApp.Entity.DbEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CoreBlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private BlogManager blogManager = new BlogManager();
        private CategoryManager categoryManager = new CategoryManager();

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


        public IActionResult List()
        {
            //yönetim ekranı benzerinde bütün blogs listelensin

            return View(blogManager.GetAll().OrderByDescending(x => x.Date).ToList());
        }

        public IActionResult Details(int? id)
        {
            if(id==null)
            {
                return new BadRequestResult();
            }

            return View(blogManager.GetById(x => x.BlogId == id.Value));
        }

        [HttpGet]
        public IActionResult AddorUpdate(int? id)
        {
            ViewBag.Categories = new SelectList(categoryManager.GetAll().ToList(), "CategoryId", "Name");
            if (id == null)
            {
                //create
                return View();
            }
            else
            {
                return View(blogManager.GetById(x => x.BlogId == id.Value));
                //update
            }
        }

        [HttpPost]
        public IActionResult AddorUpdate(Blog model)
        {
            ModelState.Remove("Date");
            ModelState.Remove("BlogId");
            if(ModelState.IsValid)
            {
                if(model.BlogId == 0)
                {
                    model.Date = DateTime.Now;
                    blogManager.Insert(model);
                }
                else
                {
                    Blog blog = blogManager.GetById(x => x.BlogId == model.BlogId);
                    if (blog != null)
                    {
                        blog.Body = model.Body;
                        blog.Title = model.Title;
                        blog.Description = model.Description;
                        blog.Image = model.Image;
                        blog.IsApproved = model.IsApproved;
                        blog.IsHome = model.IsHome;
                        if (blogManager.Update(blog) == 0)
                        {
                            ModelState.AddModelError("", "Database Error");
                            ViewBag.Categories = new SelectList(categoryManager.GetAll().ToList(), "CategoryId", "Name");
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "DataBaseError!");
                        ViewBag.Categories = new SelectList(categoryManager.GetAll().ToList(), "CategoryId", "Name");
                        return View(model);
                    }
                 
                }
                TempData["message"] = $"{model.Title} kayıt edildi.";
                return RedirectToAction("List","Blog");
            }

            ViewBag.Categories = new SelectList(categoryManager.GetAll().ToList(), "CategoryId", "Name");
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            Blog blog = blogManager.GetById(x => x.BlogId == id.Value);
            if (blog != null)
            {
                blogManager.Delete(blog);
            }

            return RedirectToAction("List", "Blog");
        }
    }
}