using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CfSampleAppDotNet.Models;

namespace CfSampleAppDotNet.Controllers
{
    [Route("[controller]")]
    public class KittenController : Controller
    {
        public KittenController(IKittenRepository kittens)
        {
            Kittens = kittens;
        }
        public IKittenRepository Kittens { get; set; }

        [HttpGet]
        public IEnumerable<Kitten> Find()
        {
            return Kittens.Find();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Kitten kitten)
        {
            if (kitten == null)
            {
                return BadRequest();
            }
            Kittens.Create(kitten);
            return StatusCode(201);
        }
    }
}
