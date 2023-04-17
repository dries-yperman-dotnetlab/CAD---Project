using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.TeamworkPersonaTests.Commands.DeleteTeamworkPersonaTest
{
    public class DeleteTeamworkPersonaTestCommandHandler : IRequestHandler<DeleteTeamworkPersonaTestCommand>
    {
        private readonly IMapper _mapper;
        private readonly ITeamworkPersonaTestRepository _teamworkPersonaTestRepository;

        public DeleteTeamworkPersonaTestCommandHandler(IMapper mapper, ITeamworkPersonaTestRepository teamworkPersonaTestRepository)
        {
            _mapper = mapper;
            _teamworkPersonaTestRepository = teamworkPersonaTestRepository;
        }

        public async Task Handle(DeleteTeamworkPersonaTestCommand request, CancellationToken cancellationToken)
        {
            var teamworkPersonaTestToDelete = await _teamworkPersonaTestRepository.GetByIdAsync(request.Id);

            await _teamworkPersonaTestRepository.DeleteAsync(teamworkPersonaTestToDelete);
        }
    }
}
