using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.CreateRecruiter
{
    public class CreateRecruiterCommand : IRequest<CreateRecruiterCommandResponse>
    {
        public string Email { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Recruiter - Email: {Email}";
        }
    }
}
