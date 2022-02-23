using BusAppBackend.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Controllers
{
    [ApiController]
    [Route("api/testdatabese")]
    public class DbTestingController : ControllerBase
    {
        private readonly BbaContext _bbaContext;
        public DbTestingController(BbaContext bbaContext) 
        {
            _bbaContext = bbaContext ?? throw new ArgumentNullException(nameof(bbaContext));
        }
        [HttpGet]
        public IActionResult testDatabase ()
        {
            return Ok("i am here !!");
        }
        
    }
}
