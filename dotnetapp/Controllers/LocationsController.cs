using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Entities;
using dotnetapp.Code;

namespace dotnetapp.Controllers
{
    public class LocationsController : Controller
    {
        IRepository repository;

        public LocationsController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        [Route("locations/{id}")]
        public object Get(int id)
        {
            return repository.GetLocation(id);
        }

        [HttpPost]
        [Route("locations/{id}")]
        public void Post(int id, [FromBody]Location value)
        {
            value.id = id;
            repository.UpdateLocation(value);
        }

        [HttpPost]
        [Route("locations/new")]
        public void PostNew([FromBody]User value)
        {
            repository.AddUser(value);
        }
    }
}
