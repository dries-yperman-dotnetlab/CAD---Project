using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.BelbinTests.Queries.GetBelbinTestDetail
{
    public class GetBelbinTestDetailQuery : IRequest<BelbinTestDetailVm>
    {
        public Guid Id { get; set; }
    }
}
