using System.ComponentModel.DataAnnotations;

namespace HeroesTrainingApi.dto
{
    public class GetTokenRequest
    {
        public string UserName { get; set; } = Consts.UserName;
        [MinLength(8)]
        [Required()]
        public string Password { get; set; } = Consts.Password;

    }

    public class GetTokenRequestValidator : AbstractValidator<GetTokenRequest> 
    {
         public GetTokenRequestValidator() 
         {
            RuleFor(x => x.Password)..NotEmpty().WithMessage("Your password cannot be empty")
                    .MinimumLength(8).WithMessage("Your password length must be at least 8.")
                    .MaximumLength(16).WithMessage("Your password length must not exceed 16.")
                    .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                    .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                    .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.")
                    .Matches(@"[\!\?\*\.]+").WithMessage("Your password must contain at least one (!? *.).");
         }
    }
}
