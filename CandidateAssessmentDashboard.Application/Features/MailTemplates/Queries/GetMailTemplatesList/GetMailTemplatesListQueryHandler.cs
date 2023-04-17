using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.MailTemplates.Queries.GetMailTemplatesList
{
    public class GetMailTemplatesListQueryHandler : IRequestHandler<GetMailTemplatesListQuery, List<MailTemplateListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IMailTemplateRepository _mailTemplateRepository;

        public GetMailTemplatesListQueryHandler(IMapper mapper, IMailTemplateRepository mailTemplateRepository)
        {
            _mapper = mapper;
            _mailTemplateRepository = mailTemplateRepository;
        }

        public async Task<List<MailTemplateListVm>> Handle(GetMailTemplatesListQuery request, CancellationToken cancellationToken)
        {
            var allMailTemplates = (await _mailTemplateRepository.ListAllAsync()).ToList();
            return _mapper.Map<List<MailTemplateListVm>>(allMailTemplates);
        }
    }
}
