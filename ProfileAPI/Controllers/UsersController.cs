using System;
using Microsoft.AspNetCore.Mvc;

namespace ProfileAPI.Controllers
{
    [ApiController]
    [Route("/users")]
    public class UsersController : ControllerBase
    {
        private static readonly string[] Users = new[]
        {
            "Nick Jackson", "Bill Opengates", "Neil Tyson"
        };

        [HttpGet]
        public ActionResult GetRandomUser()
        {
            var rng = new Random();

            return Ok(Users[rng.Next(Users.Length)]);
        }

    }
}