using AutoMapper;
using AutomapperExampler.Dtos;
using AutomapperExampler.Models;
using System;

namespace AutomapperExampler
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeMapper();
            // Create object
            var empAddres = new Address()
            {
                City = "Ha Noi",
    
                Country = "Viet Nam"
            };
            var employee = new Employee
            {
                Name = "Trung",
                Address = empAddres,
                Department = "IT",
                Salary = 1000
            };
            // Use Automapper to map Model to Dto
            var empDto = Mapper.Map<Employee, EmployeeDTO>(employee);

            Console.WriteLine("Name :" + empDto.FullName);
            Console.WriteLine("City :" + empDto.AddressDTO.City);
            Console.ReadLine();
        }

        private static void InitializeMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Address, AddressDTO>();
                cfg.CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.AddressDTO, act => act.MapFrom(src => src.Address));
            });

        }
    }
}
