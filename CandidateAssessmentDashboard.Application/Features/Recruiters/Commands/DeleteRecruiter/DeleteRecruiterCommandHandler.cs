using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.DeleteRecruiter
{
    public class DeleteRecruiterCommandHandler : IRequestHandler<DeleteRecruiterCommand>
    {
        private readonly IMapper _mapper;
        private readonly IRecruiterRepository _recruiterRepository;

        public DeleteRecruiterCommandHandler(IMapper mapper, IRecruiterRepository recruiterRepository)
        {
            _mapper = mapper;
            _recruiterRepository = recruiterRepository;
        }

        public async Task Handle(DeleteRecruiterCommand request, CancellationToken cancellationToken)
        {
            var recruiterToDelete = await _recruiterRepository.GetByIdAsync(request.Id);

            await _recruiterRepository.DeleteAsync(recruiterToDelete);
        }
    }
}
