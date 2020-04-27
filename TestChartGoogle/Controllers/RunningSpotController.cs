using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestChartGoogle.Controllers
{
    [Route("runningspot")]
    public class RunningSpotController : Controller
    {
        [Route("")]
        [Route("index")]
        [Route("~/")]

        public IActionResult Index()
        {
            return View();
        }
    }
}