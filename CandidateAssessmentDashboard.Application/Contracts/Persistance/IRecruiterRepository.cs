using CandidateAssessmentDashboard.Domain.Entities;

namespace CandidateAssessmentDashboard.Application.Contracts.Persistance
{
    public interface IRecruiterRepository : IAsyncRepository<Recruiter>
    {
        Task<bool> IsEmailUnique(string email);
    }
}
