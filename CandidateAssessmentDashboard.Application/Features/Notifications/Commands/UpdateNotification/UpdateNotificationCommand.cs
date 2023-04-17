using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Notifications.Commands.UpdateNotification
{
    public class UpdateNotificationCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public bool IsRead { get; set; } = false;

        public Guid CandidateId { get; set; }
    }
}
