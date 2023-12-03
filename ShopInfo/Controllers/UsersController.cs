using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopInfo.Constants;
using ShopInfo.Models;
using System.Data;

namespace ShopInfo.Controllers
{
    public class UsersController : Controller
    {
        public IEnumerable<User> GetUsers(int n, bool isAsc)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new { TableName = "Users", nCount = n, isASC = isAsc };
                var rows = connection.Query<User>(
                    DataBaseConstants.GetFirstNRecords,
                     parameters,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }
    }
}
