using System.Data.Entity;

namespace ODataEntityFrameworkCodeFirst.Models
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