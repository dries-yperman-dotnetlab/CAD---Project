using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.BelbinTests.Commands.CreateBelbinTest
{
    public class CreateBelbinTestCommand : IRequest<Guid>
    {
        public string Status { get; set; } = string.Empty;

        public Guid CandidateId { get; set; }

        public override string ToString()
        {
            return $"BelbinTest - Status: {Status}; CandidateId: {CandidateId}";
        }
    }
}
