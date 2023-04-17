using CandidateAssessmentDashboard.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.CreateRecruiter
{
    public class CreateRecruiterCommandResponse : BaseResponse
    {
        public CreateRecruiterCommandResponse(): base() { }

        public CreateRecruiterDto Recruiter { get; set; } = default!;
    }
}
