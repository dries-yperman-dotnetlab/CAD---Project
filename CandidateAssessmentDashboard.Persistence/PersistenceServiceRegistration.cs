using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CandidateAssessmentDashboard.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CandidateAssessmentDashboardDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CandidateAssessmentDashboardConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IRecruiterRepository, RecruiterRepository>();
            // ...

            return services;
        }
    }
}
