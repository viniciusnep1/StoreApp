using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Dtos;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [Route("api/[controller]")]
        [HttpPut]
        public IActionResult Edit(Category category)
        {
            _service.Update(category);
            return Ok();
        }

        [Route("api/[controller]")]
        [HttpGet]
        public CategoryViewModel Get()
        {
            var categories = _service.GetAll();
            return categories;
        }

        [Route("api/[controller]")]
        [HttpPost]
        public IActionResult Save(Category category)
        {
            _service.Save(category);
            return Ok();
        }
    }
}
