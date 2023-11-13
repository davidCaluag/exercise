using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace exercise.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SongController : ControllerBase
    {
        
        [HttpGet]
        public async Task<IActionResult> GetAllSongs(){
            var result = 
        }
        
    }
}