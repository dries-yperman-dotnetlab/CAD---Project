using CandidateAssessmentDashboard.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Contracts.Persistance
{
    public interface ITeamworkPersonaTestRepository : IAsyncRepository<TeamworkPersonaTest>
    {
    }
}
