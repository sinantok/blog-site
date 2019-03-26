using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CoreBlogApp.Business;
using CoreBlogApp.Business.Abstract;
using CoreBlogApp.Entity.DbEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreBlogApp.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private IBlogService _blogService;
        private ICategoryService _categoryService;

        public BlogController(IBlogService blogService,ICategoryService categoryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View(_blogService.GetAll().OrderByDescending(x => x.Date));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_categoryService.GetAll(), "CategoryId", "Name");
            return View();
        }

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
                if (_blogService.Insert(model) == 0)
                {
                    ModelState.AddModelError("", "Database Error!");
                    ViewBag.Categories = new SelectList(_categoryService.GetAll(), "CategoryId", "Name");
                    return View(model);
                }

                TempData["message"] = $"{model.Title} kayıt edildi.";
                return RedirectToAction("Index", "Blog", new { area = "Admin" });
            }

            ViewBag.Categories = new SelectList(_categoryService.GetAll(), "CategoryId", "Name");
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            else
            {
                ViewBag.Categories = new SelectList(_categoryService.GetAll(), "CategoryId", "Name");
                return View(_blogService.GetById(id.Value));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Blog model, IFormFile file)
        {
            ModelState.Remove("Date");
            ModelState.Remove("Image");
            if (ModelState.IsValid)
            {
                Blog blog = _blogService.GetById(model.BlogId);
                if (blog != null)
                {
                    if (file != null)
                    {
                        var lastPast = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", model.Image);
                        if (System.IO.File.Exists(lastPast))
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
                    blog.CategoryId = model.CategoryId;
                    if (_blogService.Update(blog) == 0)
                    {
                        ModelState.AddModelError("", "Database Error!");
                        ViewBag.Categories = new SelectList(_categoryService.GetAll(), "CategoryId", "Name");
                        return View(model);
                    }
                    TempData["message"] = $"{model.Title} güncellendi.";
                    return RedirectToAction("Index", "Blog", new { area = "Admin" });
                }
                else
                {
                    ModelState.AddModelError("", "Blog Not Found!");
                    ViewBag.Categories = new SelectList(_categoryService.GetAll(), "CategoryId", "Name");
                    return View(model);
                }
            }

            ViewBag.Categories = new SelectList(_categoryService.GetAll(), "CategoryId", "Name");
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            Blog blog = _blogService.GetById(id.Value);
            if (blog != null)
            {
                var lastPast = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", blog.Image);
                ; if (System.IO.File.Exists(lastPast))
                {
                    System.IO.File.Delete(lastPast);
                }

                _blogService.Delete(blog);
            }
            TempData["message"] = $"{blog.Title} silindi.";
            return RedirectToAction("Index", "Blog", new { area = "Admin" });
        }
    }
}