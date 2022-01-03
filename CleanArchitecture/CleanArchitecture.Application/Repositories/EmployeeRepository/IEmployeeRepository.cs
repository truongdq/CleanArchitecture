using CleanArchitecture.Application.Model.EmployeeModel;
using CleanArchitecture.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository
    {
        Task<bool> Insert(Employee employee);
    }
}
