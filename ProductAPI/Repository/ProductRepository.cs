// <copyright file="ProductRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProductAPI.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using ProductAPI.Data;

    /// <summary>
    /// Implementation of the product repository interface.
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public ProductRepository(ProductDbContext context)
        {
            this.context = context;
        }

        /// <inheritdoc/>
        public List<Product> GetAllProducts()
        {
            return this.context.Products.ToList();
        }

        /// <inheritdoc/>
        public Product GetProductById(int id)
        {
            return this.context.Products.FirstOrDefault(p => p.Id == id);
        }

        /// <inheritdoc/>
        public Product AddProduct(Product product)
        {
            this.context.Products.Add(product);
            this.context.SaveChanges();
            return product;
        }

        /// <inheritdoc/>
        public Product UpdateProduct(Product product)
        {
            this.context.Products.Update(product);
            this.context.SaveChanges();
            return product;
        }

        /// <inheritdoc/>
        public void DeleteProduct(int id)
        {
            var product = this.context.Products.FirstOrDefault(p => p.Id == id);
            this.context.Products.Remove(product);
            this.context.SaveChanges();
        }

        /// <inheritdoc/>
        public void DeleteProduct(string productName)
        {
            var product = this.context.Products.FirstOrDefault(p => p.Name == productName);
            this.context.Products.Remove(product);
            this.context.SaveChanges();
        }

        /// <inheritdoc/>
        public Product GetProductByName(string name)
        {
            return this.context.Products.FirstOrDefault(p => p.Name == name);
        }
    }
}