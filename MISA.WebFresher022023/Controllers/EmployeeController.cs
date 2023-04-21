using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Dapper;
using System.Runtime.Versioning;
using MISA.WebFresher022023.DL.EmployeeDL;
using MISA.WebFresher022023.BL.EmployeeBL;
using MISA.WebFresher022023.Common.Entities;
using MISA.WebFresher022023.Common.Exceptions;
using MISA.WebFresher022023.Common.Entities.DTO;
using MISA.WebFresher022023.Common.Entities.DTO.Resources;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MISA.WebFresher022023.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeeController : BaseController<Employee>
    {
        IEmployeeBL _employeeBL;
        public EmployeeController(IEmployeeBL employeeBL):base(employeeBL)
        {
            _employeeBL = employeeBL;
        }

        /// <summary>
        /// Lấy mã nhân viên mới
        /// </summary>
        /// <returns></returns>
        [HttpGet("employeeCode")]
        public IActionResult GetEmployeeCOde()
        {
            try
            {
                // 2.2. Thực hiện lấy dữ liệu   
                var employeeCode = _employeeBL.GetEmployeeCode();
                // Trả kết quả cho Client
                return Ok(employeeCode);

            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        /// <summary>
        /// Lấy danh sách nhân viên
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        //[HttpGet]
        //public IActionResult GetEmployees()
        //{
        //    try
        //    {
        //        // 2.2. Thực hiện lấy dữ liệu   
        //        var employees = _employeeBL.GetEmployees();
        //        // Trả kết quả cho Client
        //        return Ok(employees);

        //    } catch (Exception ex)
        //    {
        //        return HandleException(ex);
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

        //[HttpGet("{employeeId}")]
        //public IActionResult GetEmployeeById(Guid employeeId)
        //{
        //    try
        //    {
        //        // 2.2. Thực hiện lấy dữ liệu   
        //        var employee = _employeeBL.GetEmployeeById(employeeId);
        //        // Trả kết quả cho Client
        //        return Ok(employee);

        //    } catch (Exception ex) {
        //        return HandleException(ex);
        //    }
        //}

        /// <summary>
        /// Thêm mới nhân viên
        /// </summary>
        /// <param name="employee">thông tin nhân viên</param>
        /// <returns>
        /// 201-Thêm mới thành công
        /// 400 - Dữ liệu đầu vào không hợp lệ
        /// 500 - Có exception
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        //[HttpPost]
        //public IActionResult Post(Employee employee)
        //{
        //    try
        //    {
        //        var res = _employeeBL.AddEmployee(employee);
        //        // 4. Trả thông tin về
        //        if (res > 0)
        //        {
        //            return StatusCode(201, employee.EmployeeId);
        //        } return Ok(res);
                
        //    }
        //    catch (MValidateException ex1)
        //    {
        //        return StatusCode(500, ex1.Message);
        //    }
        //    catch (Exception ex2)
        //    {

        //        return HandleException(ex2);
        //    }
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
        //[HttpPut]
        //public IActionResult Put(Employee employee)
        //{
        //    try
        //    {
        //        var res = _employeeBL.UpdateEmployee(employee);

        //        // 4. Trả thông tin về
        //        if (res > 0)
        //        {
        //            return StatusCode(201);
        //        }
        //        return Ok(res);

        //    }
        //    catch (MValidateException ex1)
        //    {
        //        return StatusCode(500, ex1.Message);

        //    }
        //    catch (Exception ex2)
        //    {

        //        return HandleException(ex2);
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

        //[HttpDelete]
        //public IActionResult DeleteEmployeeById([FromBody] string employeeIds)
        //{
        //    try
        //    {
        //        var res = _employeeBL.DeleteEmployee(employeeIds);
        //        // Trả kết quả cho Client
        //        return StatusCode(201);

        //    }
        //    catch (Exception ex)
        //    {

        //        return HandleException(ex);
        //    }
        //}

        /// <summary>
        /// bắt lỗi để trả về
        /// </summary>
        /// By: NTTrang
        /// date: 8/4/2023
        //private IActionResult HandleException(Exception ex)
        //{
        //    var error = new ErrorService();
        //    error.DevMsg = ex.Message;
        //    error.UserMsg = ResourceVN.Error_Exception;
        //    error.Data = ex.Data;

        //    return StatusCode(500, error);
        //}

    }


}
