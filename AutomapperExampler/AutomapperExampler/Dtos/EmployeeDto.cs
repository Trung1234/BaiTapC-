using System;
using System.Collections.Generic;
using System.Text;

namespace AutomapperExampler.Dtos
{
    public class EmployeeDTO
    {
        public string FullName { get; set; }
        public int Salary { get; set; }
        public AddressDTO AddressDTO { get; set; }
        public string Department { get; set; }
    }
}
