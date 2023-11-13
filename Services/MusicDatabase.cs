using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercise.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace exercise.Services
{
    public class MusicDatabase
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        
        public Database database;

    }
}