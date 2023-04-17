using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.DeleteRecruiter
{
    public class DeleteRecruiterCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
