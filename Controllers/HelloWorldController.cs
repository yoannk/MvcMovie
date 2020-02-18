using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld/ 
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // GET: HelloWorld/Welcome/Scott/1
        public string Welcome(int id = 1, string name = "toto")
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + id);
        }
    }
}