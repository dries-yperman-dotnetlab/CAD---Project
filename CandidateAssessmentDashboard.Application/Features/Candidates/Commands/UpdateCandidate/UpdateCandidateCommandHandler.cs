using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Candidates.Commands.UpdateCandidate
{
    public class UpdateCandidateCommandHandler : IRequestHandler<UpdateCandidateCommand>
    {
        private readonly IMapper _mapper;
        private readonly ICandidateRepository _candidateRepository;

        public UpdateCandidateCommandHandler(IMapper mapper, ICandidateRepository candidateRepository)
        {
            _mapper = mapper;
            _candidateRepository = candidateRepository;
        }
        public async Task Handle(UpdateCandidateCommand request, CancellationToken cancellationToken)
        {
            var candidateToUpdate = await _candidateRepository.GetByIdAsync(request.Id);

            _mapper.Map(request, candidateToUpdate, typeof(UpdateCandidateCommand), typeof(Candidate));

            await _candidateRepository.UpdateAsync(candidateToUpdate);
        }
    }
}
