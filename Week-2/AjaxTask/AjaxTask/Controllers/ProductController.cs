using System;
using System.Collections.Generic;
using System.Linq;
using AjaxTask.Data;
using AjaxTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxTask.Controllers
{
    public class ProductController: Controller
    {
        private readonly ProductsContext _context;

        public ProductController(ProductsContext context)
        {
            _context = context;
        }

        public JsonResult GetProducts([FromBody] SearchModel searchModel)
        {
            var products = _context.Products.ToList();
            var containedProducts = new List<Product>();

            if (string.IsNullOrEmpty(searchModel.text)) return Json(containedProducts);

            foreach (Product product in products)
            {
                if (product.name.ToLower().Contains(searchModel.text.ToLower()))
                {
                    containedProducts.Add(product);
                }
            }

            return Json(containedProducts);
        }
    }
}
