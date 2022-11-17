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
            PersonContext db = new PersonContext();

            Person newPerson = new Person();

            AddPerson addNewPerson = new AddPerson();

            addNewPerson.AddNewPerson(newPerson, db);

            UpdatePerson upDatePerson = new UpdatePerson();

            upDatePerson.UpdatePersonInfo(newPerson, db);

            RemovePerson removePerson = new RemovePerson();

            removePerson.RemovePersonInfo(newPerson, db);

            RetrievePerson retrievePerson = new RetrievePerson();

            retrievePerson.ReadPersonInfo(db);
        }
    }
}
