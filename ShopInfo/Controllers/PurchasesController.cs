using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopInfo.Constants;
using ShopInfo.Models;
using System.Data;

namespace ShopInfo.Controllers
{
    public class PurchasesController : Controller
    {
        public IEnumerable<Purchase> GetPurchases(int n, bool isAsc)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    TableName = "Purchases",
                    nCount = n,
                    isASC = isAsc
                };
                var rows = connection.Query<Purchase>(
                    DataBaseConstants.GetRecords,
                     parameters,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public bool CreatePurchase(Purchase purchase)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    purchase.ProductId,
                    purchase.UserId,
                    purchase.PurchaseTime,
                };
                var rows = connection.Execute(
                DataBaseConstants.PurchaseCreate,
                parameters,
                commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool DeletePurchase(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    PurchaseId = id
                };
                var rows = connection.Execute(
                    DataBaseConstants.PurchaseDelete,
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return rows > 0;
            }
        }

        public Purchase GetPurchase(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    PurchaseId = id
                };
                var purchase = connection.QueryFirstOrDefault<Purchase>(
                    DataBaseConstants.PurchaseGetById,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return purchase;
            }
        }

        public bool EditPurchase(Purchase purchase)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    PurchaseId = purchase.Id,
                    purchase.ProductId,
                    purchase.UserId,
                    purchase.PurchaseTime,
                };
                var rows = connection.Execute(
                    DataBaseConstants.PurchaseEdit,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }
    }
}
