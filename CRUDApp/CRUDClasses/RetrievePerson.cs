using CRUDApp.Database;
using CRUDApp.Interface;
using CRUDApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDApp.CRUDClasses
{
    internal class RetrievePerson : IRetrievePerson
    {
        public void ReadPersonInfo(PersonContext db)
        {
            var query = from p in db.Persons
                        select p;

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName} {item.Address}");
            }
        }
    }
}
