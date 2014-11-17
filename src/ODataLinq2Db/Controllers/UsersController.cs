using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http.OData;

using ODataLinq2Db.Models;

namespace ODataLinq2Db.Controllers
{

    public class UsersController : EntitySetController<Users, int>
    {

        public override IQueryable<Users> Get()
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
