using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SubArea.ASPNetCoreMVC.Areas.Department.Controllers
{
	[Area("Department")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}