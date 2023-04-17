using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.CreateRecruiter
{
    public class CreateRecruiterCommandHandler : IRequestHandler<CreateRecruiterCommand, CreateRecruiterCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IRecruiterRepository _recruiterRepository;

        public CreateRecruiterCommandHandler(IMapper mapper, IRecruiterRepository recruiterRepository)
        {
            _mapper = mapper;
            _recruiterRepository = recruiterRepository;
        }
        public async Task<CreateRecruiterCommandResponse> Handle(CreateRecruiterCommand request, CancellationToken cancellationToken)
        {
            var createRecruiterCommandResponse = new CreateRecruiterCommandResponse();

            var validator = new CreateRecruiterCommandValidator(_recruiterRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createRecruiterCommandResponse.Success = false;
                createRecruiterCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createRecruiterCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if (createRecruiterCommandResponse.Success)
            {
                var recruiter = _mapper.Map<Recruiter>(request);
                recruiter = await _recruiterRepository.AddAsync(recruiter);
                createRecruiterCommandResponse.Recruiter = _mapper.Map<CreateRecruiterDto>(recruiter);
            }

            return createRecruiterCommandResponse;
        }
    }
}
