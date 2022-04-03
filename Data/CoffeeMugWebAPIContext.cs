#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoffeeMug.Models;

namespace CoffeeMugWebAPI.Data
{
    public class CoffeeMugWebAPIContext : DbContext
    {
        public CoffeeMugWebAPIContext (DbContextOptions<CoffeeMugWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CoffeeMug.Models.Product> Product { get; set; }
    }
}
