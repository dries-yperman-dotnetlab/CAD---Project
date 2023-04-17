using CandidateAssessmentDashboard.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Candidates.Queries.GetCandidatesList
{
    public class CandidateListVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
    }
}
