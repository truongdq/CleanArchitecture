using CleanArchitecture.Application.Repositories.EmployeeRepository;
using CleanArchitecture.Data;
using CleanArchitecture.Data.Entities;
using CleanArchitecture.Infrastructure.Interfaces;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.EmployeeRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly IUnitOfWork<CleanArchitectureContext> _unitOfWork;

        public EmployeeRepository(IUnitOfWork<CleanArchitectureContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Insert(Employee employee)
        {
            await _unitOfWork.Repository<Employee>().Insert(employee);
            return await _unitOfWork.Commit();
        }
    }
}
