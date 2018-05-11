using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SchoolFunderAPI.Controllers
{
    [Route("/[controller]")]
    public class ProjectsController : Controller
    {
        // GET: /Projects/
        [HttpGet(Name = nameof(GetProjects))]
        public IActionResult GetProjects()
        {
            throw new NotImplementedException();
        }
    }
}
