using Customers.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Data.Context
{
    public class CustomerDbContext : DbContext
    {
        private readonly string _connectionString;

        public CustomerDbContext() : this("Server=FMMBQG3\\SQLEXPRESS;Database=CustomerDb;User Id=sa;Password=mikkodacasin03")
        {

        }

        public CustomerDbContext(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public DbSet<CustomerEntity> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(this._connectionString);
            }
        }

    }
}
