using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Theorem_ACPrototype_WebAPI.Models;
using Theorem_ACPrototype_WebAPI.Repository.EFCore;

namespace Theorem_ACPrototype_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : BaseController<Device, EfCoreDeviceRepository>
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };



        public MoviesController(EfCoreDeviceRepository repository) : base(repository)
        {

        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> GetTest()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}