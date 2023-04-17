using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.TeamworkPersonaTests.Commands.CreateTeamworkPersonaTest
{
    public class CreateTeamworkPersonaTestCommand : IRequest<Guid>
    {
        public string Status { get; set; } = string.Empty;

        public Guid CandidateId { get; set; }

        public override string ToString()
        {
            return $"TeamworkPersonaTest - Status: {Status}; CandidateId: {CandidateId}";
        }
    }
}
