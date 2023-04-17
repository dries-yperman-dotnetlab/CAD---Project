namespace CandidateAssessmentDashboard.Application.Features.TeamworkPersonaTests.Queries
{
    public class TeamworkPersonaTestDetailVm
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = string.Empty;

        public Guid CandidateId { get; set; }
        public TeamworkPersonaTestCandidateDto Candidate { get; set; } = null!;
    }
}
