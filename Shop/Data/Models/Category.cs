using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string categoryName { get; set; }
        [Required]
        public string desc { get; set; }
        [Required]
        public List<Car> cars { get; set; }
    }
}
