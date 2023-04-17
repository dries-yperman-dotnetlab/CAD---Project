using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.CreateRecruiter
{
    public class CreateRecruiterDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}
