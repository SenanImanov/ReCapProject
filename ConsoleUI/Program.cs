using DataAccess.Abstract;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarDal carDal = new InMemoryCarDal();


            List<Car> cars = carDal.GetAll();
            foreach (var car in cars)
            {
                Console.WriteLine(car.ModelYear);
            }






        }
    }
}
