using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ThreeAmigos.Controllers
{
    public class RegisterController : Controller
    {


        // GET: /Register

         

        public IActionResult Index()
        {
            return View();
        }




        // GET /register/Welcome

        public string Welcome()
        {
            return "testing 1 2 3";
        }
    }
}
