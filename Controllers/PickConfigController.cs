using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scania.PickToLight.Models;
using Scania.PickToLight.Service;

namespace Scania.PickToLight.Controllers
{
    [Route("api/[controller]")]
    public class PickConfigController : Controller
    {
        private readonly PickService _pickService;
        
        public PickConfigController()
        {
            _pickService = new PickService();
        }

        [HttpGet("{identify}")]
        public IActionResult Get(string identify)
        {
            StationConfig config = _pickService.GetStationConfigAsync(identify).Result;            
            return new ObjectResult(config);
        }
    }
}