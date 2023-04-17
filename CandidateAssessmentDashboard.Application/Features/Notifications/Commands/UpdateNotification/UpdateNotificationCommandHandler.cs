using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Notifications.Commands.UpdateNotification
{
    public class UpdateNotificationCommandHandler : IRequestHandler<UpdateNotificationCommand>
    {
        private readonly IMapper _mapper;
        private readonly INotificationRepository _notificationRepository;

        public UpdateNotificationCommandHandler(IMapper mapper, INotificationRepository notificationRepository)
        {
            _mapper = mapper;
            _notificationRepository = notificationRepository;
        }

        public async Task Handle(UpdateNotificationCommand request, CancellationToken cancellationToken)
        {
            var notificationToUpdate = await _notificationRepository.GetByIdAsync(request.Id);

            _mapper.Map(request, notificationToUpdate, typeof(UpdateNotificationCommand), typeof(Notification));

            await _notificationRepository.UpdateAsync(notificationToUpdate);
        }
    }
}
