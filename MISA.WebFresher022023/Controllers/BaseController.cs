using Microsoft.AspNetCore.Mvc;
using MISA.WebFresher022023.BL.BaseBL;
using MISA.WebFresher022023.Common.Entities.DTO.Resources;
using MISA.WebFresher022023.Common.Entities.DTO;
using MISA.WebFresher022023.DL.BaseDL;
using MISA.WebFresher022023.Common.Entities;
using MISA.WebFresher022023.Common.Exceptions;

namespace MISA.WebFresher022023.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase
    {
        IBaseBL<T> _baseBL;

        public BaseController(IBaseBL<T> baseBL)
        {
            _baseBL = baseBL;
        }


        /// <summary>
        /// Lấy danh sách bản ghi
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        [HttpGet]
        public IActionResult GetRecords()
        {
            try
            {
                // 2.2. Thực hiện lấy dữ liệu   
                var records = _baseBL.GetRecords();
                // Trả kết quả cho Client
                return Ok(records);

            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }

        }

        /// <summary>
        /// Lấy thông tin bản ghi theo id
        /// </summary>
        /// <param name="employeeId">id nhân viên</param>
        /// <returns>
        /// Thông tin nhân viên
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023

        [HttpGet("{recordId}")]
        public IActionResult GetById(Guid recordId)
        {
            try
            {
                // 2.2. Thực hiện lấy dữ liệu   
                var record = _baseBL.GetRecordById(recordId);
                // Trả kết quả cho Client
                return Ok(record);

            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        /// <summary>
        /// Thêm mới bản ghi
        /// </summary>
        /// <param name="record">thông tin bản ghi</param>
        /// <returns>
        /// 201-Thêm mới thành công
        /// 400 - Dữ liệu đầu vào không hợp lệ
        /// 500 - Có exception
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        [HttpPost]
        public IActionResult Post(T record)
        {
            try
            {
                var res = _baseBL.AddRecord(record);
                // 4. Trả thông tin về
                if (res > 0)
                {
                    return StatusCode(201);
                }
                return Ok(res);

            }
            catch (MValidateException ex1)
            {
                return StatusCode(500, ex1.Message);
            }
            catch (Exception ex2)
            {

                return HandleException(ex2);
            }
        }

        /// <summary>
        /// Sửa thông tin bản ghi
        /// </summary>
        /// <param name="record">thông tin nhân viên sau khi sửas</param>
        /// <returns>
        /// 201-Sửa thông tin thành công
        /// 400 - Dữ liệu đầu vào không hợp lệ
        /// 500 - Có exception
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023
        [HttpPut]
        public IActionResult Put(T record)
        {
            try
            {
                var res = _baseBL.UpdateRecord(record);

                // 4. Trả thông tin về
                if (res > 0)
                {
                    return StatusCode(201);
                }
                return Ok(res);

            }
            catch (MValidateException ex1)
            {
                return StatusCode(500, ex1.Message);

            }
            catch (Exception ex2)
            {

                return HandleException(ex2);
            }
        }


        /// <summary>
        /// Xóa thông tin bản ghi theo id
        /// </summary>
        /// <param name="recordIds">id nhân viên</param>
        /// <returns>
        /// </returns>
        /// By: NTTrang
        /// date: 8/4/2023

        [HttpDelete]
        public IActionResult DeleteById([FromBody] string recordIds)
        {
            try
            {
                var res = _baseBL.DeleteRecords(recordIds);
                // Trả kết quả cho Client
                return StatusCode(201);

            }
            catch (Exception ex)
            {

                return HandleException(ex);
            }
        }


        /// <summary>
        /// bắt lỗi để trả về
        /// </summary>
        /// By: NTTrang
        /// date: 8/4/2023
        protected IActionResult HandleException(Exception ex)
        {
            var error = new ErrorService();
            error.DevMsg = ex.Message;
            error.UserMsg = ResourceVN.Error_Exception;
            error.Data = ex.Data;

            return StatusCode(500, error);
        }
    }
}
