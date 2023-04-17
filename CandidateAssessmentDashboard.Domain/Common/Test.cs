using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateAssessmentDashboard.Domain.Entities;

namespace CandidateAssessmentDashboard.Domain.Common
{
    public interface Test
    {
        public Guid Id { get; set; }
        public string Status { get; set; }

        public Guid CandidateId { get; set; }
        public Candidate Candidate { get; set; }
    }
}
