using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CoreBlogApp.Business;
using CoreBlogApp.Entity.DbEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreBlogApp.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager categoryManager = new CategoryManager();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            //yönetim ekranı benzerinde bütün categories listelensin

            return View(categoryManager.GetAll().ToList());
        }

        [HttpGet]
        public IActionResult AddorUpdate(int? id)
        {
            if(id == null)
            {
                //create
                return View();
            }
            else
            {
                return View(categoryManager.GetById(x => x.CategoryId == id.Value));
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
                    categoryManager.Insert(model);
                }
                else
                {
                    Category category = categoryManager.GetById(x => x.CategoryId == model.CategoryId);
                    if (category != null)
                    {
                        category.Name = model.Name;
                        if (categoryManager.Update(category) == 0)
                        {
                            ModelState.AddModelError("", "Database Error");
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
                return RedirectToAction("List", "Category");
            }

            return View();
        }


        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new BadRequestResult();
            }
            Category category = categoryManager.GetById(x => x.CategoryId == id.Value);
            if (category != null)
            {
                categoryManager.Delete(category);
            }

            return RedirectToAction("List", "Category");
        }
    }
}