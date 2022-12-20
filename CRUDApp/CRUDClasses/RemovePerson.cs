using CRUDApp.Database;
using CRUDApp.Interface;
using CRUDApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApp.CRUDClasses
{
    internal class RemovePerson : IRemovePerson
    {
        public void RemovePersonInfo(Person person, PersonDB db)
        {
            Console.Write("Enter Id to remove: ");
            int idRemove = Convert.ToInt32(Console.ReadLine());

            person.Id = idRemove;

            db.Remove(person);
            db.SaveChanges();
        }
    }
}
