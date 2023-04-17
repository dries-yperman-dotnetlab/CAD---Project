using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Application.Features.BelbinTests.Queries.GetBelbinTestDetail;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.TeamworkPersonaTests.Queries
{
    public class GetTeamworkPersonaTestDetailQueryHandler : IRequestHandler<GetTeamworkPersonaTestDetailQuery, TeamworkPersonaTestDetailVm>
    {
        private readonly IMapper _mapper;
        private readonly ITeamworkPersonaTestRepository _teamworkPersonaTestRepository;

        public GetTeamworkPersonaTestDetailQueryHandler(IMapper mapper, ITeamworkPersonaTestRepository teamworkPersonaTestRepository)
        {
            _mapper = mapper;
            _teamworkPersonaTestRepository = teamworkPersonaTestRepository;
        }

        public async Task<TeamworkPersonaTestDetailVm> Handle(GetTeamworkPersonaTestDetailQuery request, CancellationToken cancellationToken)
        {
            var teamworkPersonaTest = await _teamworkPersonaTestRepository.GetByIdAsync(request.Id);
            var teamworkPersonaTestDetailVm = _mapper.Map<TeamworkPersonaTestDetailVm>(teamworkPersonaTest);

            var teamworkPersonaTestCandidate = await _teamworkPersonaTestRepository.GetByIdAsync(teamworkPersonaTest.CandidateId);
            teamworkPersonaTestDetailVm.Candidate = _mapper.Map<TeamworkPersonaTestCandidateDto>(teamworkPersonaTestCandidate);

            return teamworkPersonaTestDetailVm;
        }
    }
}
