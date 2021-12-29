using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class NextStoreContext : DbContext
    {
        public NextStoreContext(DbContextOptions options) : base(options)
        {            
        }

        public DbSet<Product> Products{get; set;}
    }
}