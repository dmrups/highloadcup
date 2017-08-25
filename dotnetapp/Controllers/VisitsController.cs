using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Entities;
using dotnetapp.Code;

namespace dotnetapp.Controllers
{
    public class VisitsController : Controller
    {
        IRepository repository;

        public VisitsController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        [Route("visits/{id}")]
        public object Get(int id)
        {
            return repository.GetVisit(id);
        }

        [HttpPost]
        [Route("visits/{id}")]
        public void Post(int id, [FromBody]Visit value)
        {
            value.id = id;
            repository.UpdateVisit(value);
        }

        [HttpPost]
        [Route("visits/new")]
        public void PostNew([FromBody]Visit value)
        {
            repository.AddVisit(value);
        }
    }
}
