using FluentValidation;
using Microsoft.Extensions.Options;
using Xunarmand.Application.Common.Settings;
using Xunarmand.Domain.Enums;

namespace Xunarmand.Infrastructure.User.Validators;

public class UserValidation:AbstractValidator<Domain.Entities.User>
{
    public UserValidation(IOptions<ValidationSettings> validationSettings)
    {
        var validationSettingsValue = validationSettings.Value;
        
        RuleSet(
            EntityEvent.OnCreate.ToString(),
            () =>
            {
                RuleFor(client => client.FirstName)
                    .NotEmpty()
                    .MinimumLength(3)
                    .MaximumLength(64)
                    .Matches(validationSettingsValue.NameRegexPattern);

                RuleFor(client => client.LastName)
                    .NotEmpty()
                    .MinimumLength(3)
                    .MaximumLength(64)
                    .Matches(validationSettingsValue.NameRegexPattern);
                    

                RuleFor(client => client.Email)
                    .NotEmpty()
                    .MinimumLength(3)
                    .MaximumLength(128)
                    .Matches(validationSettingsValue.EmailRegexPattern);

                RuleFor(client => client.Password).NotEmpty();
            }
        );
        
        RuleSet(
            EntityEvent.OnUpdate.ToString(),
            () =>
            {
                RuleFor(client => client.FirstName)
                    .NotEmpty()
                    .MinimumLength(3)
                    .MaximumLength(64)
                    .Matches(validationSettingsValue.NameRegexPattern);

                RuleFor(client => client.LastName)
                    .NotEmpty()
                    .MinimumLength(3)
                    .MaximumLength(64)
                    .Matches(validationSettingsValue.NameRegexPattern);
                    

                RuleFor(client => client.Email)
                    .NotEmpty()
                    .MinimumLength(3)
                    .MaximumLength(128)
                    .Matches(validationSettingsValue.EmailRegexPattern);

                RuleFor(client => client.Password).NotEmpty();
            }
        );
        
        
    }
    
}