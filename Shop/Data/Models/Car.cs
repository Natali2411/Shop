using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car
    {
        [Key]
        public int id;
        [Required]
        public string name;
        [Required]
        public string shortDesc;
        [Required]
        public string longDesc;
        [Required]
        public string img;
        [Required]
        public ushort price;
        [Required]
        public bool isFavourite;
        [Required]
        public bool available;
        [Required]
        public int categoryID;
        [NotMapped]
        public virtual Category Category { get; set; }
    }
}
