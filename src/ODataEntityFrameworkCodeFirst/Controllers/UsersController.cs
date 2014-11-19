using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http.OData;

using ODataEntityFrameworkCodeFirst.Models;

namespace ODataEntityFrameworkCodeFirst.Controllers
{
    public class UsersController : EntitySetController<Users, int>
    {

        public override IQueryable<Users> Get()
        {
            return GetUsers(1000, Request.RegisterForDispose);
        }

        private IQueryable<Users> GetUsers(int count, Action<IDisposable> disposable)
        {
            var db = new BaselineEntities();
            disposable(db);
            return db.Users.Take(count);
        }

    }
}
