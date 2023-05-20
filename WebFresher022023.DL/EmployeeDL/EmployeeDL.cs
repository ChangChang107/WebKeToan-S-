using MISA.WebFresher022023.Common.Entities;
using MISA.WebFresher022023.Common.Entities.DTO.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using MISA.WebFresher022023.DL.BaseDL;

namespace MISA.WebFresher022023.DL.EmployeeDL
{
    public class EmployeeDL : BaseDL<Employee>, IEmployeeDL
    {
        //private readonly string connectionString = ResourceApi.ConnectionDatabase;
        //protected MySqlConnection sqlConnection;

        /// <summary>
        /// Lấy danh sách nhân viên
        /// </summary>
        /// <returns>
        /// Danh sách nhân viên
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        //public IEnumerable<Employee> GetEmployees()
        //{
        //    using (sqlConnection = new MySqlConnection(connectionString))
        //    {
        //        var sqlCommandText = "Proc_Employee_GetAll";
        //        // Mở kết nối đến database
        //        sqlConnection.Open();
        //        // 2. Lấy dữ liệu
        //        // 2.1. Câu lệnh truy vấn lấy dữ liệu
        //        var employees = sqlConnection.Query<Employee>(sql: sqlCommandText, commandType: System.Data.CommandType.StoredProcedure);
        //        // 2.2. Thực hiện lấy dữ liệu   
        //        // Trả kết quả cho Client
        //        return employees;
        //    }
        //}

        /// <summary>
        /// Lấy thông tin nhân viên theo id
        /// </summary>
        /// <param name="employeeId">id nhân viên</param>
        /// <returns>
        /// Thông tin nhân viên
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        //public Employee GetEmployeeById(Guid employeeId)
        //{
        //    using (sqlConnection = new MySqlConnection(connectionString)) 
        //    {
        //        // 2. Lấy dữ liệu
        //        // 2.1. Câu lệnh truy vấn lấy dữ liệu
        //        var sqlCommandText = "Proc_Employee_GetById";
        //        DynamicParameters parameters = new DynamicParameters();
        //        parameters.Add("@m_EmployeeId", employeeId);
        //        // 2.2. Thực hiện lấy dữ liệu   
        //        var employee = sqlConnection.QueryFirstOrDefault<Employee>(sql: sqlCommandText, param: parameters, commandType: System.Data.CommandType.StoredProcedure);
        //        // Trả kết quả cho Client
        //        return employee;
        //    }
        //}

        /// <summary>
        /// Thêm mới nhân viên
        /// </summary>
        /// <param name="employee">thông tin nhân viên</param>
        /// <returns>
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        //public int AddEmployee(Employee employee)
        //{
        //    using (sqlConnection = new MySqlConnection(connectionString))
        //    {
        //        // 2. Thực hiện thêm mới dữ liệu
        //        // 2.1. Câu lệnh truy vấn thêm dữ liệu
        //        var sqlCommandText = "Proc_Employee_Insert";
        //        // Mở kết nối đến database
        //        sqlConnection.Open();
        //        // Đọc các tham số đầu vào của Store
        //        var sqlCommand = sqlConnection.CreateCommand();
        //        sqlCommand.CommandText = sqlCommandText;
        //        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        MySqlCommandBuilder.DeriveParameters(sqlCommand);

        //        // Tạo mới EmployeeId
        //        employee.EmployeeId = Guid.NewGuid();
        //        var dynamicParam = new DynamicParameters();
        //        foreach (MySqlParameter param in sqlCommand.Parameters)
        //        {
        //            // tên tham số
        //            var paramName = param.ParameterName;
        //            var propName = paramName.Replace("@m_", "");
        //            var entityProperty = employee.GetType().GetProperty(propName);
        //            if (entityProperty != null)
        //            {
        //                var propValue = employee.GetType().GetProperty(propName).GetValue(employee);
        //                // Gán giá trị cho các param
        //                dynamicParam.Add(paramName, propValue);
        //            }
        //            else
        //            {
        //                dynamicParam.Add(paramName, null);
        //            }
        //        }

