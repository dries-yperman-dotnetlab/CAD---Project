using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Notifications.Queries.GetNotificationsList
{
    public class GetNotificationsListQuery : IRequest<List<NotificationListVm>>
    {
    }
}
