using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.BelbinTests.Commands.DeleteBelbinTest
{
    public class DeleteBelbinTestCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
