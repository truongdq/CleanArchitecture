using CleanArchitecture.Application.Model.EmployeeModel;
using CleanArchitecture.Data.Entities;
using CleanArchitecture.Domain.Enums;
using CleanArchitecture.Domain.Helpers;
using System;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Service
{
    public partial class Service
    {
        public async Task<bool> Insert(EmployeeWriteModel model)
        {
            if (model == null) throw new Exception("Tham số là bắt buộc");

            Employee employee = new Employee()
            {
                Birthday = ConvertDateTime.ConvertToDateTime(model.Birthday),
                FullName = model.FullName,
                CreatedDate = DateTime.Now,
                Status = (int)EStatusRecord.Active
            };

            return await _employeeRepository.Insert(employee);
        }
    }
}
