using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Queries.GetRecruiterDetail
{
    public class GetRecruiterDetailQueryHandler : IRequestHandler<GetRecruiterDetailQuery, RecruiterDetailVm>
    {
        private readonly IMapper _mapper;
        private readonly IRecruiterRepository _recruiterRepository;

        public GetRecruiterDetailQueryHandler(IMapper mapper, IRecruiterRepository recruiterRepository)
        {
            _mapper = mapper;
            _recruiterRepository = recruiterRepository;
        }
        public async Task<RecruiterDetailVm> Handle(GetRecruiterDetailQuery request, CancellationToken cancellationToken)
        {
            var recruiter = await _recruiterRepository.GetByIdAsync(request.Id);
            return _mapper.Map<RecruiterDetailVm>(recruiter);
        }
    }
}
