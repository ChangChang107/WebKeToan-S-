namespace MISA.WebFresher022023.Common.Entities
{
    /// <summary>
    /// Mô tả: Khai báo các thuộc tính
    /// Created by: nttrang
    /// Created date: 11/4/2023
    /// </summary>
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public int? Gender { get; set; }
        public string? GenderName {
            get
            {
                switch (Gender)
                {

                    case 1:
                        return "Nam";
                    case 2:
                        return "Nữ";
                    default:
                        return "Không xác định";
                }
            }
        }
        public string? PhoneNumber { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? Email { get; set; }
        public string? IdentityNumber { get; set; }
        public DateTime? IdentityDate { get; set; }
        public string? IdentityPlace { get; set; }
        public string? BankAcount { get; set; }
        public string? BankName { get; set; }
        public string? BankBranch { get; set; }
        public string? TaxCode { get; set; }
        public byte? IsEmployee { get; set; }
        public byte? IsCustomer { get; set; }
        public DateTime? JoinDate { get; set; }
        public decimal? Salary { get; set; }
        public string? Position { get; set; }
        public Guid? DepartmentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }

    }
}
