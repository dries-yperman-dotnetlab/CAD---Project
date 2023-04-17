using CandidateAssessmentDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Domain.Entities
{
    public class Notification : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public bool IsRead { get; set; } = false;

        public Guid CandidateId { get; set; } // Required foreign key property
        public Candidate Candidate { get; set; } = null!; // Required reference navigation to candidate
    }
}
