﻿using MISA.WebFresher022023.BL.BaseBL;
using MISA.WebFresher022023.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher022023.BL.EmployeeBL
{
    public interface IEmployeeBL : IBaseBL<Employee>
    {
        /// <summary>
        /// Lấy thông tin nhân viên theo Id
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        //public Employee GetEmployeeById(Guid employeeId);

        /// <summary>
        /// Lấy danh sách nhân viên
        /// </summary>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        //public IEnumerable<Employee> GetEmployees();

        /// <summary>
        /// Thêm nhân viên mới
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        //public int AddEmployee(Employee employee);

        /// <summary>
        /// Cập nhật thông tin nhân viên 
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        //public int UpdateEmployee(Employee employee);

        /// <summary>
        /// Xóa nhân viên
        /// </summary>
        /// <param name="employeeIds"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        //public int DeleteEmployee(string employeeIds);

        /// <summary>
        /// Lấy mã nhân viên mới
        /// </summary>
        /// <returns></returns>
        public String GetEmployeeCode();
    }
}
