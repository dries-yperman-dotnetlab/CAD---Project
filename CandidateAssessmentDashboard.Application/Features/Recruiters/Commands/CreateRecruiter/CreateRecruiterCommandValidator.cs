using CandidateAssessmentDashboard.Application.Contracts.Persistance;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateAssessmentDashboard.Application.Features.Recruiters.Commands.CreateRecruiter
{
    public class CreateRecruiterCommandValidator : AbstractValidator<CreateRecruiterCommand>
    {
        private readonly IRecruiterRepository _recruiterRepository;
        public CreateRecruiterCommandValidator(IRecruiterRepository recruiterRepository)
        {
            _recruiterRepository = recruiterRepository;

            RuleFor(e => e.Email)
                .NotEmpty()
                .WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(e => e.Email)
                .MustAsync(EmailUnique)
                .WithMessage("A Recruiter with the same email already exists.");
        }

        private async Task<bool> EmailUnique(string email, CancellationToken token)
        {
            return !(await _recruiterRepository.IsEmailUnique(email));
        }
    }
}
