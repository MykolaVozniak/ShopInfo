using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopInfo.Constants;
using ShopInfo.Models;
using System.Data;

namespace ShopInfo.Controllers
{
    public class EmployeesController : Controller
    {
        public IEnumerable<Employee> GetEmployees(int n, bool isAsc)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    TableName = "Employees",
                    nCount = n,
                    isASC = isAsc
                };
                var rows = connection.Query<Employee>(
                    DataBaseConstants.GetRecords,
                     parameters,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public bool CreateEmployee(Employee employee)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    employee.UserId,
                    employee.RoleId,
                    employee.HireDate,
                    employee.IsOwner,
                };
                var rows = connection.Execute(
                DataBaseConstants.EmployeeCreate,
                parameters,
                commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool DeleteEmployee(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    EmployeeId = id
                };
                var rows = connection.Execute(
                    DataBaseConstants.EmployeeDelete,
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return rows > 0;
            }
        }

        public Employee GetEmployee(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    EmployeeId = id
                };
                var employee = connection.QueryFirstOrDefault<Employee>(
                    DataBaseConstants.EmployeeGetById,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return employee;
            }
        }

        public bool EditEmployee(Employee employee)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    EmployeeId = employee.Id,
                    employee.UserId,
                    employee.RoleId,
                    employee.HireDate,
                    employee.IsOwner,
                };
                var rows = connection.Execute(
                    DataBaseConstants.EmployeeEdit,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }
    }
}
