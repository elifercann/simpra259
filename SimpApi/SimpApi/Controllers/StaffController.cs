﻿using Microsoft.AspNetCore.Mvc;
using SimpApi.Models;

namespace SimpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        public StaffController()
        {
            
        }
        [HttpPost]
        public Staff Post([FromBody] Staff staff)
        {
            return staff;
        }
    }
}
