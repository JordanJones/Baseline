﻿using System;
using System.Linq;

using LinqToDB;
using LinqToDB.Data;

namespace WebApiLinq2Db.Models
{
    public class DataContext : DataConnection
    {

        public DataContext()
            : base("BaselineTesting") {}


        public ITable<Users> Users
        {
            get { return GetTable<Users>(); }
        }

    }
}
