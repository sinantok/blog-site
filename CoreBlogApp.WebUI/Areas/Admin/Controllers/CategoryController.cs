using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBlogApp.Business;
using CoreBlogApp.Business.Abstract;
using CoreBlogApp.Entity.DbEntities;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogApp.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View(_categoryService.GetAll());
        }

        [HttpGet]
        public IActionResult AddorUpdate(int? id)
        {
            if (id == null)
            {
                //create
                return View();
            }
            else
            {
                return View(_categoryService.GetById(id.Value));
            }
        }

        [HttpPost]
        public IActionResult AddorUpdate(Category model)
        {
            ModelState.Remove("CategoryId");
            if (ModelState.IsValid)
            {
                if (model.CategoryId == 0)
                {
                    _categoryService.Insert(model);
                }
                else
                {
                    Category category = _categoryService.GetById(model.CategoryId);
                    if (category != null)
                    {
                        category.Name = model.Name;
                        if (_categoryService.Update(category) == 0)
                        {
                            ModelState.AddModelError("", "Error");
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "DataBaseError!");
                        return View(model);
                    }

                }
                TempData["message"] = $"{model.Name} kayıt edildi.";
                return RedirectToAction("Index", "Category", new { area = "Admin" });
            }

            return View();
        }
        
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            Category category = _categoryService.GetById(id.Value);
            if (category != null)
            {
                _categoryService.Delete(category);
            }

            TempData["message"] = $"{category.Name} silindi.";
            return RedirectToAction("Index", "Category", new { area = "Admin" });
        }
    }
}