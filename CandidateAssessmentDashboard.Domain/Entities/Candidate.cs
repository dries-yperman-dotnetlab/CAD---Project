using CandidateAssessmentDashboard.Domain.Common;

namespace CandidateAssessmentDashboard.Domain.Entities
{
    public class Candidate : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public BelbinTest? BelbinTest { get; set; } // Reference navigation to dependent
        public TeamworkPersonaTest? TeamworkPersonaTest { get; set; } // Reference navigation to dependent
    }
}
