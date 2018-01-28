using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IKTASE.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Books()
        {
            return View();
        }

        public ViewResult LecturePlan()
        {
            return View();
        }

        public ViewResult Schedule()
        {
            return View();
        }
    }
}
