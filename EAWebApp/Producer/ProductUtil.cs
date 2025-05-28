// <copyright file="ProductUtil.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EAWebApp.Producer
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// Provides utility methods for managing products using the ProductAPI.
    /// </summary>
    public class ProductUtil : IProductUtil
    {
        private readonly ProductAPI productApiClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductUtil"/> class.
        /// </summary>
        public ProductUtil() => this.productApiClient = new ProductAPI("http://eaapi:8001", new HttpClient());

        /// <inheritdoc/>
        public async Task<Product> CreateProduct(Product product)
        {
            return await this.productApiClient.CreateAsync(product);
        }

        /// <inheritdoc/>
        public async Task DeleteProduct(int id)
        {
            await this.productApiClient.DeleteAsync(id);
        }

        /// <inheritdoc/>
        public async Task<Product> EditProduct(Product product)
        {
            return await this.productApiClient.UpdateAsync(product);
        }

        /// <inheritdoc/>
        public async Task<ICollection<Product>> GetProduct()
        {
            return await this.productApiClient.GetProductsAsync();
        }

        /// <inheritdoc/>
        public async Task<Product> GetProductById(int id)
        {
            return await this.productApiClient.GetProductByIdAsync(id);
        }
    }
}
