using CRUDApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApp.Database
{
    public class PersonContext : DbContext
    {
        private readonly string connectionString;
        public PersonContext(string conn)
        {
            this.connectionString = conn;
        }
        public DbSet<Person> Persons { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
