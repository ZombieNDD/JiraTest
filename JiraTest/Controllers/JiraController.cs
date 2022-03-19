using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JiraTest.Controllers
{
    public class JiraController : Controller
    {
        // GET: Jira
        public ActionResult Index()
        {
            return View();
        }
    }
}