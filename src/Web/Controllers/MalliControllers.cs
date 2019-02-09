
using System;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class MalliController : Controller
    {
        public IActionResult Text()
        {
            return Content("It returns the text. ");
        }
    
        public IActionResult JSON()
        {
            return  Json(new {name="Mallikarjuna", quote="it returns Json file"});
        }
    
        public IActionResult HTML()
        {
            var h = "<!DOCTYPE html><html><body>Failures are the stepping stone to success." + 
            "<br><br> <a href='/Quote'>Go Back to Quotes</a></body></html>";
            return Content(h, "text/html");
        }

        public IActionResult View()
        {
            
            return View();
        }
    }
}









    

    