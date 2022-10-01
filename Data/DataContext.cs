using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNER_RPG.Models;
using Microsoft.EntityFrameworkCore;

namespace DOTNER_RPG.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Character> Characters {get; set;}
        
    }
}