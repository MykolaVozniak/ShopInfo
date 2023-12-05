using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopInfo.Constants;
using ShopInfo.Models;
using System.Data;

namespace ShopInfo.Controllers
{
    public class RolesController : Controller
    {
        public IEnumerable<Role> GetRoles(int n, bool isAsc)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new 
                {
                    TableName = "Roles", 
                    nCount = n, 
                    isASC = isAsc 
                };
                var rows = connection.Query<Role>(
                    DataBaseConstants.GetRecords,
                     parameters,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public bool CreateRole(Role role)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    role.ShopId,
                    role.RoleName,
                    role.RoleDescription,
                };
                    var rows = connection.Execute(
                    DataBaseConstants.RoleCreate,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool DeleteRole(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    RoleId = id
                };
                var rows = connection.Execute(
                    DataBaseConstants.RoleDelete,
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return rows > 0;
            }
        }

        public Role GetRole(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    RoleId = id
                };
                var role = connection.QueryFirstOrDefault<Role>(
                    DataBaseConstants.RoleGetById,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return role;
            }
        }

        public bool EditRole(Role role)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    RoleId = role.Id,
                    role.ShopId,
                    role.RoleName,
                    role.RoleDescription,
                };
                var rows = connection.Execute(
                    DataBaseConstants.RoleEdit,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }
    }
}
