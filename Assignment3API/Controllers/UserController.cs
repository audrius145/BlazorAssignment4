﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3API.Data;
using Assignment3API.Model;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserRepo _userRepo;
        
        public UserController(IUserRepo userRepo)
        {
            this._userRepo = userRepo;
        }

        [HttpGet]
        public async Task<ActionResult<User>> ValidateUser([FromQuery] string username, [FromQuery] string password)
        {
            
            try
            {
                var user = await _userRepo.ValidateUser(username, password);
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
    }
}
