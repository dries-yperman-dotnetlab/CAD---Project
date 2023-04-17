using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Queries.GetRecruiterDetail
{
    public class RecruiterDetailVm
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        // Some more information in the future
    }
}
