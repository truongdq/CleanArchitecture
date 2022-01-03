using CleanArchitecture.Application.Repositories.EmployeeRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Service
{
    public partial class Service : IService.IService
    {
        public readonly IEmployeeRepository _employeeRepository;

        public Service(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
    }
}
