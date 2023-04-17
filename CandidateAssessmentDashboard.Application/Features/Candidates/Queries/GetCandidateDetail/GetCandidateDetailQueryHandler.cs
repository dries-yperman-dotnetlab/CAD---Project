using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Candidates.Queries.GetCandidateDetail
{
    public class GetCandidateDetailQueryHandler : IRequestHandler<GetCandidateDetailQuery, CandidateDetailVm>
    {
        private readonly IMapper _mapper;
        private readonly ICandidateRepository _candidateRepository;
        private readonly IBelbinTestRepository _belbinTestRepository;
        private readonly ITeamworkPersonaTestRepository _teamworkPersonaTestRepository;

        public GetCandidateDetailQueryHandler(IMapper mapper, ICandidateRepository candidateRepository, IBelbinTestRepository belbinTestRepository, ITeamworkPersonaTestRepository teamworkPersonaTestRepository)
        {
            _mapper = mapper;
            _candidateRepository = candidateRepository;
            _belbinTestRepository = belbinTestRepository;
            _teamworkPersonaTestRepository = teamworkPersonaTestRepository;
        }

        public async Task<CandidateDetailVm> Handle(GetCandidateDetailQuery request, CancellationToken cancellationToken)
        {
            var candidate = await _candidateRepository.GetByIdAsync(request.Id);
            var candidateDetailVm = _mapper.Map<CandidateDetailVm>(candidate);

            if (candidate.BelbinTest != null)
            {
                candidateDetailVm.BelbinTest = _mapper.Map<CandidateBelbinTestDto>(candidate.BelbinTest);
            }
            if (candidate.TeamworkPersonaTest != null)
            {
                candidateDetailVm.TeamworkPersonaTest = _mapper.Map<CandidateTeamworkPersonaTestDto>(candidate.TeamworkPersonaTest);
            }

            return candidateDetailVm;
        }
    }
}
