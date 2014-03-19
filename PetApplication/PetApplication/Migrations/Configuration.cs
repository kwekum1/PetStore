namespace PetApplication.Migrations
{
    using PetApplication.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PetApplication.Models.PetDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PetApplication.Models.PetDBContext context)
        {
            context.Pets.AddOrUpdate(i => i.Name,
         new Pets
         {
             Name = "Dog",
             DateReceived = DateTime.Parse("2014-1-11"),
             Description = "Red-Nose Pitbull",
             Quantity = 5,
             Price = 7.99M
         },

          new Pets
          {
              Name = "Dog",
              DateReceived = DateTime.Parse("2014-3-13"),
              Description = "Golden-Retriever",
              Quantity = 4,
              Price = 8.99M
          },

          new Pets
          {
              Name = "Cat",
              DateReceived = DateTime.Parse("2006-2-23"),
              Description = "Persian",
              Quantity = 3,
              Price = 9.99M
          },

        new Pets
        {
            Name = "Bird",
            DateReceived = DateTime.Parse("2009-4-15"),
            Description = "Tropical Parrot",
            Quantity = 15,
            Price = 30.99M
        },

         new Pets
         {
             Name = "Fish",
             DateReceived = DateTime.Parse("2009-4-22"),
             Description = "Goldfish",
             Quantity = 105,
             Price = 3.99M
         },

          new Pets
          {
              Name = "Turtle",
              DateReceived = DateTime.Parse("2010-4-15"),
              Description = "Tortoise",
              Quantity = 1,
              Price = 4.99M
          }

        );
        }
    }
}
