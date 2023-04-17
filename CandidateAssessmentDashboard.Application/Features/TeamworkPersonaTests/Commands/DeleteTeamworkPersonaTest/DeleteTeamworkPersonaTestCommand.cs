using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.TeamworkPersonaTests.Commands.DeleteTeamworkPersonaTest
{
    public class DeleteTeamworkPersonaTestCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
