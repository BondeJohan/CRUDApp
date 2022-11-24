using CRUDApp.CRUDClasses;
using CRUDApp.Database;
using CRUDApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new PersonContext("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonDB;Integrated Security=True");

            AddPerson newPerson = new AddPerson(context);
            newPerson.AddNewPerson();
        }
    }
}
