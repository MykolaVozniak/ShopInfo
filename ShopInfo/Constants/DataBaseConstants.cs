using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace ShopInfo.Constants
{
    public class DataBaseConstants
    {
        private const string ConnectionString = "Data Source=DESKTOP-UNRBAFF\\SQLEXPRESS;Initial Catalog=TumbleweedDB;Persist Security Info=True;User ID=sa;Password=mykola228";

        public static SqlConnection GetConnection()
            => new(ConnectionString);
        //New
        public const string GetRecords = "sp_Get_Records";

        public const string UserAdd = "sp_User_Add";
        public const string UserDelete = "sp_User_Delete";

        //Old
        #region Users

        public const string UserEdit = "sp_User_Edit";
        public const string UserInfo = "sp_User_Info";
        #endregion

        #region Categories
        public const string CategoryDelete = "sp_Category_Delete";
        public const string CategoryCreate = "sp_Category_Create";
        public const string CategoryEdit = "sp_Category_Edit";
        #endregion

        #region Products
        public const string ProductDelete = "sp_Product_Delete";
        public const string ProductCreate = "sp_Product_Create";
        public const string ProductEdit = "sp_Product_Edit";
        #endregion

        #region Purchases
        public const string PurchaseDelete = "sp_Purchase_Cancel";
        public const string PurchaseCreate = "sp_Purchase_Make";
        public const string PurchaseEdit = "sp_Purchase_Edit";
        #endregion

        #region Roles
        public const string RoleDelete = "sp_Role_Delete";
        public const string RoleCreate = "sp_Role_Create";
        public const string RoleEdit = "sp_Role_Edit";
        #endregion

        #region Shops
        public const string ShopDelete = "sp_Shop_Delete";
        public const string ShopCreate = "sp_Shop_Create";
        public const string ShopEdit = "sp_Shop_Edit";
        #endregion

        #region Employees
        public const string EmployeeDelete = "sp_Employee_Delete";
        public const string EmployeeCreate = "sp_Employee_Create";
        public const string EmployeeEdit = "sp_Employee_Edit";
        #endregion


    }
}
