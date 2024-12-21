using CSharpEgitimKampi501.ConnectionString;
using CSharpEgitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly SqlConnection _connection;

        public ProductRepository()
        {
            _connection = DatabaseConnectionString.GetConnection();
        }

        public async Task<int> CreateProductAsync(CreateProductDto createProductDto)
        {
            string query = "insert into TblProduct (ProductName,ProductStock,ProductPrice,ProductCategory) values (@productName,@productStock,@productPrice,@productCategory)";
            return await _connection.ExecuteAsync(query, createProductDto);
        }

        public async Task<int> DeleteProductAsync(int id)
        {
            string query = "Delete From TblProduct Where ProductId=@productId";
            var parameters = new
            {
                productId = id,
            };
            return await _connection.ExecuteAsync(query, parameters);
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * From TblProduct";
            var value = await _connection.QueryAsync<ResultProductDto>(query);
            return value.ToList();
        }

        public async Task<List<ResultProductDto>> GetByProductIdAsync(int id)
        {
            string query = "Select * From TblProduct Where ProductId=@productId";
            var parameters = new
            {
                productId = id,
            };

            var value = await _connection.QueryAsync<ResultProductDto>(query, parameters);
            return value.ToList();
        }

        public async Task<int> UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            string query = "Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice,ProductStock=@productStock,ProductCategory=@productCategory where ProductId=@productId";
            return await _connection.ExecuteAsync(query, updateProductDto);
        }
    }
}
