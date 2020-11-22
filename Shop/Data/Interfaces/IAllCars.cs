using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface IAllCars
    {
        public IEnumerable<Car> Cars { get; }
        
        public IEnumerable<Car> getFavCars { get; }
        public Car getObjectCar(int carId);
    }
}
