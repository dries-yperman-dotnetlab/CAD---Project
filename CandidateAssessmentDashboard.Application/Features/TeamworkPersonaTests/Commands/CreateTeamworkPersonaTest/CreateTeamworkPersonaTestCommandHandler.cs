using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.TeamworkPersonaTests.Commands.CreateTeamworkPersonaTest
{
    public class CreateTeamworkPersonaTestCommandHandler : IRequestHandler<CreateTeamworkPersonaTestCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly ITeamworkPersonaTestRepository _teamworkPersonaTestRepository;

        public CreateTeamworkPersonaTestCommandHandler(IMapper mapper, ITeamworkPersonaTestRepository teamworkPersonaTestRepository)
        {
            _mapper = mapper;
            _teamworkPersonaTestRepository = teamworkPersonaTestRepository;
        }

        public async Task<Guid> Handle(CreateTeamworkPersonaTestCommand request, CancellationToken cancellationToken)
        {
            var teamworkPersonaTest = _mapper.Map<TeamworkPersonaTest>(request);
            teamworkPersonaTest = await _teamworkPersonaTestRepository.AddAsync(teamworkPersonaTest);
            return teamworkPersonaTest.Id;
        }
    }
}
