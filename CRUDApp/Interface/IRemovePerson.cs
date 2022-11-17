﻿using CRUDApp.Database;
using CRUDApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApp.Interface
{
    public interface IRemovePerson
    {
        void RemovePersonInfo(Person person, PersonContext db);
    }
}
