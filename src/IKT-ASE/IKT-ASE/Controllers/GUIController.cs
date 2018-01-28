using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IKTASE.Controllers
{
    public class GUIController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
