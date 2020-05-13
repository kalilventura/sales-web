﻿using System;
using System.Collections.Generic;

namespace SalesWeb.Domain.Entities
{
    public class Seller : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal BaseSalary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
            Department = new Department();
        }

        public Seller(string name, string email, DateTime birthDate, decimal baseSalary, Department department)
        {
            Department = new Department();
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
    }
}