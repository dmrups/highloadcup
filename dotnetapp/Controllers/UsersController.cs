using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Entities;
using dotnetapp.Code;

namespace dotnetapp.Controllers
{
    public class UsersController : Controller
    {
        IRepository repository; 

        public UsersController(IRepository repository){
            this.repository = repository;
        }

        [HttpGet]
        [Route("users/{id}")]
        public object Get(int id)
        {
            return repository.GetUser(id);
        }

        [HttpPost]
        [Route("users/{id}")]
        public void Post(int id, [FromBody]User value)
        {
            repository.UpdateUser(id, value);
        }

        [HttpPost]
        [Route("users/new")]
        public void PostNew([FromBody]User value)
        {
            repository.AddUser(value);
        }
    }
}
