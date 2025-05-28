// <copyright file="IProductUtil.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EAWebApp.Producer
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProductUtil
    {
        Task<Product> CreateProduct(Product product);

        Task DeleteProduct(int id);

        Task<Product> EditProduct(Product product);

        Task<ICollection<Product>> GetProduct();

        Task<Product> GetProductById(int id);
    }
}