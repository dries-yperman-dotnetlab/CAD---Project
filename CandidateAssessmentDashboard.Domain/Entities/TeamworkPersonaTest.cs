using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateAssessmentDashboard.Domain.Common;

namespace CandidateAssessmentDashboard.Domain.Entities
{
    public class TeamworkPersonaTest : AuditableEntity, Test
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = string.Empty;

        public Guid CandidateId { get; set; }
        public Candidate Candidate { get; set; } = null!;
    }
}
