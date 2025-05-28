// <copyright file="SeedData.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProductAPI.Data
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Provides methods to seed initial data into the database context.
    /// </summary>
    public static class SeedData
    {
        /// <summary>
        /// Seeds the database with initial product data if no products exist.
        /// </summary>
        /// <param name="context">The database context to seed data into.</param>
        public static void Seed(this ProductDbContext context)
        {
            if (!context.Products.Any())
            {
                var products = new List<Product>
                      {
                          new ()
                          {
                              Name = "Keyboard",
                              Description = "Gaming Keyboard with lights",
                              Price = 150,
                              ProductType = ProductType.PERIPHARALS,
                          },
                          new ()
                          {
                              Name = "Mouse",
                              Description = "Gaming Mouse",
                              Price = 40,
                              ProductType = ProductType.PERIPHARALS,
                          },
                          new ()
                          {
                              Name = "Monitor",
                              Description = "HD monitor",
                              Price = 400,
                              ProductType = ProductType.MONITOR,
                          },
                          new ()
                          {
                              Name = "Cabinet",
                              ProductType = ProductType.EXTERNAL,
                              Description = "Business Cabinet with lights",
                              Price = 60,
                          },
                      };

                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}
