using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Candidates.Commands.DeleteCandidate
{
    public class DeleteCandidateCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
