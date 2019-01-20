using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5StarterProject.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "這是我的<b>預設<b>動作";
        }

        public string welcome()
        {
            return "這是歡迎的action";
        }
    }
}