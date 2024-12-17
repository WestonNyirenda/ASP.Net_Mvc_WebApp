using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
         public IActionResult Index()
         {  
             return View();
         }


        //GET: HelloWorld/ 
        /*public string index()
        {
            return "This is my default action";
        }*/

        //GET: HelloWorld/welcome
         public IActionResult Welcome(string name, int numTimes = 3)
         {
            ViewData["message"] = "Hello " + name;
            ViewData["numTimes"] = numTimes;

            return View();

            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

        }
    }
}
