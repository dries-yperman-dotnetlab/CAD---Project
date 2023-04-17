using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Notifications.Commands.DeleteNotification
{
    public class DeleteNotificationCommandHandler : IRequestHandler<DeleteNotificationCommand>
    {
        private readonly Mapper _mapper;
        private readonly INotificationRepository _notificationRepository;

        public DeleteNotificationCommandHandler(Mapper mapper, INotificationRepository notificationRepository)
        {
            _mapper = mapper;
            _notificationRepository = notificationRepository;
        }

        public async Task Handle(DeleteNotificationCommand request, CancellationToken cancellationToken)
        {
            var notificationToDelete = await _notificationRepository.GetByIdAsync(request.Id);

            await _notificationRepository.DeleteAsync(notificationToDelete);
        }
    }
}
