using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.BelbinTests.Queries.GetBelbinTestDetail
{
    public class GetBelbinTestDetailQueryHandler : IRequestHandler<GetBelbinTestDetailQuery, BelbinTestDetailVm>
    {
        private readonly IMapper _mapper;
        private readonly IBelbinTestRepository _belbinTestRepository;
        private readonly ICandidateRepository _candidateRepository;

        public GetBelbinTestDetailQueryHandler(IMapper mapper, IBelbinTestRepository belbinTestRepository, ICandidateRepository candidateRepository)
        {
            _mapper = mapper;
            _belbinTestRepository = belbinTestRepository;
            _candidateRepository = candidateRepository;
        }

        public async Task<BelbinTestDetailVm> Handle(GetBelbinTestDetailQuery request, CancellationToken cancellationToken)
        {
            var belbinTest = await _belbinTestRepository.GetByIdAsync(request.Id);
            var belbinTestDetailVm = _mapper.Map<BelbinTestDetailVm>(belbinTest);

            var belbinTestCandidate = await _candidateRepository.GetByIdAsync(belbinTest.CandidateId);
            belbinTestDetailVm.Candidate = _mapper.Map<BelbinTestCandidateDto>(belbinTestCandidate);

            return belbinTestDetailVm;
        }
    }
}
