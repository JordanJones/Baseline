using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

using WebApiLinq2Db.Models;

namespace WebApiLinq2Db.Controllers
{
    public class UsersController : ApiController
    {

        [Route("Users/Small"), HttpGet]
        public IQueryable<Users> GetSmall()
        {
            return GetUsers(10, Request.RegisterForDispose);
        }
        

        [Route("Users/Medium"), HttpGet]
        public IQueryable<Users> GetMedium()
        {
            return GetUsers(500, Request.RegisterForDispose);
        }
        
        
        [Route("Users"), Route("Users/Large"), HttpGet]
        public IQueryable<Users> GetLarge()
        {
            return GetUsers(1000, Request.RegisterForDispose);
        }

        private IQueryable<Users> GetUsers(int count, Action<IDisposable> disposable)
        {
            var db = new DataContext();
            disposable(db);
            return db.Users.Take(count);
        }

    }
}
