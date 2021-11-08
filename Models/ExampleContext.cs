using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BulmaTutorial.Models
{
    public class ExampleContext :DbContext
    {
        public ExampleContext(DbContextOptions<ExampleContext> options) : base(options) { }
        public DbSet<BulmaExample> Foods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BulmaExample>().HasData(
                new BulmaExample
                {
                    ID = 1,
                    Food = "Pepperoni Pizza",
                    Category = "Fats",
                    Brand = "DiGiorno",
                    Cost = 6,
                    
                },
                new BulmaExample
                {
                    ID = 2,
                    Food = "Frosted Flakes",
                    Category = "Cereal",
                    Brand = "Kellog",
                    Cost = 3,
                },
                new BulmaExample
                {
                    ID = 3,
                    Food = "Carrot Sticks",
                    Category = "Vegetables",
                    Brand = "Country Fresh",
                    Cost = 2,
                },
             new BulmaExample
             {
                 ID = 4,
                 Food = "Strawberries",
                 Category = "Fruits",
                 Brand = "Driscoll's",
                 Cost = 4,
             },
             new BulmaExample
             {
                 ID = 5,
                 Food = "Chicken Nuggets",
                 Category = "Protein",
                 Brand = "Tyson",
                 Cost = 5,
             },
             new BulmaExample
             {
                 ID = 6,
                 Food = "Doritos",
                 Category = "Fats",
                 Brand = "Frito Lay",
                 Cost = 3,
             }
                );
        }
    }
}
