using Company.RentalCar.Domain.Entities;
using System.Collections.Generic;

namespace Company.RentalCar.Infrastructure.Repositories
{
    public class CarRepository
    {
        private readonly List<Car> _cars = new();
        public void Add(Car car) => _cars.Add(car);
        public List<Car> GetAll() => _cars;
    }
}
