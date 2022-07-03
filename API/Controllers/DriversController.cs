using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class DriversController : Controller
    {
        private readonly IDiversService _diversService;

        public DriversController(IDiversService diversService)
        {
            _diversService = diversService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
