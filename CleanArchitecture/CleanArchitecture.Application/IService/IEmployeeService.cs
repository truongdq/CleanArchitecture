using CleanArchitecture.Application.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.IService
{
    public partial interface IService
    {
        Task<bool> Insert(EmployeeWriteModel model);
    }
}
