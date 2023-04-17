using CandidateAssessmentDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Domain.Entities
{
    public class Recruiter : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}
