using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.Car.AddRange(
                    new Car
                    {
                        shortDesc = "A very nice car",
                        name = "Tesla",
                        longDesc = "An innovative electric car",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        available = true,
                        isFavourite = true,
                        Category = Categories["Electrocar"]
                    },
                    new Car
                    {
                        shortDesc = "A very nice car",
                        name = "Ford Fiesta",
                        longDesc = "An innovative petrol car",
                        img = "/img/ford_fiesta.jpg",
                        price = 30000,
                        available = true,
                        isFavourite = true,
                        Category = Categories["Classic car"]
                    },
                    new Car
                    {
                        shortDesc = "A very nice car",
                        name = "BMW M3",
                        longDesc = "An innovative petrol car",
                        img = "/img/bmw-m3.jpg",
                        price = 50000,
                        available = true,
                        isFavourite = true,
                        Category = Categories["Classic car"]
                    },
                    new Car
                    { 
                        shortDesc = "A very nice car",
                        name = "Nissan Leaf",
                        longDesc = "An innovative electric car",
                        img = "/img/nissan_leaf.jpg",
                        price = 20000,
                        available = true,
                        isFavourite = true,
                        Category = Categories["Electrocar"]
                    });
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category{categoryName = "Electrocar", desc = "Modern type of transport"},
                        new Category{categoryName = "Classic car", desc = "The cars with the internal combustion engine"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }

    }
}
