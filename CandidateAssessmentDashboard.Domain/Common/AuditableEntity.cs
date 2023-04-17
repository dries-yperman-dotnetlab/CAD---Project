using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Domain.Common
{
    public class AuditableEntity
    {
        public string? CreatedBy { get; set; }
        public string? CreatedDate { get; set; }
        public string? LastModifiedBy { get; set; }
        public string? LastModifiedDate { get; set; }
    }
}
