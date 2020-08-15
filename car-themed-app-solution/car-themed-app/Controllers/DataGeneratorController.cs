﻿using car_themed_app_Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace car_themed_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataGeneratorController : ControllerBase
    {
        private readonly IDbSeeder _DbSeeder;

        public DataGeneratorController(IDbSeeder DbSeeder)
        {
            _DbSeeder = DbSeeder;
        }

        /// <summary>
        /// Seed database with some predefined data. This operation removes all current data held by Db!
        /// </summary>
        /// <returns>Amount of rows added into database.</returns>
        [HttpPost]
        public IActionResult SeedData()
        {
            var amountOfRows = _DbSeeder.SeedDatabase();

            return Ok($"Inserted {amountOfRows} rows into database.");
        }
    }
}