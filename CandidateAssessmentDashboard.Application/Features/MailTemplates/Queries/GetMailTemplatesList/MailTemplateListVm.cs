using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.MailTemplates.Queries.GetMailTemplatesList
{
    public class MailTemplateListVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
