using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

using WebApiSqlClient.Models;

namespace WebApiSqlClient.Controllers
{
    public class UsersController : ApiController
    {

        [Route("Users"), HttpGet]
        public IEnumerable<Users> GetLarge()
        {
            return GetUsers(1000, Request.RegisterForDispose);
        }

        private IEnumerable<Users> GetUsers(int count, Action<IDisposable> disposable)
        {
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BaselineTesting"].ConnectionString);
            conn.Open();
            disposable(conn);
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = string.Format("SELECT TOP {0} [Id], [FirstName], [LastName], [EmailAddress] FROM [Users]", count);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var obj = new Users
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            EmailAddress = reader.GetString(3)
                        };

                        yield return obj;
                    }
                    reader.Close();
                }
            }
        }

    }
}
