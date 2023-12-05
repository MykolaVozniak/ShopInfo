using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopInfo.Constants;
using ShopInfo.Models;
using System.Data;

namespace ShopInfo.Controllers
{
    public class CategoriesController : Controller
    {

        public IEnumerable<Category> GetCategories(int n, bool isAsc)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    TableName = "Categories",
                    nCount = n,
                    isASC = isAsc
                };
                var rows = connection.Query<Category>(
                    DataBaseConstants.GetRecords,
                     parameters,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public bool CreateCategory(Category category)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    category.MotherCategoryId,
                    category.ShopId,
                    category.CategoryName,
                    category.CategoryDescription,
                };
                var rows = connection.Execute(
                DataBaseConstants.CategoryCreate,
                parameters,
                commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool DeleteCategory(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    CategoryId = id
                };
                var rows = connection.Execute(
                    DataBaseConstants.CategoryDelete,
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return rows > 0;
            }
        }

        public Category GetCategory(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    CategoryId = id
                };
                var category = connection.QueryFirstOrDefault<Category>(
                    DataBaseConstants.CategoryGetById,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return category;
            }
        }

        public bool EditCategory(Category category)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    CategoryId = category.Id,
                    category.MotherCategoryId,
                    category.ShopId,
                    category.CategoryName,
                    category.CategoryDescription,
                };
                var rows = connection.Execute(
                    DataBaseConstants.CategoryEdit,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }
    }
}
