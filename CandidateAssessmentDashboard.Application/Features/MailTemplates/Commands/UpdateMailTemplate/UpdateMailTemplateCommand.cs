using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.MailTemplates.Commands.UpdateMailTemplate
{
    public class UpdateMailTemplateCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
