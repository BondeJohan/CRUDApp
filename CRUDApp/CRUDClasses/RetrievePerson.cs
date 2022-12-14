using CRUDApp.Database;
using CRUDApp.Interface;
using CRUDApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDApp.CRUDClasses
{
    internal class RetrievePerson : IRetrievePerson
    {
        private readonly PersonDB db;

        public RetrievePerson(PersonDB conn)
        {
            this.db = conn;
        }        
    }
}
