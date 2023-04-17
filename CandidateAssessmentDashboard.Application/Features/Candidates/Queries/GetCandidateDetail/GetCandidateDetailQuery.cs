using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Candidates.Queries.GetCandidateDetail
{
    public class GetCandidateDetailQuery : IRequest<CandidateDetailVm>
    {
        public Guid Id { get; set; }
    }
}
