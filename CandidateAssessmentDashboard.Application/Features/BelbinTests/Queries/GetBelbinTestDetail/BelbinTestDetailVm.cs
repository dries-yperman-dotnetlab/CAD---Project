namespace CandidateAssessmentDashboard.Application.Features.BelbinTests.Queries.GetBelbinTestDetail
{
    public class BelbinTestDetailVm
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = string.Empty;

        public Guid CandidateId { get; set; }
        public BelbinTestCandidateDto Candidate { get; set; } = null!;
    }
}
