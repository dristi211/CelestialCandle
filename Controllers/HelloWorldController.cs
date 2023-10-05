using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace CelestialCandle.Controllers
{
    public class HelloWorldController : Controller
    {
        /* public IActionResult Index()  //toggle block these code for future ref
         {
             return View();
         }*/

        // 
        // GET: /HelloWorld/

        public string Index()   //Index () method 
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        /*public string Welcome()  //First Welcome method
        {
            return "This is the Welcome action method...";
        }*/

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1) //This is second update of the Welcome() where HtmlEncoder added for security, to protect the app from malicious input,
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
