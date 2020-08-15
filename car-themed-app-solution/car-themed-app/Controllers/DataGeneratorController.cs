﻿using car_themed_app_DataLayer;
using car_themed_app_Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace car_themed_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataGeneratorController : ControllerBase
    {
        private IDbSeeder _dbSeeder;

        public DataGeneratorController(IDbSeeder dbSeeder)
        {
            _dbSeeder = dbSeeder;
        }

        /// <summary>
        /// Seed Database with some predefined data. This operation removes all current data held by Db!
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SeedData()
        {
            _dbSeeder.SeedDatabase();

            return Ok();
        }
    }
}