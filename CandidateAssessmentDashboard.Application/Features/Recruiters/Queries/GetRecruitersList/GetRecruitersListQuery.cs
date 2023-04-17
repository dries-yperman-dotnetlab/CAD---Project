using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Queries.GetRecruitersList
{
    public class GetRecruitersListQuery : IRequest<List<RecruiterListVm>>
    {
    }
}
