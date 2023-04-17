using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.MailTemplates.Queries.GetMailTemplateDetail
{
    public class GetMailTemplateDetailQuery : IRequest<MailTemplateDetailVm>
    {
        public Guid Id { get; set; }

    }
}
