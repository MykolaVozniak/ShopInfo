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
                var parameters = new 
                {
                    TableName = "Users", 
                    nCount = n, 
                    isASC = isAsc 
                };
                var rows = connection.Query<User>(
                    DataBaseConstants.GetRecords,
                     parameters,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public bool UserRegister(User user)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    user.LastName,
                    user.FirstName,
                    user.Email,
                    user.Password,
                    user.Phone,
                    user.Birthdate,
                    user.MiddleName
                };
                    var rows = connection.Execute(
                    DataBaseConstants.UserAdd,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool DeleteUser(int userId)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new 
                { 
                    UserId = userId 
                };
                var rows = connection.Execute(
                    DataBaseConstants.UserDelete,
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return rows > 0;
            }
        }
    }
}
