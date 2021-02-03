using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    
    public class InMemoryCarDal : ICarDal

    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            
                new Car{CarId =1, BrandId = 1, DailyPrice = 2, Description = "SIZIN WCWN OZEL", ModelYear = "2015", ColorId = 23},
                new Car{CarId =2, BrandId = 2, DailyPrice = 23, Description = "sAKIN ALMAYIN ", ModelYear = "2016", ColorId = 3},
                new Car{CarId =3, BrandId = 3, DailyPrice = 24, Description = "GUZEL ARABA", ModelYear = "1999", ColorId = 323},
                new Car{CarId =4, BrandId = 4, DailyPrice = 25, Description = "ISTE ABI BU", ModelYear = "2018", ColorId = 323},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == c.CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToUpdate);

            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
