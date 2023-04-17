using CandidateAssessmentDashboard.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Notifications.Queries.GetNotificationsList
{
    public class NotificationListVm
    {
        public Guid Id { get; set; }
        public string content { get; set; } = string.Empty;
        public bool IsRead { get; set; } = false;

        public NotificationCandidateDto Candidate { get; set; } = null!;
    }
}
