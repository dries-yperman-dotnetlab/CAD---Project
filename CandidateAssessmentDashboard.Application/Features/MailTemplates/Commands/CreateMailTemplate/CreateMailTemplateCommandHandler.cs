using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.MailTemplates.Commands.CreateMailTemplate
{
    public class CreateMailTemplateCommandHandler : IRequestHandler<CreateMailTemplateCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IMailTemplateRepository _mailTemlplateRepository;

        public CreateMailTemplateCommandHandler(IMapper mapper, IMailTemplateRepository mailTemlplateRepository)
        {
            _mapper = mapper;
            _mailTemlplateRepository = mailTemlplateRepository;
        }
        public async Task<Guid> Handle(CreateMailTemplateCommand request, CancellationToken cancellationToken)
        {
            var mailTemlplate = _mapper.Map<MailTemplate>(request);
            mailTemlplate = await _mailTemlplateRepository.AddAsync(mailTemlplate);
            return mailTemlplate.Id;
        }
    }
}
