using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.UpdateRecruiter
{
    public class UpdateRecruiterCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}
