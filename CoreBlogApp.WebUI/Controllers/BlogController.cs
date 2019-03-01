using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CoreBlogApp.Business;
using CoreBlogApp.Entity.DbEntities;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

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

        //admin
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

        //admin
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(categoryManager.GetAll().ToList(), "CategoryId", "Name");
            return View();
        }

        //admin
        [HttpPost]
        public async Task<IActionResult> Create(Blog model, IFormFile file)
        {
            ModelState.Remove("Date");
            ModelState.Remove("Image");
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", DateTime.Now.ToShortDateString() + file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    model.Image = DateTime.Now.ToShortDateString() + file.FileName;
                }

                model.Date = DateTime.Now;
                if(blogManager.Insert(model)==0)
                {
                    ModelState.AddModelError("", "Database Error!");
                    ViewBag.Categories = new SelectList(categoryManager.GetAll().ToList(), "CategoryId", "Name");
                    return View(model);
                }

                TempData["message"] = $"{model.Title} kayıt edildi.";
                return RedirectToAction("List", "Blog");
            }

            ViewBag.Categories = new SelectList(categoryManager.GetAll().ToList(), "CategoryId", "Name");
            return View();
        }

        //admin
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            else
            {
                ViewBag.Categories = new SelectList(categoryManager.GetAll().ToList(), "CategoryId", "Name");
                return View(blogManager.GetById(x => x.BlogId == id.Value));
            }
        }

        //admin
        [HttpPost]
        public async Task<IActionResult> Edit(Blog model, IFormFile file)
        {
            ModelState.Remove("Date");
            ModelState.Remove("Image");
            if (ModelState.IsValid)
            {
                Blog blog = blogManager.GetById(x => x.BlogId == model.BlogId);
                if (blog != null)
                {
                    if (file != null)
                    {
                        var lastPast = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", model.Image);
                        ; if (System.IO.File.Exists(lastPast))
                        {
                            System.IO.File.Delete(lastPast);
                        }

                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", DateTime.Now.ToShortDateString() + file.FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                        model.Image = DateTime.Now.ToShortDateString() + file.FileName;
                    }

                    blog.Body = model.Body;
                    blog.Title = model.Title;
                    blog.Description = model.Description;
                    blog.Image = model.Image;
                    blog.IsApproved = model.IsApproved;
                    blog.IsHome = model.IsHome;
                    blog.IsSlider = model.IsSlider;
                    if (blogManager.Update(blog) == 0)
                    {
                        ModelState.AddModelError("", "Database Error!");
                        ViewBag.Categories = new SelectList(categoryManager.GetAll().ToList(), "CategoryId", "Name");
                        return View(model);
                    }
                    TempData["message"] = $"{model.Title} güncellendi.";
                    return RedirectToAction("List", "Blog");
                }
                else
                {
                    ModelState.AddModelError("", "Blog Not Found!");
                    ViewBag.Categories = new SelectList(categoryManager.GetAll().ToList(), "CategoryId", "Name");
                    return View(model);
                }
            }

            ViewBag.Categories = new SelectList(categoryManager.GetAll().ToList(), "CategoryId", "Name");
            return View();
        }

        //admin
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            Blog blog = blogManager.GetById(x => x.BlogId == id.Value);
            if (blog != null)
            {
                var lastPast = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", blog.Image);
                ; if (System.IO.File.Exists(lastPast))
                {
                    System.IO.File.Delete(lastPast);
                }

                blogManager.Delete(blog);
            }

            return RedirectToAction("List", "Blog");
        }
    }
}