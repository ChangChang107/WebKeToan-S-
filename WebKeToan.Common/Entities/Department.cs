﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher022023.Common.Entities
{
    public class Department
    {
        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string? Description { get; set;}
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set;}
        public DateTime? ModifiedDate { get; set;}
        public string? ModifiedBy { get; set;}
    }
}
