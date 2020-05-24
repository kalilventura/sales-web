using System;

namespace SalesWeb.Domain.DTO
{
    public class SellerDto : BaseDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }        
        public string DepartmentId { get; set; }
    }
}