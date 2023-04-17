using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Candidates.Commands.CreateCandidate
{
    public class CreateCandidateCommandHandler : IRequestHandler<CreateCandidateCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly ICandidateRepository _candidateRepository;
        public CreateCandidateCommandHandler(IMapper mapper, ICandidateRepository candidateRepository)
        {
            _mapper = mapper;
            _candidateRepository = candidateRepository;
        }

        public async Task<Guid> Handle(CreateCandidateCommand request, CancellationToken cancellationToken)
        {
            var candidate = _mapper.Map<Candidate>(request);
            candidate = await _candidateRepository.AddAsync(candidate);
            return candidate.Id;
        }
    }
}
