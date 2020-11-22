using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get 
            {
                return new List<Car>
                {
                    new Car
                    {
                        name="Tesla",
                        shortDesc="A very nice car", 
                        longDesc="An innovative electric car", 
                        img="/img/tesla.jpg", 
                        price=45000, 
                        available=true, 
                        isFavourite=true, 
                        Category=_categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name="Ford Fiesta",
                        shortDesc="A very nice car",
                        longDesc="An innovative petrol car",
                        img="/img/ford_fiesta.jpg",
                        price=30000,
                        available=true,
                        isFavourite=true,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name="BMW M3",
                        shortDesc="A very nice car",
                        longDesc="An innovative petrol car",
                        img="/img/bmw-m3.jpg",
                        price=50000,
                        available=true,
                        isFavourite=true,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name="Nissan Leaf",
                        shortDesc="A very nice car",
                        longDesc="An innovative electric car",
                        img="/img/nissan_leaf.jpg",
                        price=20000,
                        available=true,
                        isFavourite=true,
                        Category=_categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get ; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
