using Dapper;
using MISA.WebFresher022023.Common.Entities;
using MISA.WebFresher022023.Common.Entities.DTO.Resources;
using MISA.WebFresher022023.DL.EmployeeDL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher022023.DL.BaseDL
{
    public class BaseDL<T> : IBaseDL<T>
    {
        protected readonly string connectionString = ResourceApi.ConnectionDatabase;
        protected MySqlConnection sqlConnection;

        /// <summary>
        /// Thêm bản ghi mới
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public int AddRecord(T record)
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                var className = typeof(T).Name;
                // 2. Thực hiện thêm mới dữ liệu
                // 2.1. Câu lệnh truy vấn thêm dữ liệu
                var sqlCommandText = "Proc_" + className + "_Insert";
                // Mở kết nối đến database
                sqlConnection.Open();
                // Đọc các tham số đầu vào của Store
                var sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = sqlCommandText;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                MySqlCommandBuilder.DeriveParameters(sqlCommand);

                // Tạo mới EmployeeId
                PropertyInfo IdInfo = record.GetType().GetProperty(className + "Id");
                if (IdInfo != null && IdInfo.CanWrite)
                {
                    IdInfo.SetValue(record, Guid.NewGuid());
                }
                //employee.EmployeeId = Guid.NewGuid();
                var dynamicParam = new DynamicParameters();
                foreach (MySqlParameter param in sqlCommand.Parameters)
                {
                    // tên tham số
                    var paramName = param.ParameterName;
                    var propName = paramName.Replace("@m_", "");
                    var entityProperty = record.GetType().GetProperty(propName);
                    if (entityProperty != null)
                    {
                        var propValue = record.GetType().GetProperty(propName).GetValue(record);
                        // Gán giá trị cho các param
                        dynamicParam.Add(paramName, propValue);
                    }
                    else
                    {
                        dynamicParam.Add(paramName, null);
                    }
                }

                var res = sqlConnection.Execute(sql: sqlCommandText, param: dynamicParam, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }

        /// <summary>
        /// Xóa nhiều bản ghi
        /// </summary>
        /// <param name="recordIds"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public int DeleteRecords(Guid[] recordIds)
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                var className = typeof(T).Name;

                foreach (var recordId in recordIds)
                {
                    // 2. Lấy dữ liệu
                    // 2.1. Câu lệnh truy vấn xóa dữ liệu
                    var sqlCommandText = "Proc_" + className + "_Delete";
                    DynamicParameters parameters = new DynamicParameters();
                    string param = "@m_" + className + "Id";
                    parameters.Add(param, recordId);
                    // 2.2. Thực hiện xóa dữ liệu   
                    var employee = sqlConnection.QueryFirstOrDefault<Employee>(sql: sqlCommandText, param: parameters, commandType: System.Data.CommandType.StoredProcedure);

                }
                // Trả kết quả cho Client
                return 1;
            }
        }


        /// <summary>
        /// Lấy thông tin bản ghi theo Id
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public T GetRecordById(Guid recordId)
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                var className = typeof(T).Name;

                // 2. Lấy dữ liệu
                // 2.1. Câu lệnh truy vấn lấy dữ liệu
                var sqlCommandText = "Proc_" + className + "_GetById";
                DynamicParameters parameters = new DynamicParameters();
                string param = "@m_" + className + "Id";
                parameters.Add(param, recordId);
                // 2.2. Thực hiện lấy dữ liệu   
                var record = sqlConnection.QueryFirstOrDefault<T>(sql: sqlCommandText, param: parameters, commandType: System.Data.CommandType.StoredProcedure);
                // Trả kết quả cho Client
                return record;
            }
        }

        /// <summary>
        /// Lấy danh sách bản ghi
        /// </summary>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public IEnumerable<T> GetRecords()
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                var className = typeof(T).Name;

                var sqlCommandText = "Proc_" + className + "_GetAll";
                // Mở kết nối đến database
                sqlConnection.Open();
                // 2. Lấy dữ liệu
                // 2.1. Câu lệnh truy vấn lấy dữ liệu
                var employees = sqlConnection.Query<T>(sql: sqlCommandText, commandType: System.Data.CommandType.StoredProcedure);
                // 2.2. Thực hiện lấy dữ liệu   
                // Trả kết quả cho Client
                return employees;
            }
        }

        /// <summary>
        /// Cập nhật thông tin bản ghi 
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public int UpdateRecord(T record)
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                var className = typeof(T).Name;

                // 2. Thực hiện update dữ liệu
                // 2.1. Câu lệnh truy vấn update dữ liệu
                var sqlCommandText = "Proc_" + className + "_Update";
                // Mở kết nối đến database
                sqlConnection.Open();
                // Đọc các tham số đầu vào của Store
                var sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = sqlCommandText;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                MySqlCommandBuilder.DeriveParameters(sqlCommand);
                var dynamicParam = new DynamicParameters();
                foreach (MySqlParameter param in sqlCommand.Parameters)
                {
                    // tên tham số
                    var paramName = param.ParameterName;
                    var propName = paramName.Replace("@m_", "");
                    var entityProperty = record.GetType().GetProperty(propName);
                    if (entityProperty != null)
                    {
                        var propValue = record.GetType().GetProperty(propName).GetValue(record);
                        // Gán giá trị cho các param
                        dynamicParam.Add(paramName, propValue);
                    }
                    else
                    {
                        dynamicParam.Add(paramName, null);
                    }
                }

                var res = sqlConnection.Execute(sql: sqlCommandText, param: dynamicParam, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
    }
}
