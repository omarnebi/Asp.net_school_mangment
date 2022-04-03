using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallCenterV1.Controllers
{
    public class DashboardController : Controller
    {
        // GET: DashboardController
        public ActionResult Index()
        {
            return View();
        }

       
    }
}
