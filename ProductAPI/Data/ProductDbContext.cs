// <copyright file="ProductDbContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProductAPI.Data
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Represents the database context for managing product-related data.
    /// </summary>
    public class ProductDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDbContext"/> class.
        /// </summary>
        /// <param name="options">The options to configure the database context.</param>
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> for products.
        /// </summary>
        public DbSet<Product> Products { get; set; }
    }
}