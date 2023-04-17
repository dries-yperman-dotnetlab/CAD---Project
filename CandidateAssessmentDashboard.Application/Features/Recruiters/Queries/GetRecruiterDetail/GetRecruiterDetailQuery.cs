using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Queries.GetRecruiterDetail
{
    public class GetRecruiterDetailQuery : IRequest<RecruiterDetailVm>
    {
        public Guid Id { get; set; }
    }
}
