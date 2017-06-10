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
    public class WagonController : Controller
    {
        private readonly PickService _pickService;
        
        public WagonController()
        {
            _pickService = new PickService();
        }

        [HttpGet("{wagonId}")]
        public IActionResult Get(string wagonId)
        {
            Wagon wagon = _pickService.GetWagonAsync(wagonId).Result;            
            return new ObjectResult(wagon);
        }
    }
}