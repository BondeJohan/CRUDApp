using CRUDApp.Database;
using CRUDApp.Interface;
using CRUDApp.Model;
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
        public void AddNewPerson(Person person, PersonContext db)
        {
            Console.WriteLine("Enter Name");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();

            person.LastName = lname;
            person.FirstName= fname;
            person.Address = address;

            db.Add(person);
            db.SaveChanges();
        }
    }
}
