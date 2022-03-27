using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SherbeenyLibrary;
using Math = SherbeenyLibrary.Math;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MainAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Math math = new Math();

        [HttpGet("/average")]
        public int Average([FromQuery] int[] nums)
        {
            return math.Average(nums);
        }

        [HttpGet("/smallest")]
        public int Smallest([FromQuery] int[] nums)
        {

            return math.Smallest(nums);
        }
        [HttpGet("/largest")]
        public int Largest([FromQuery] int[] nums)
        {
            return math.Largest(nums);
        }
    }
}
