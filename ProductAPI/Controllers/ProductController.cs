// <copyright file="ProductController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProductAPI.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using ProductAPI.Data;
    using ProductAPI.Repository;

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        [Route("/[controller]/[action]/{id}")]
        public Product GetProductById(int id)
        {
            return this.productRepository.GetProductById(id);
        }

        // GET: ProductController/GetProducts
        [HttpGet]
        [Route("/[controller]/[action]")]
        public ActionResult<List<Product>> GetProducts()
        {
            return this.productRepository.GetAllProducts();
        }

        // POST: ProductController/Create
        [HttpPost]
        [Route("/[controller]/[action]")]
        public Product Create(Product product)
        {
            return this.productRepository.AddProduct(product);
        }

        // PUT: ProductController/Create
        [HttpPut]
        [Route("/[controller]/[action]")]
        public Product Update(Product product)
        {
            return this.productRepository.UpdateProduct(product);
        }

        // PUT: ProductController/Delete
        [HttpDelete]
        [Route("/[controller]/[action]")]
        public void Delete(int id)
        {
            this.productRepository.DeleteProduct(id);
        }

    }
}