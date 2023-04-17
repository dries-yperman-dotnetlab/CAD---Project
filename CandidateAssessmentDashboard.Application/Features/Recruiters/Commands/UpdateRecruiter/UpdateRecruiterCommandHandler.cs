using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.UpdateRecruiter
{
    public class UpdateRecruiterCommandHandler : IRequestHandler<UpdateRecruiterCommand>
    {
        private readonly IMapper _mapper;
        private readonly IRecruiterRepository _recruiterRepository;

        public UpdateRecruiterCommandHandler(IMapper mapper, IRecruiterRepository recruiterRepository)
        {
            _mapper = mapper;
            _recruiterRepository = recruiterRepository;
        }
        public async Task Handle(UpdateRecruiterCommand request, CancellationToken cancellationToken)
        {
            var recruiterToUpdate = await _recruiterRepository.GetByIdAsync(request.Id);
            
            _mapper.Map(request, recruiterToUpdate, typeof(UpdateRecruiterCommand), typeof(Recruiter));

            await _recruiterRepository.UpdateAsync(recruiterToUpdate);
        }
    }
}
