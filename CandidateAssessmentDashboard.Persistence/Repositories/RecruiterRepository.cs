using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;

namespace CandidateAssessmentDashboard.Persistence.Repositories
{
    public class RecruiterRepository : BaseRepository<Recruiter>, IRecruiterRepository
    {
        public RecruiterRepository(CandidateAssessmentDashboardDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsEmailUnique(string email)
        {
            var matches = _dbContext.Recruiters.Any(r => r.Email.Equals(email));
            return Task.FromResult(matches);
        }

    }
}
