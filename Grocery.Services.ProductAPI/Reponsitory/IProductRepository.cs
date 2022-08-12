﻿using Grocery.Services.ProductAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Grocery.Services.ProductAPI.Reponsitory
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetProductById(int productId);
        Task<ProductDTO> CreateUpdateProduct(ProductDTO productDTO);
        Task<bool> DeleteProduct(int productId);
    }
}
