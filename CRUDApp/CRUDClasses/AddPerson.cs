using CRUDApp.Database;
using CRUDApp.Interface;
using CRUDApp.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDApp.CRUDClasses
{
    internal class AddPerson : IAddPerson
    {
        private readonly PersonContext db;

        public AddPerson(PersonContext conn)
        {
            this.db = conn;
        }
        public void AddNewPerson()
        {
            Person person = new Person();

            Console.WriteLine("Enter ID");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();

            person.Id = id;
            person.LastName = lname;
            person.FirstName= fname;
            person.Address = address;

            var query = "INSERT Person(Id, FirstName, LastName, Address) VALUES(@Id, @FirstName, @LastName, @Address)";
            var parameter = new SqlParameter[]
            {
                new SqlParameter("@Id", person.Id ),
                new SqlParameter("@FirstName", person.FirstName),
                new SqlParameter("@LastName", person.LastName),
                new SqlParameter("@Address", person.Address)
            };
            db.Database.ExecuteSqlRaw(query, parameter);
        }
    }
}
