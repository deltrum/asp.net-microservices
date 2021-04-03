using System;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers
{
    [ApiController]
    [Route("/articles")]
    public class ArticlesController : ControllerBase
    {
        private static readonly string[] Articles = new[]
        {
            "SPACEX LAUNCHED SOMETHING", "NASA IS ON THE WAY TO THE MOON", "NEW PRIVATE SPACE AGENCIES OPENED"
        };


        [HttpGet]
        public ActionResult GetRandomArticle()
        {
            var rng = new Random();

            return Ok(Articles[rng.Next(Articles.Length)]);
        }

    }
}