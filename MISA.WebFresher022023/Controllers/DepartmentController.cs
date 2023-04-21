using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.WebFresher022023.BL.DepartmentBL;
using MISA.WebFresher022023.BL.EmployeeBL;
using MISA.WebFresher022023.Common.Entities.DTO.Resources;
using MISA.WebFresher022023.Common.Entities.DTO;
using MISA.WebFresher022023.Common.Entities;

namespace MISA.WebFresher022023.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DepartmentController : BaseController<Department>
    {
        IDepartmentBL _departmentBL;
        public DepartmentController(IDepartmentBL departmentBL):base(departmentBL) 
        {
            _departmentBL = departmentBL;
        }


        /// <summary>
        /// Lấy danh sách phòng ban
        /// </summary>
        /// <returns>
        /// Danh sách phòng ban
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        //[HttpGet]
        //public IActionResult GetDepartments()
        //{
        //    try
        //    {
        //        // 2.2. Thực hiện lấy dữ liệu   
        //        var departments = _departmentBL.GetDepartments();
        //        // Trả kết quả cho Client
        //        return Ok(departments);

        //    }
        //    catch (Exception ex)
        //    {
        //        return HandleException(ex);
        //    }

        //}

        /// <summary>
        /// Lấy thông tin phòng ban theo id
        /// </summary>
        /// <param name="DepartmentId">id phòng ban</param>
        /// <returns>
        /// Thông tin phòng ban
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023

        //[HttpGet("{DepartmentId}")]
        //public IActionResult GetDepartmentId(Guid DepartmentId)
        //{
        //    try
        //    {
        //        // 2.2. Thực hiện lấy dữ liệu   
        //        var department = _departmentBL.GetDepartmentById(DepartmentId);
        //        // Trả kết quả cho Client
        //        return Ok(department);

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
