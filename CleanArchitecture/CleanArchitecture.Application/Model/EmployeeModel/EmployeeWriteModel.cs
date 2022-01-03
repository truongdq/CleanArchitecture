using CleanArchitecture.Domain.Entites;

namespace CleanArchitecture.Application.Model.EmployeeModel
{
    public class EmployeeWriteModel : AuditableEntity
    {
        public int Birthday { get; set; }

        public string FullName { get; set; }
    }
}
