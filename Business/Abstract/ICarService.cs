﻿using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetById(int Id);
        List<Car> GetAll();
       
    }
}
