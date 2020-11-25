using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class TestAppContext : DbContext
    {



        public TestAppContext(DbContextOptions<TestAppContext> options)
           :base(options)
        {
            
        }


        public DbSet<Make> Makes { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
