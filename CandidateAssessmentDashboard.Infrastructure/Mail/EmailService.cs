using CandidateAssessmentDashboard.Application.Contracts.Infrastructure;
using CandidateAssessmentDashboard.Application.Models.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Infrastructure.Mail
{
    public class EmailService : IEmailService
    {
        public Task<bool> SendEmail(Email email)
        {
            throw new NotImplementedException();
        }
    }
}
