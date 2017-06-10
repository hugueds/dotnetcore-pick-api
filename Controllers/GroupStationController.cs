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
    public class GroupStationController : Controller
    {
        private readonly PickService _pickService;        
        public GroupStationController()
        {
            _pickService = new PickService();
        }

        [HttpGet("{groupId}")]
        public IActionResult Get(string groupId)
        {
            GroupStation groupStation = _pickService.GetGroupStationAsync(groupId).Result;            
            return new ObjectResult(groupStation);
        }
    }
}