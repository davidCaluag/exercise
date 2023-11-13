using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.Model
{
    public class Song
    {
        public Guid SongId { get; set; }
        public string? SongName { get; set; }
        public Artist? Artist {get; set;}
    }
}