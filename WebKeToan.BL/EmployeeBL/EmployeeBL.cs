using MISA.WebFresher022023.BL.BaseBL;
using MISA.WebFresher022023.Common.Entities;
using MISA.WebFresher022023.Common.Entities.DTO;
using MISA.WebFresher022023.Common.Entities.DTO.Resources;
using MISA.WebFresher022023.Common.Exceptions;
using MISA.WebFresher022023.DL.EmployeeDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher022023.BL.EmployeeBL
{
    public class EmployeeBL : BaseBL<Employee> ,IEmployeeBL
    {
        IEmployeeDL _employeeDL;
        public EmployeeBL(IEmployeeDL employeeDL):base(employeeDL)
        {
            _employeeDL = employeeDL;
        }

        protected override void ValidateData(Employee employee) {
            // Khai báo các thông tin cần thiết
            var error = new ErrorService();
            var errorData = new Dictionary<string, string>();

            // 1. Validate dữ liệu: Trả về mã 400 (BadRequest) kèm thông tin lỗi
            // 1.1 Mã nhân viên không được để trống
            if (string.IsNullOrEmpty(employee.EmployeeCode))
            {
                errorData.Add("EmployeeCode", ResourceVN.Error_ValidateEmployeeCode);
            }
            // 1.2 Họ và tên không được để trống
            if (string.IsNullOrEmpty(employee.FullName))
            {
                errorData.Add("FullName", ResourceVN.Error_ValidateFullName);
            }
            // 1.3 Đơn vị không được để trống

            // 1.4 Ngày sinh không được lớn hơn ngày hiện tại

            // 1.5 Mã nhân viên không được phép trùng nhau
            if (_employeeDL.CheckEmployeeCode(employee))
            {
                errorData.Add("EmployeeCOde", ResourceVN.Error_CheckEmployeeCode);
            }
            if (errorData.Count > 0)
            {
                error.UserMsg = ResourceVN.Error_ValidateData;
                error.Data = errorData;
                throw new MValidateException(error);
            }
        }

        /// <summary>
        /// Lấy mã nhân viên mới
        /// </summary>
        /// <returns>Mã nhân viên mới</returns>
        public String GetEmployeeCode()
        {
            return _employeeDL.GetEmployeeCode();
        }

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
        //    // Khai báo các thông tin cần thiết
        //    var error = new ErrorService();
        //    var errorData = new Dictionary<string, string>();

        //    // 1. Validate dữ liệu: Trả về mã 400 (BadRequest) kèm thông tin lỗi
        //    // 1.1 Mã nhân viên không được để trống
        //    if (string.IsNullOrEmpty(employee.EmployeeCode))
        //    {
        //        errorData.Add("EmployeeCode", ResourceVN.Error_ValidateEmployeeCode);
        //    }
        //    // 1.2 Họ và tên không được để trống
        //    if (string.IsNullOrEmpty(employee.FullName))
        //    {
        //        errorData.Add("FullName", ResourceVN.Error_ValidateFullName);
        //    }
        //    // 1.3 Đơn vị không được để trống

        //    // 1.4 Ngày sinh không được lớn hơn ngày hiện tại

        //    // 1.5 Mã nhân viên không được phép trùng nhau
        //    if (_employeeDL.CheckEmployeeCode(employee))
        //    {
        //        errorData.Add("EmployeeCOde", ResourceVN.Error_CheckEmployeeCode);
        //    }
        //    if (errorData.Count > 0)
        //    {
        //        error.UserMsg = ResourceVN.Error_ValidateData;
        //        error.Data = errorData;
        //        throw new MValidateException(error);
        //    }

        //    var res = _employeeDL.AddEmployee(employee);

        //    return res;

        //}

        /// <summary>
        /// Xóa thông tin nhân viên theo id
        /// </summary>
        /// <param name="employeeId">id nhân viên</param>
        /// <returns>
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        //public int DeleteEmployee(string employeeIds)
        //{
        //    // Chuyen chuoi thanh mang cac id
        //    Guid[] arrayEmployeeIds = EmployeeBL.ConvertStringToArray(employeeIds);

        //    // Xóa nhân viên
        //    var res = _employeeDL.DeleteEmployee(arrayEmployeeIds);
        //    return res;
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
        //    // Lấy thông tin nhân viên theo Id
        //    var res = _employeeDL.GetEmployeeById(employeeId);
        //    return res;
        //}


        /// <summary>
        /// Lấy danh sách nhân viên
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        //public IEnumerable<Employee> GetEmployees()
        //{
        //    // Lấy danh sách nhân viên 
        //    var res = _employeeDL.GetEmployees();
        //    return res;
        //}

        /// <summary>
        /// Sửa thông tin nhân viên
        /// </summary>
        /// <param name="employee">thông tin nhân viên sau khi sửas</param>
        /// <returns>
        /// 201-Sửa thông tin thành công
        /// 400 - Dữ liệu đầu vào không hợp lệ
        /// 500 - Có exception
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        //public int UpdateEmployee(Employee employee)
        //{
        //    // Khai báo các thông tin cần thiết
        //    var error = new ErrorService();
        //    var errorData = new Dictionary<string, string>();

        //    // 1. Validate dữ liệu: Trả về mã 400 (BadRequest) kèm thông tin lỗi
        //    // 1.1 Mã nhân viên không được để trống
        //    if (string.IsNullOrEmpty(employee.EmployeeCode))
        //    {
        //        errorData.Add("EmployeeCode", ResourceVN.Error_ValidateEmployeeCode);
        //    }
        //    // 1.2 Họ và tên không được để trống
        //    if (string.IsNullOrEmpty(employee.FullName))
        //    {
        //        errorData.Add("FullName", ResourceVN.Error_ValidateFullName);
        //    }
        //    // 1.3 Đơn vị không được để trống

        //    // 1.4 Ngày sinh không được lớn hơn ngày hiện tại

        //    // 1.5 Mã nhân viên không được phép trùng nhau
        //    if (_employeeDL.CheckEmployeeCode(employee))
        //    {
        //        errorData.Add("EmployeeCOde", ResourceVN.Error_CheckEmployeeCode);
        //    }
        //    if (errorData.Count > 0)
        //    {
        //        error.UserMsg = ResourceVN.Error_ValidateData;
        //        error.Data = errorData;
        //        throw new MValidateException(error);
        //    }

        //    var res = _employeeDL.UpdateEmployee(employee);

        //    return res;
        //}

        /// <summary>
        /// Ham tach chuoi thanh mang cac phan tu co kieu du lieu Guid
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        //public static Guid[] ConvertStringToArray(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //    {
        //        return new Guid[0];
        //    }

        //    int inputLength = input.Length;
        //    int arrayLength = (inputLength + 35) / 36;
        //    Guid[] result = new Guid[arrayLength];

        //    for (int i = 0; i < arrayLength; i++)
        //    {
        //        int startIndex = i * 36;
        //        int length = Math.Min(36, inputLength - startIndex);
        //        result[i] = Guid.Parse(input.Substring(startIndex, length));
        //    }

        //    return result;
        //}

    } 
}

