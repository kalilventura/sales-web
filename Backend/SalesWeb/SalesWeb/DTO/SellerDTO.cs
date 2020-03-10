using System;

namespace SalesWeb.DTO
{
    public class SellerDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public int DepartmentId { get; set; }
    }
}
