// <copyright file="IProductRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProductAPI.Repository
{
    using System.Collections.Generic;
    using ProductAPI.Data;

    /// <summary>
    /// Interface for managing product-related operations.
    /// </summary>
    public interface IProductRepository
    {
        /// <summary>
        /// Adds a new product to the repository.
        /// </summary>
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>
        Product AddProduct(Product product);

        /// <summary>
        /// Deletes a product by its ID.
        /// </summary>
        /// <param name="id">The ID of the product to delete.</param>
        void DeleteProduct(int id);

        /// <summary>
        /// Deletes a product by its name.
        /// </summary>
        /// <param name="productName">The name of the product to delete.</param>
        void DeleteProduct(string productName);

        /// <summary>
        /// Retrieves all products from the repository.
        /// </summary>
        /// <returns>A list of all products.</returns>
        List<Product> GetAllProducts();

        /// <summary>
        /// Retrieves a product by its ID.
        /// </summary>
        /// <param name="id">The ID of the product to retrieve.</param>
        /// <returns>The product with the specified ID, or null if not found.</returns>
        Product GetProductById(int id);

        /// <summary>
        /// Retrieves a product by its name.
        /// </summary>
        /// <param name="name">The name of the product to retrieve.</param>
        /// <returns>The product with the specified name, or null if not found.</returns>
        Product GetProductByName(string name);

        /// <summary>
        /// Updates an existing product in the repository.
        /// </summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        Product UpdateProduct(Product product);
    }
}