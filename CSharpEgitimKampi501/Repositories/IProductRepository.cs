﻿using CSharpEgitimKampi501.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Repositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<int> CreateProductAsync(CreateProductDto createProductDto);
        Task<int> UpdateProductAsync(UpdateProductDto updateProductDto);
        Task<int> DeleteProductAsync(int id);
        Task<List<ResultProductDto>> GetByProductIdAsync(int id);
    }
}