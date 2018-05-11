using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolFunderAPI.Controllers
{
    [Route("/")]
    [ApiVersion("1.0")]
    public class RootController : Controller
    {
        // GET: /
        [HttpGet(Name = nameof(GetRoot))]
        public IActionResult GetRoot()
        {
            var response = new {
                href = Url.Link(nameof(GetRoot), null),
                projects = new { href = Url.Link(nameof(ProjectsController.GetProjects), null) }
            };
            return Ok(response);
        }
    }
}
