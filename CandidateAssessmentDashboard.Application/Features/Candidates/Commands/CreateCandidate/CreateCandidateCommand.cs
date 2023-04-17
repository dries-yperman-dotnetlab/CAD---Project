using MediatR; 

namespace CandidateAssessmentDashboard.Application.Features.Candidates.Commands.CreateCandidate
{
    public class CreateCandidateCommand : IRequest<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Candidate - Name: {Name}; FirstName: {FirstName}; Email: {Email}";
        }
    }
}
