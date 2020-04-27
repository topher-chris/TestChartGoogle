using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestChartGoogle.Models;

namespace TestChartGoogle.Controllers
{
    [Route("api/runningspot")]
    [ApiController]
    public class RunningSpotRestController : Controller
    {
        private DataContext db = new DataContext();

        [HttpGet("findall")]
        [Produces("application/json")]

    //    public string findall()
    //    {
    //        return "youarehere";
    //    }

        public async Task<IActionResult> findall()
        {
            try
            {
                var runningspots =  db.RunningSpots.ToList();
                return Ok(runningspots);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}