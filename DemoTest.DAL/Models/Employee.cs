using System;
using System.Collections.Generic;

namespace DemoTest.DAL.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string? Address { get; set; }
        public decimal Phone { get; set; }
    }
}
