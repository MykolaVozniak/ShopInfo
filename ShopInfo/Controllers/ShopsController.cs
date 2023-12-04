using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopInfo.Constants;
using ShopInfo.Models;
using ShopInfo.Pages.TablePages;
using System.Data;

namespace ShopInfo.Controllers
{
    public class ShopsController : Controller
    {
        public IEnumerable<Shop> GetShops(int n, bool isAsc)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new 
                {
                    TableName = "Shops", 
                    nCount = n, 
                    isASC = isAsc 
                };
                var rows = connection.Query<Shop>(
                    DataBaseConstants.GetRecords,
                     parameters,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public bool CreateShop(Shop shop)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    shop.ShopName,
                    shop.City,
                    shop.Adress,
                    shop.Email,
                    shop.Phone,
                    shop.PostalCode,
                };
                    var rows = connection.Execute(
                    DataBaseConstants.ShopCreate,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool DeleteShop(int shopId)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    ShopId = shopId
                };
                var rows = connection.Execute(
                    DataBaseConstants.ShopDelete,
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return rows > 0;
            }
        }

        public Shop GetShop(int shopId)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    ShopId = shopId
                };
                var shop = connection.QueryFirstOrDefault<Shop>(
                    DataBaseConstants.ShopGetById,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return shop;
            }
        }

        public bool EditShop(Shop shop)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    ShopId = shop.Id,
                    shop.ShopName,
                    shop.City,
                    shop.Adress,
                    shop.Email,
                    shop.Phone,
                    shop.PostalCode,
                };
                var rows = connection.Execute(
                    DataBaseConstants.ShopEdit,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }
    }
}
