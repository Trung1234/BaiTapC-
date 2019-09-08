using System;
using System.Collections.Generic;
using System.Text;

namespace AutomapperExampler.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Address Address { get; set; }
        public string Department { get; set; }
    }

}
