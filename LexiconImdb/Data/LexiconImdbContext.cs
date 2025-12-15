using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LexiconImdb.Models.Entities;

namespace LexiconImdb.Data
{
    public class LexiconImdbContext : DbContext
    {
        public LexiconImdbContext (DbContextOptions<LexiconImdbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } = default!;
    }
}
