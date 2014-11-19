using System;
using System.Data.Entity;
using System.Linq;

namespace WebApiEntityFrameworkCodeFirst.Models
{
    public class BaselineEntities : DbContext
    {

        public BaselineEntities()
            : base("name=BaselineEntities")
        {
            Database.SetInitializer<BaselineEntities>(null);
        }

        public virtual DbSet<Users> Users { get; set; }


    }
}
