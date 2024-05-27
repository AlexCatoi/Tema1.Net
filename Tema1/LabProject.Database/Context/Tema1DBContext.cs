using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Tema1.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Tema1.Database.Context
{
    public class Tema1DBContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                    .UseSqlServer("Server=localhost;Database=Tema1;Integrated Security=SSPI;TrustServerCertificate=True").LogTo(Console.WriteLine);
        }
    }
}

