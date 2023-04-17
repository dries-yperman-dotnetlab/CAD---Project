using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.DeleteRecruiter;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Candidates.Commands.DeleteCandidate
{
    public class DeleteCandidateCommandHandler : IRequestHandler<DeleteCandidateCommand>
    {
        private readonly IMapper _mapper;
        private readonly ICandidateRepository _candidateRepository;

        public DeleteCandidateCommandHandler(IMapper mapper, ICandidateRepository candidateRepository)
        {
            _mapper = mapper;
            _candidateRepository = candidateRepository;
        }
        public async Task Handle(DeleteCandidateCommand request, CancellationToken cancellationToken)
        {
            var candidateToDelete = await _candidateRepository.GetByIdAsync(request.Id);
            
            await _candidateRepository.DeleteAsync(candidateToDelete);
        }
    }
}
