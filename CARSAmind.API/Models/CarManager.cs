using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CARSAmind.API.Models
{
    public class CarManager : ICarRepository<Car>
    {
        readonly CarContext _carContext;
        ILogger logger;

        public CarManager(CarContext context, ILogger<Car> log)
        {

            logger = log;
            _carContext = context;

            
        }

        public void Add(Car entity)
        {
            _carContext.Cars.Add(entity);
            _carContext.SaveChanges();
        }

        public void Delete(Car car)
        {
            logger.LogInformation($"Deleting car of {car.Id}");
            _carContext.Cars.Remove(car);
            _carContext.SaveChanges();
        }

        public Car Get(long id)
        {
            logger.LogInformation($"Getting car of {id}");
            return _carContext.Cars.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Car> GetAll()
        {
            logger.LogInformation($"Getting  Cars ");
            return _carContext.Cars.ToList();
        }

        public void Update(Car car, Car entity)
        {
            logger.LogInformation($" Updating car {car}");
            car.Make = entity.Make;
            car.HorsePower = entity.HorsePower;
            car.Model = entity.Model;
            car.TopSpeed = entity.TopSpeed;
            car.Year = car.Year;
        }
    }
}
