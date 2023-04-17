using MediatR;

namespace CandidateAssessmentDashboard.Application.Features.Notifications.Commands.CreateNotification
{
    public class CreateNotificationCommand : IRequest<Guid>
    {
        public string Content { get; set; } = string.Empty;
        public bool IsRead { get; set; } = false;

        public Guid CandidateId { get; set; }

        public override string ToString()
        {
            return $"Notification - Content: {Content}; IsRead: {IsRead}; CandidateId: {CandidateId}";
        }
    }
}
