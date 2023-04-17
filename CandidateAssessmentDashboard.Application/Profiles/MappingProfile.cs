using AutoMapper;
using CandidateAssessmentDashboard.Domain.Entities;
using CandidateAssessmentDashboard.Application.Features.Recruiters.Queries.GetRecruiterDetail;
using CandidateAssessmentDashboard.Application.Features.Recruiters.Queries.GetRecruitersList;
using CandidateAssessmentDashboard.Application.Features.Candidates.Queries.GetCandidatesList;
using CandidateAssessmentDashboard.Application.Features.Candidates.Queries.GetCandidateDetail;
using CandidateAssessmentDashboard.Application.Features.MailTemplates.Queries.GetMailTemplatesList;
using CandidateAssessmentDashboard.Application.Features.MailTemplates.Queries.GetMailTemplateDetail;
using CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.CreateRecruiter;
using CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.UpdateRecruiter;
using CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.DeleteRecruiter;
using CandidateAssessmentDashboard.Application.Features.Notifications.Queries.GetNotificationsList;
using CandidateAssessmentDashboard.Application.Features.Candidates.Commands.CreateCandidate;
using CandidateAssessmentDashboard.Application.Features.Candidates.Commands.DeleteCandidate;
using CandidateAssessmentDashboard.Application.Features.Candidates.Commands.UpdateCandidate;
using CandidateAssessmentDashboard.Application.Features.MailTemplates.Commands.CreateMailTemplate;
using CandidateAssessmentDashboard.Application.Features.MailTemplates.Commands.DeleteMailTemplate;
using CandidateAssessmentDashboard.Application.Features.MailTemplates.Commands.UpdateMailTemplate;
using CandidateAssessmentDashboard.Application.Features.Notifications.Commands.CreateNotification;
using CandidateAssessmentDashboard.Application.Features.Notifications.Commands.DeleteNotification;
using CandidateAssessmentDashboard.Application.Features.Notifications.Commands.UpdateNotification;
using CandidateAssessmentDashboard.Application.Features.BelbinTests.Queries.GetBelbinTestDetail;
using CandidateAssessmentDashboard.Application.Features.BelbinTests.Commands.CreateBelbinTest;
using CandidateAssessmentDashboard.Application.Features.BelbinTests.Commands.DeleteBelbinTest;
using CandidateAssessmentDashboard.Application.Features.TeamworkPersonaTests.Queries;
using CandidateAssessmentDashboard.Application.Features.TeamworkPersonaTests.Commands.CreateTeamworkPersonaTest;
using CandidateAssessmentDashboard.Application.Features.TeamworkPersonaTests.Commands.DeleteTeamworkPersonaTest;

namespace CandidateAssessmentDashboard.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Recruiter
            CreateMap<Recruiter, RecruiterListVm>();
            CreateMap<Recruiter, RecruiterDetailVm>();

            CreateMap<Recruiter, UpdateRecruiterCommand>().ReverseMap();
            CreateMap<Recruiter, DeleteRecruiterCommand>().ReverseMap();
            CreateMap<Recruiter, CreateRecruiterCommand>().ReverseMap();

            CreateMap<Recruiter, CreateRecruiterDto>();

            // Candidate
            CreateMap<Candidate, CandidateListVm>();
            CreateMap<Candidate, CandidateDetailVm>();
            CreateMap<BelbinTest, CandidateBelbinTestDto>();
            CreateMap<TeamworkPersonaTest, CandidateTeamworkPersonaTestDto>();

            CreateMap<Candidate, CreateCandidateCommand>().ReverseMap();
            CreateMap<Candidate, DeleteCandidateCommand>().ReverseMap();
            CreateMap<Candidate, UpdateCandidateCommand>().ReverseMap();

            // MailTemplate
            CreateMap<MailTemplate, MailTemplateListVm>();
            CreateMap<MailTemplate, MailTemplateDetailVm>();

            CreateMap<MailTemplate, CreateMailTemplateCommand>().ReverseMap();
            CreateMap<MailTemplate, DeleteMailTemplateCommand>().ReverseMap();
            CreateMap<MailTemplate, UpdateMailTemplateCommand>().ReverseMap();

            // Notification -- TODO --
            CreateMap<Notification, NotificationListVm>();
            CreateMap<Candidate, NotificationCandidateDto>();
            
            CreateMap<Notification, CreateNotificationCommand>().ReverseMap();
            CreateMap<Notification, DeleteNotificationCommand>().ReverseMap();
            CreateMap<Notification, UpdateNotificationCommand>().ReverseMap();

            // BelbinTest
            CreateMap<BelbinTest, BelbinTestDetailVm>();
            CreateMap<Candidate, BelbinTestCandidateDto>();

            CreateMap<BelbinTest, CreateBelbinTestCommand>().ReverseMap();
            CreateMap<BelbinTest, DeleteBelbinTestCommand>().ReverseMap();

            // TeamworkPersonaTest
            CreateMap<TeamworkPersonaTest, TeamworkPersonaTestDetailVm>();
            CreateMap<Candidate, TeamworkPersonaTestCandidateDto>();

            CreateMap<TeamworkPersonaTest, CreateTeamworkPersonaTestCommand>().ReverseMap();
            CreateMap<TeamworkPersonaTest, DeleteTeamworkPersonaTestCommand>().ReverseMap();
        }
    }
}
 