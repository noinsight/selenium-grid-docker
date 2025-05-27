namespace ProductAPI.Repository
{
    using System.Collections.Generic;
    using System.Linq;
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

    /// <summary>
    /// Implementation of the product repository interface.
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public ProductRepository(ProductDbContext context)
        {
            this._context = context;
        }

        /// <inheritdoc/>
        public List<Product> GetAllProducts()
        {
            return this._context.Products.ToList();
        }

        /// <inheritdoc/>
        public Product GetProductById(int id)
        {
            return this._context.Products.FirstOrDefault(p => p.Id == id);
        }

        /// <inheritdoc/>
        public Product AddProduct(Product product)
        {
            this._context.Products.Add(product);
            this._context.SaveChanges();
            return product;
        }

        /// <inheritdoc/>
        public Product UpdateProduct(Product product)
        {
            this._context.Products.Update(product);
            this._context.SaveChanges();
            return product;
        }

        /// <inheritdoc/>
        public void DeleteProduct(int id)
        {
            var product = this._context.Products.FirstOrDefault(p => p.Id == id);
            this._context.Products.Remove(product);
            this._context.SaveChanges();
        }

        /// <inheritdoc/>
        public void DeleteProduct(string productName)
        {
            var product = this._context.Products.FirstOrDefault(p => p.Name == productName);
            this._context.Products.Remove(product);
            this._context.SaveChanges();
        }

        /// <inheritdoc/>
        public Product GetProductByName(string name)
        {
            return this._context.Products.FirstOrDefault(p => p.Name == name);
        }
    }
}