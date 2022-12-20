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
    internal class UpdatePerson : IUpdatePerson
    {
        public void UpdatePersonInfo(Person person, PersonDB db)
        {
            Console.WriteLine("Enter id to Update");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter New Name");
            string ufName = Console.ReadLine();

            Console.WriteLine("Enter New Lastname");
            string ulName = Console.ReadLine();

            Console.WriteLine("Enter New Address");
            string uAdress = Console.ReadLine();

            person.Id = id;
            person.FirstName = ufName;
            person.LastName = ulName;
            person.Address = uAdress;

            db.Update(person);
            db.SaveChanges();
        }
    }
}
