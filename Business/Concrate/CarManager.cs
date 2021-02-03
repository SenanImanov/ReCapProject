using Business.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {

        ICarDal _carDal;


        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int Id)
        {
            return _carDal.GetById(Id);
        }


    }
}
