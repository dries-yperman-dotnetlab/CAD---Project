using CandidateAssessmentDashboard.Application.Features.Recruiters.Queries.GetRecruitersList;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.MailTemplates.Queries.GetMailTemplatesList
{
    public class GetMailTemplatesListQuery : IRequest<List<MailTemplateListVm>>
    {
    }
}
