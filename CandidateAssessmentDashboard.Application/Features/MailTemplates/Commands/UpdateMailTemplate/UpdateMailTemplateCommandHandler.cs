using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.MailTemplates.Commands.UpdateMailTemplate
{
    public class UpdateMailTemplateCommandHandler : IRequestHandler<UpdateMailTemplateCommand>
    {
        private readonly IMapper _mapper;
        private readonly IMailTemplateRepository _mailTemplateRepository;

        public UpdateMailTemplateCommandHandler(IMapper mapper, IMailTemplateRepository mailTemplateRepository)
        {
            _mapper = mapper;
            _mailTemplateRepository = mailTemplateRepository;
        }

        public async Task Handle(UpdateMailTemplateCommand request, CancellationToken cancellationToken)
        {
            var mailTemplateToUpdate = await _mailTemplateRepository.GetByIdAsync(request.Id);

            _mapper.Map(request, mailTemplateToUpdate, typeof(UpdateMailTemplateCommand), typeof(MailTemplate));

            await _mailTemplateRepository.UpdateAsync(mailTemplateToUpdate);
        }
    }
}
