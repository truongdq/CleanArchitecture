using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Domain.Entites
{
    public class AuditableEntity
    {
        public int Id { get; set; }

        public string CreatedUsername { get; set; }

        public string CreatedFullName { get; set; }

        public int CreatedDate { get; set; }

        public string ModifiedUsername { get; set; }

        public string ModifiedFullName { get; set; }

        public int? ModifiedDate { get; set; }

        public EStatusRecord Status { get; set; }
    }
}
