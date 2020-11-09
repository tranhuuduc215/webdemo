using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;
        public HomeController()
        {
            employeeRepository = new EmployeeRipository();
        }

        public ViewResult Index()
        {
            //viewdata
            ViewData["employee"] = employeeRepository.Gets();
            return View();
        }
    }
}
