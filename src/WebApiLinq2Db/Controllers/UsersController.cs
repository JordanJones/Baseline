﻿using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

using WebApiLinq2Db.Models;

namespace WebApiLinq2Db.Controllers
{
    public class UsersController : ApiController
    {

        [Route("Users"), HttpGet]
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
