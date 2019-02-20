using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVirtualPets.Controllers
{
    public class HomeController : Controller
    {
       /*public string Index() => "Hello from MVC";*/
       public string Index()
        {
            return ("Hello from MVC");
        }
        public string FooBar()
        {
            return ("Hell from FooBar");
        }
        
    }
}
