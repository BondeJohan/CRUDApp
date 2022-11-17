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
        private const string DatabaseName = "PersonDB";
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($@"Server = .\SQLEXPRESS;Database={DatabaseName};trusted_connection=true");
        }
    }
}
