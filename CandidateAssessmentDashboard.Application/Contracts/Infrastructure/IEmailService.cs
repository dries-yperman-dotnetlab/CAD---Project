using CandidateAssessmentDashboard.Application.Models.Mail;

namespace CandidateAssessmentDashboard.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
