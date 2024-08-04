using Alt_Amators.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alt_Amators
{
    public class AltVContext : DbContext
    {
        private readonly string _connectionString = string.Empty;

        public AltVContext()
        {
            _connectionString = "server=localhost; database=altv; user=altv; password=11111111";
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
        }
    }
}
