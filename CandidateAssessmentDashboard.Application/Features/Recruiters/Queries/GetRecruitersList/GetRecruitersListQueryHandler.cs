using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Queries.GetRecruitersList
{
    public class GetRecruitersListQueryHandler : IRequestHandler<GetRecruitersListQuery, List<RecruiterListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IRecruiterRepository _recruiterRepository;

        public GetRecruitersListQueryHandler(IMapper mapper, IRecruiterRepository recruiterRepository)
        {
            _mapper = mapper;
            _recruiterRepository = recruiterRepository;
        }


        public async Task<List<RecruiterListVm>> Handle(GetRecruitersListQuery request, CancellationToken cancellationToken)
        {
            var allRecruiters = (await _recruiterRepository.ListAllAsync()).ToList();
            return _mapper.Map<List<RecruiterListVm>>(allRecruiters);
        }
    }
}
