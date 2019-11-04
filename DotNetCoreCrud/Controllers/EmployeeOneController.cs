using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreCrud.Controllers
{
    public class EmployeeOneController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}