using System;
using Crud.Domain.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public PersonController()
        {
            
        }

        [HttpGet("person")]
        public Person GetPerson()
        {
            var person = new Person
            {
                Id = Guid.NewGuid(),
                DateOfBirth = DateTime.Parse("1988-08-18"),
                Email = "rafael@sodre.com.br",
                Name = "Rafael",
                Surname = "Sodré",
                Phone = "27 99972-3564"
            };

            return person;

        }
    }
}
