using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopInfo.Constants;
using ShopInfo.Models;
using System.Data;

namespace ShopInfo.Controllers
{
    public class ProductsController : Controller
    {
        public IEnumerable<Product> GetProducts(int n, bool isAsc)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    TableName = "Products",
                    nCount = n,
                    isASC = isAsc
                };
                var rows = connection.Query<Product>(
                    DataBaseConstants.GetRecords,
                     parameters,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public bool CreateProduct(Product product)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    product.CategoryId,
                    product.ProductName,
                    product.SKU,
                    product.Price,
                    product.ImageURL,
                    product.TaxGroup,
                    product.Is18Plus,
                    product.IsExciseApplicable,
                };
                var rows = connection.Execute(
                DataBaseConstants.ProductCreate,
                parameters,
                commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool DeleteProduct(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    ProductId = id
                };
                var rows = connection.Execute(
                    DataBaseConstants.ProductDelete,
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return rows > 0;
            }
        }

        public Product GetProduct(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    ProductId = id
                };
                var product = connection.QueryFirstOrDefault<Product>(
                    DataBaseConstants.ProductGetById,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return product;
            }
        }

        public bool EditProduct(Product product)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    ProductId = product.Id,
                    product.CategoryId,
                    product.ProductName,
                    product.SKU,
                    product.Price,
                    product.ImageURL,
                    product.TaxGroup,
                    product.Is18Plus,
                    product.IsExciseApplicable,
                };
                var rows = connection.Execute(
                    DataBaseConstants.ProductEdit,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }
    }
}
