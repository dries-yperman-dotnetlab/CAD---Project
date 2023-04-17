using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.BelbinTests.Commands.CreateBelbinTest
{
    public class CreateBelbinTestCommandHandler : IRequestHandler<CreateBelbinTestCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IBelbinTestRepository _belbinTestRepository;

        public CreateBelbinTestCommandHandler(IMapper mapper, IBelbinTestRepository belbinTestRepository)
        {
            _mapper = mapper;
            _belbinTestRepository = belbinTestRepository;
        }

        public async Task<Guid> Handle(CreateBelbinTestCommand request, CancellationToken cancellationToken)
        {
            var belbinTest = _mapper.Map<BelbinTest>(request);
            belbinTest = await _belbinTestRepository.AddAsync(belbinTest);
            return belbinTest.Id;
        }
    }
}
