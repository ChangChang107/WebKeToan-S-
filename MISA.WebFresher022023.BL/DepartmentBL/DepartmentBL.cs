using MISA.WebFresher022023.DL.DepartmentDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MISA.WebFresher022023.Common.Entities;
using MISA.WebFresher022023.BL.BaseBL;

namespace MISA.WebFresher022023.BL.DepartmentBL
{
    public class DepartmentBL : BaseBL<Department>, IDepartmentBL
    {
        IDepartmentDL _departmentDL;
        public DepartmentBL(IDepartmentDL departmentDL):base(departmentDL)
        {
            _departmentDL = departmentDL;
        }

        /// <summary>
        /// Lấy danh sách Department
        /// </summary>
        /// <returns>
        /// Danh sách Department
        /// </returns>
        //public IEnumerable<Department> GetDepartments()
        //{
        //    return _departmentDL.GetDepartments();
        //}

        /// <summary>
        /// Lấy thông tin Department theo Id
        /// </summary>
        /// <param name="DepartmentId"></param>
        /// <returns>
        /// Department theo id
        /// </returns>
        //public Department GetDepartmentById(Guid DepartmentId)
        //{
        //    return _departmentDL.GetDepartmentById(DepartmentId);
        //}
    }
}
