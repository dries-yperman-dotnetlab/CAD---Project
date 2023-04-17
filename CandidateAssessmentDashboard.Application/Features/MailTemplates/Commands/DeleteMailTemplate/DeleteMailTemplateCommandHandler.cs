using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.MailTemplates.Commands.DeleteMailTemplate
{
    public class DeleteMailTemplateCommandHandler : IRequestHandler<DeleteMailTemplateCommand>
    {
        private readonly IMapper _mapper;
        private readonly IMailTemplateRepository _mailTemplateRepository;

        public DeleteMailTemplateCommandHandler(IMapper mapper, IMailTemplateRepository mailTemplateRepository)
        {
            _mapper = mapper;
            _mailTemplateRepository = mailTemplateRepository;
        }

        public async Task Handle(DeleteMailTemplateCommand request, CancellationToken cancellationToken)
        {
            var mailTemplateToDelete = await _mailTemplateRepository.GetByIdAsync(request.Id);

            await _mailTemplateRepository.DeleteAsync(mailTemplateToDelete);
        }
    }
}
