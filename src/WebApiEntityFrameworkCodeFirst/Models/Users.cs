using System;
using System.Linq;

namespace WebApiEntityFrameworkCodeFirst.Models
{
    public class Users
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

    }
}
