using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWeb.Domain.Entities
{
    public class Seller : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public float BaseSalary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        //private ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(string name, string email, DateTime birthDate, float baseSalary, Department department)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        //public void AddSales(SalesRecord salesRecord)
        //{
        //    Sales.Add(salesRecord);
        //}

        //public void RemoveSales(SalesRecord salesRecord)
        //{
        //    Sales.Remove(salesRecord);
        //}

        //public double TotalSales(DateTime initial, DateTime final)
        //{
        //    return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        //}
    }
}
