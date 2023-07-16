using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hometask07._14.model;
using Microsoft.EntityFrameworkCore;

using System.Reflection;

namespace hometask07._14.data
{
    public class UserDB : DbContext
    {
        private readonly string connectionString = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=ing0077K;Database=company";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<employee> employees { get; set; }
        public DbSet<staff> staffs { get; set; }
    }
}