        //        var res = sqlConnection.Execute(sql: sqlCommandText, param: dynamicParam, commandType: System.Data.CommandType.StoredProcedure);
        //        return res;
        //    }
        //}

        /// <summary>
        /// Sửa thông tin nhân viên
        /// </summary>
        /// <param name="employee">thông tin nhân viên sau khi sửas</param>
        /// <returns>
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        //public int UpdateEmployee(Employee employee)
        //{
        //    using (sqlConnection = new MySqlConnection(connectionString))
        //    {

        //        // 2. Thực hiện update dữ liệu
        //        // 2.1. Câu lệnh truy vấn update dữ liệu
        //        var sqlCommandText = "Proc_Employee_Update";
        //        // Mở kết nối đến database
        //        sqlConnection.Open();
        //        // Đọc các tham số đầu vào của Store
        //        var sqlCommand = sqlConnection.CreateCommand();
        //        sqlCommand.CommandText = sqlCommandText;
        //        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        MySqlCommandBuilder.DeriveParameters(sqlCommand);
        //        var dynamicParam = new DynamicParameters();
        //        foreach (MySqlParameter param in sqlCommand.Parameters)
        //        {
        //            // tên tham số
        //            var paramName = param.ParameterName;
        //            var propName = paramName.Replace("@m_", "");
        //            var entityProperty = employee.GetType().GetProperty(propName);
        //            if (entityProperty != null)
        //            {
        //                var propValue = employee.GetType().GetProperty(propName).GetValue(employee);
        //                // Gán giá trị cho các param
        //                dynamicParam.Add(paramName, propValue);
        //            }
        //            else
        //            {
        //                dynamicParam.Add(paramName, null);
        //            }
        //        }

        //        var res = sqlConnection.Execute(sql: sqlCommandText, param: dynamicParam, commandType: System.Data.CommandType.StoredProcedure);
        //        return res;
        //    }
        //}

        /// <summary>
        /// Xóa thông tin nhân viên theo id
        /// </summary>
        /// <param name="employeeId">id nhân viên</param>
        /// <returns>
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        //public int DeleteEmployee(Guid[] employeeIds)
        //{
        //    using (sqlConnection = new MySqlConnection(connectionString))
        //    {
        //        foreach (var employeeId in employeeIds)
        //        {
        //            // 2. Lấy dữ liệu
        //            // 2.1. Câu lệnh truy vấn xóa dữ liệu
        //            var sqlCommandText = "Proc_Employee_Delete";
        //            DynamicParameters parameters = new DynamicParameters();
        //            parameters.Add("@m_EmployeeId", employeeId);
        //            // 2.2. Thực hiện xóa dữ liệu   
        //            var employee = sqlConnection.QueryFirstOrDefault<Employee>(sql: sqlCommandText, param: parameters, commandType: System.Data.CommandType.StoredProcedure);

        //        }
        //        // Trả kết quả cho Client
        //        return 1;
        //    }
        //}


        /// <summary>
        /// Kiểm tra mã nhân viên có trùng không
        /// </summary>
        /// <param name="employeeCode">Mã nhân viên</param>
        /// <returns>
        /// true - bị trùng
        /// false - không bị trùng
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        public bool CheckEmployeeCode(Employee employee)
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                var employeeCode = employee.EmployeeCode;
                var employeeId = employee.EmployeeId;
                var sqlCommandText = "Proc_Employee_CheckEmployeeCode";
                var dynamicParams = new DynamicParameters();
                dynamicParams.Add("@EmployeeCode", employeeCode);
                dynamicParams.Add("@EmployeeId", employeeId);
                var res = sqlConnection.QueryFirstOrDefault<String>(sqlCommandText, param: dynamicParams, commandType: System.Data.CommandType.StoredProcedure);

                if (res == null)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// tạo mã nhân viên mới
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string GetEmployeeCode()
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                var sqlCommandText = "Proc_Employee_GetNewEmployeeCode";
                var res = sqlConnection.QueryFirstOrDefault<String>(sqlCommandText, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
    }
}
