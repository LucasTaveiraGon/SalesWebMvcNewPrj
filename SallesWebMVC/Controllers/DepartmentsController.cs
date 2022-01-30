using Microsoft.AspNetCore.Mvc;
using SallesWebMVC.Models;
using System.Collections.Generic;

namespace SallesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department);
            return View();
        }
    }
}
