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
    public class FinishWagonController : Controller
    {
        private readonly PickService _pickService;        
        public FinishWagonController()
        {
            _pickService = new PickService();
        }

        [HttpPost]
        public async Task<IActionResult> Post(Log log)
        {            
            Log result = await _pickService.FinishWagonAsync(log);            
            return new ObjectResult(result);
        }
    }
}