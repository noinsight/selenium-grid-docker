namespace ProductAPI.Data
{
    /// <summary>
    /// Represents a product with its details.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the unique identifier for the product.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets the type of the product.
        /// </summary>
        public ProductType ProductType { get; set; }
    }

    /// <summary>
    /// Enum representing the types of products.
    /// </summary>
    public enum ProductType
    {
        /// <summary>
        /// Represents a CPU product type.
        /// </summary>
        CPU,

        /// <summary>
        /// Represents a monitor product type.
        /// </summary>
        MONITOR,

        /// <summary>
        /// Represents peripherals product type.
        /// </summary>
        PERIPHARALS,

        /// <summary>
        /// Represents external product type.
        /// </summary>
        EXTERNAL,
    }
}