using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.MailTemplates.Queries.GetMailTemplateDetail
{
    public class GetMailTemplateDetailQueryHandler : IRequestHandler<GetMailTemplateDetailQuery, MailTemplateDetailVm>
    {
        private readonly IMapper _mapper;
        private readonly IMailTemplateRepository _mailTemplateRepository;

        public GetMailTemplateDetailQueryHandler(IMapper mapper, IMailTemplateRepository mailTemplateRepository)
        {
            _mapper = mapper;
            _mailTemplateRepository = mailTemplateRepository;
        }

        public async Task<MailTemplateDetailVm> Handle(GetMailTemplateDetailQuery request, CancellationToken cancellationToken)
        {
            var mailTemplate = await _mailTemplateRepository.GetByIdAsync(request.Id);
            return _mapper.Map<MailTemplateDetailVm>(mailTemplate);
        }
    }
}
