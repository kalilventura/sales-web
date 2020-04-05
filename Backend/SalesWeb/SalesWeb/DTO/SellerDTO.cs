using System;

namespace SalesWeb.DTO
{
    public class SellerDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal BaseSalary { get; set; }
        public int DepartmentId { get; set; }
    }
}
