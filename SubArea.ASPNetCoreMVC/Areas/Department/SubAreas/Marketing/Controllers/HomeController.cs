using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SubArea.ASPNetCoreMVC.Areas.Department.SubAreas.Marketing.Controllers
{

	[Area("Department")]
	[SubArea("Marketing")]
	public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}