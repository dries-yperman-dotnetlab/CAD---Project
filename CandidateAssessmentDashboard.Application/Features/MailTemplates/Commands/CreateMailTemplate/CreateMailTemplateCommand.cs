using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.MailTemplates.Commands.CreateMailTemplate
{
    public class CreateMailTemplateCommand : IRequest<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Recruiter - Name: {Name}; Content: {Content}";
        }
    }
}
