using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CARSAmind.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CARSAmind.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarRepository<Car> _context;

        public CarsController(ICarRepository<Car> carRepository)
        {
            _context = carRepository;
        }

        //Get:api/Car
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Car> cars = _context.GetAll();
            return Ok(cars);
        }

        

        //Get:api/Car/5
        [HttpGet("id", Name = "Get")]
        public IActionResult Get(long id)
        {
            Car car = _context.Get(id);
            if (car == null)
            {
                return NotFound("The product couldnt be found. ");
            }
            return Ok(car);
        }
        

        //Post:api/Car
        [HttpPost]
        public void  Post([FromBody] Car car)
        {
            
             _context.Add(car);
            
        }
        

        //PUT: api/Car/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Car car)
        {
            if (car == null)
            {
                return BadRequest("Car is null");
            }
           Car carToUpdate = _context.Get(id);
            if (carToUpdate == null)
            {
                return NotFound("The Car record couldnt be found ");
            }
            _context.Update(carToUpdate, car);
            return NoContent();
        }

        
    }
}