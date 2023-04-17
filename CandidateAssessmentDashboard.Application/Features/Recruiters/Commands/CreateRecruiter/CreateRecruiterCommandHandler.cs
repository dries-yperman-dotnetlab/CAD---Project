using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.CreateRecruiter
{
    public class CreateRecruiterCommandHandler : IRequestHandler<CreateRecruiterCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IRecruiterRepository _recruiterRepository;

        public CreateRecruiterCommandHandler(IMapper mapper, IRecruiterRepository recruiterRepository)
        {
            _mapper = mapper;
            _recruiterRepository = recruiterRepository;
        }
        public async Task<Guid> Handle(CreateRecruiterCommand request, CancellationToken cancellationToken)
        {
            var recruiter = _mapper.Map<Recruiter>(request);
            recruiter = await _recruiterRepository.AddAsync(recruiter);
            return recruiter.Id;
        }
    }
}
