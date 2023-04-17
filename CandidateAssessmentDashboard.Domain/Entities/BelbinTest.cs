using CandidateAssessmentDashboard.Domain.Common;

namespace CandidateAssessmentDashboard.Domain.Entities
{
    public class BelbinTest : AuditableEntity, Test
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = string.Empty;

        public Guid CandidateId { get; set; } // Required foreign key property
        public Candidate Candidate { get; set; } = null!; // Required reference navigation to candidate
    }
}
