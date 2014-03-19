using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace PetApplication.Models
{
    public class Pets
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "DateReceived")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime DateReceived { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pets> Pets { get; set; }
    }
}
