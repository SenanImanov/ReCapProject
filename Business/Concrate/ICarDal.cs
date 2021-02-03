using Entities.Concrate;
using System.Collections.Generic;

namespace Business.Concrate
{
    internal interface ICarDal
    {
        void Update(Car car);
        List<Car> GetById(int id);
        List<Car> GetAll();
        void Delete(Car car);
        void Add(Car car);
    }
}