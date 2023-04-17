using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.MailTemplates.Commands.DeleteMailTemplate
{
    public class DeleteMailTemplateCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
