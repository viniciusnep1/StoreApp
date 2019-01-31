using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPut]
        public IActionResult Edit(Category category)
        {
            _service.Update(category);
            return View("Index");
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categories = _service.GetAll();
            return View(categories);
        }

        [HttpPost]
        public IActionResult Save(Category category)
        {
            _service.Save(category);
            return RedirectToAction("Index");
        }
    }
}
