using System;
using System.Linq;

using LinqToDB.Mapping;

namespace WebApiLinq2Db.Models
{
    [Table("Users")]
    public class Users
    {

        [Column, NotNull]
        public int Id { get; set; }

        [Column, NotNull]
        public string FirstName { get; set; }
        
        [Column, NotNull]
        public string LastName { get; set; }
        
        [Column, NotNull]
        public string EmailAddress { get; set; }

    }
}
