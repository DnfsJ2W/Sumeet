using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codefirstrazor.Models
{
    public class newdbContext:DbContext
    {

        public newdbContext(DbContextOptions<newdbContext>Options):base(Options)
        { 
        }
        public DbSet<Book> Books { get; set; }
    }
}
