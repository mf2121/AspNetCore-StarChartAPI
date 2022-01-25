﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private object celestialObject;

        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}", Name = "GetByID")]
        public IActionResult GetByID(int id)
        {
        var celestialObject = _context.CelestialObjects.Find(id);
        if (celestialObject == null)
            return NotFound();
            celestialObject.Satellites = _context.CelestialObjects.Where(e => e.OrbitedObjectId == id).ToList();
            return Ok(celestialObject);
        }

    }
}
