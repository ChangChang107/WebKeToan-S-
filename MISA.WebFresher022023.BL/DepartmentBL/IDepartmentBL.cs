﻿using MISA.WebFresher022023.DL.DepartmentDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MISA.WebFresher022023.Common.Entities;
using MISA.WebFresher022023.BL.BaseBL;

namespace MISA.WebFresher022023.BL.DepartmentBL
{
    public interface IDepartmentBL : IBaseBL<Department>
    {
        /// <summary>
        /// Lấy danh sách Department
        /// </summary>
        /// <returns></returns>
        //public IEnumerable<Department> GetDepartments();

        /// <summary>
        /// Lấy thông tin Department theo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //public Department GetDepartmentById(Guid DepartmentId);
    }
}
