using AutoMapper;
using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using CandidateAssessmentDashboard.Domain.Entities;
using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Notifications.Queries.GetNotificationsList
{
    public class GetNotificationsListQueryHandler : IRequestHandler<GetNotificationsListQuery, List<NotificationListVm>>
    {
        private readonly IMapper _mapper;
        private readonly INotificationRepository _notificationRepository;

        public GetNotificationsListQueryHandler(IMapper mapper, INotificationRepository notificationRepository)
        {
            _mapper = mapper;
            _notificationRepository = notificationRepository;
        }

        public async Task<List<NotificationListVm>> Handle(GetNotificationsListQuery request, CancellationToken cancellationToken)
        {
            var allNotifications = (await _notificationRepository.GetNotificationsWithCandidates()).ToList();
            return _mapper.Map<List<NotificationListVm>>(allNotifications);
        }
    }
}
