// <copyright file="ProductController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EAWebApp.Controllers
{
    using System.Threading.Tasks;
    using EAWebApp.Producer;
    using Microsoft.AspNetCore.Mvc;

    public class ProductController : Controller
    {
        private readonly IProductUtil productUtil;

        public ProductController(IProductUtil productUtil)
        {
            this.productUtil = productUtil;
        }

        public IActionResult Index()
        {
            return this.View(); // Fixed SA1101
        }

        public async Task<IActionResult> List()
        {
            var products = await this.productUtil.GetProduct(); // Fixed SA1101
            return this.View(products); // Fixed SA1101
        }

        public ActionResult Create()
        {
            return this.View(); // Fixed SA1101
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            await this.productUtil.CreateProduct(product); // Fixed SA1101

            return this.RedirectToAction("List"); // Fixed SA1101
        }

        public async Task<IActionResult> Edit(int id)
        {
            return this.View(await this.productUtil.GetProductById(id)); // Fixed SA1101
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            await this.productUtil.EditProduct(product); // Fixed SA1101

            return this.RedirectToAction("List"); // Fixed SA1101
        }

        public async Task<IActionResult> Delete(int id)
        {
            return this.View(await this.productUtil.GetProductById(id)); // Fixed SA1101
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id, Product product)
        {
            try
            {
                await this.productUtil.DeleteProduct(id); // Fixed SA1101

                return this.RedirectToAction("List"); // Fixed SA1101
            }
            catch
            {
                return this.View(); // Fixed SA1101
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            return this.View(await this.productUtil.GetProductById(id)); // Fixed SA1101
        }
    }
}
