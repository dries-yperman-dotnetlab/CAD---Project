using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Candidates.Queries.GetCandidatesList
{
    public class GetCandidatesListQueryHandler : IRequestHandler<GetCandidatesListQuery, List<CandidateListVm>>
    {
        private readonly IMapper _mapper;
        private readonly ICandidateRepository _candidateRepository;

        public GetCandidatesListQueryHandler(IMapper mapper, ICandidateRepository candidateRepository)
        {
            _mapper = mapper;
            _candidateRepository = candidateRepository;
        }

        public async Task<List<CandidateListVm>> Handle(GetCandidatesListQuery request, CancellationToken cancellationToken)
        {
            var allCandidates = (await _candidateRepository.ListAllAsync()).ToList();
            return _mapper.Map<List<CandidateListVm>>(allCandidates);
        }
    }
}
