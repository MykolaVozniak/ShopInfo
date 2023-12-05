using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace ShopInfo.Constants
{
    public class DataBaseConstants
    {
        private const string ConnectionString = "Data Source=DESKTOP-UNRBAFF\\SQLEXPRESS;Initial Catalog=TumbleweedDB;Persist Security Info=True;User ID=sa;Password=mykola228";

        public static SqlConnection GetConnection()
            => new(ConnectionString);

        public const string GetRecords = "sp_Get_Records";

        #region Users
        public const string UserAdd = "sp_User_Add"; //Create
        public const string UserDelete = "sp_User_Delete";
        public const string UserGetById = "sp_User_Get_By_Id";
        public const string UserUpdate = "sp_User_Update"; //Edit
        #endregion

        #region Shops
        public const string ShopCreate = "sp_Shop_Create";
        public const string ShopDelete = "sp_Shop_Delete";
        public const string ShopGetById = "sp_Shop_Get_By_Id";
        public const string ShopEdit = "sp_Shop_Edit";
        #endregion

        #region Roles
        public const string RoleCreate = "sp_Role_Create";
        public const string RoleDelete = "sp_Role_Delete";
        public const string RoleGetById = "sp_Role_Get_By_Id";
        public const string RoleEdit = "sp_Role_Edit";
        #endregion

        #region Employees
        public const string EmployeeDelete = "sp_Employee_Delete";
        public const string EmployeeCreate = "sp_Employee_Create";
        public const string EmployeeGetById = "sp_Employee_Get_By_Id";
        public const string EmployeeEdit = "sp_Employee_Edit";
        #endregion

        #region Categories
        public const string CategoryDelete = "sp_Category_Delete";
        public const string CategoryCreate = "sp_Category_Create";
        public const string CategoryGetById = "sp_Category_Get_By_Id";
        public const string CategoryEdit = "sp_Category_Edit";
        #endregion

        #region Products
        public const string ProductDelete = "sp_Product_Delete";
        public const string ProductCreate = "sp_Product_Create";
        public const string ProductGetById = "sp_Product_Get_By_Id";
        public const string ProductEdit = "sp_Product_Edit";
        #endregion

        #region Purchases
        public const string PurchaseDelete = "sp_Purchase_Cancel";
        public const string PurchaseCreate = "sp_Purchase_Make";
        public const string PurchaseGetById = "sp_Purchase_Get_By_Id";
        public const string PurchaseEdit = "sp_Purchase_Edit";
        #endregion
    }
}
