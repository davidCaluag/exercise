using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercise.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace exercise.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SongController : ControllerBase
    {
        private MusicDatabase database = new MusicDatabase();
        [HttpGet]
        public async Task<IActionResult> GetAllSongs(){
            var result = database.Songs.Include(x=>x.SongId).ToListAsync();
            return Ok(result);
        }
        
        [HttpGet("/{Id}")]
        public async Task<IActionResult> GetAllSongs(Guid Id){
            var result = database.Songs.Include(x=>x.SongId).SingleOrDefaultAsync(x=>x.SongId == Id);
            return Ok(result);
        }
    }
}