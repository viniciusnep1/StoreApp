using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User user)
        {
            var users = _userService.Authenticate(user.Username, user.Password);
            return Ok("\"" + users.Token + "\"");
        }
        public IActionResult Create([FromBody]User user)
        {
            _userService.Create(user);
            return Ok();
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

    }
}