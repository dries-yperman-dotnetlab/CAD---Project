using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.TeamworkPersonaTests.Queries
{
    public class GetTeamworkPersonaTestDetailQuery : IRequest<TeamworkPersonaTestDetailVm>
    {
        public Guid Id { get; set; }
    }
}
