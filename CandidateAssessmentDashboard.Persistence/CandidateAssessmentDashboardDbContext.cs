using CandidateAssessmentDashboard.Domain.Common;
using CandidateAssessmentDashboard.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CandidateAssessmentDashboard.Persistence
{
    public class CandidateAssessmentDashboardDbContext : DbContext
    {
        public CandidateAssessmentDashboardDbContext(DbContextOptions<CandidateAssessmentDashboardDbContext> options) : base(options) { }

        public DbSet<Recruiter> Recruiters { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<MailTemplate> MailTemplates { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<BelbinTest> BelbinTests { get; set;}
        public DbSet<TeamworkPersonaTest> TeamworkPersonaTests { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CandidateAssessmentDashboardDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}