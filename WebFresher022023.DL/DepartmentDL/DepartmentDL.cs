using Dapper;
using MISA.WebFresher022023.Common.Entities;
using MISA.WebFresher022023.Common.Entities.DTO.Resources;
using MISA.WebFresher022023.DL.BaseDL;
using MISA.WebFresher022023.DL.EmployeeDL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher022023.DL.DepartmentDL
{
    public class DepartmentDL : BaseDL<Department>, IDepartmentDL
    {

        /// <summary>
        /// Lấy danh sách Department
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        //public IEnumerable<Department> GetDepartments()
        //{
        //    using (sqlConnection = new MySqlConnection(connectionString))
        //    {
        //        var sqlCommandText = "Proc_Department_GetAll";
        //        // Mở kết nối đến database
        //        sqlConnection.Open();
        //        // 2. Lấy dữ liệu
        //        // 2.1. Câu lệnh truy vấn lấy dữ liệu
        //        var departments = sqlConnection.Query<Department>(sql: sqlCommandText, commandType: System.Data.CommandType.StoredProcedure);
        //        // 2.2. Thực hiện lấy dữ liệu   
        //        // Trả kết quả cho Client
        //        return departments;
        //    }
        //}


        /// <summary>
        /// Lấy thông tin Department theo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        //public Department GetDepartmentById(Guid DepartmentId)
        //{
        //    using (sqlConnection = new MySqlConnection(connectionString))
        //    {
        //        // 2. Lấy dữ liệu
        //        // 2.1. Câu lệnh truy vấn lấy dữ liệu
        //        var sqlCommandText = "Proc_Department_GetById";
        //        DynamicParameters parameters = new DynamicParameters();
        //        parameters.Add("@m_DepartmentId", DepartmentId);
        //        // 2.2. Thực hiện lấy dữ liệu   
        //        var department = sqlConnection.QueryFirstOrDefault<Department>(sql: sqlCommandText, param: parameters, commandType: System.Data.CommandType.StoredProcedure);
        //        // Trả kết quả cho Client
        //        return department;
        //    }
        //}
    }
}
