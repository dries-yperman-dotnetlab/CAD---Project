using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.BelbinTests.Commands.DeleteBelbinTest
{
    public class DeleteBelbinTestCommandHandler : IRequestHandler<DeleteBelbinTestCommand>
    {
        private readonly IMapper _mapper;
        private readonly IBelbinTestRepository _belbinTestRepository;

        public DeleteBelbinTestCommandHandler(IMapper mapper, IBelbinTestRepository belbinTestRepository)
        {
            _mapper = mapper;
            _belbinTestRepository = belbinTestRepository;
        }

        public async Task Handle(DeleteBelbinTestCommand request, CancellationToken cancellationToken)
        {
            var belbinTestToDelete = await _belbinTestRepository.GetByIdAsync(request.Id);

            await _belbinTestRepository.DeleteAsync(belbinTestToDelete);
        }
    }
}
