using System;
using System.Linq;

using LinqToDB.Mapping;

namespace WebApiLinq2Db.Models
{
    [Table("Groups")]
    public class Groups
    {
        
        [Column, NotNull]
        public int Id { get; set; }
        
        [Column, NotNull]
        public string Name { get; set; }

    }
}
