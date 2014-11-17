using System.Data.SqlClient;

using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider;

namespace WebApiLinq2Db.Models
{
    public class DataContext : DataConnection
    {

        public DataContext()
            : base("BaselineTesting")
        {

        }


        public ITable<Users> Users { get { return GetTable<Users>(); } }

    }
}