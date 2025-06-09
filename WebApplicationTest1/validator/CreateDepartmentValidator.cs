using FluentValidation;
using WebApplicationTest1.CQRS.Commands;

namespace WebApplicationTest1.validator
{
    public class CreateDepartmentValidator : AbstractValidator<CreateDepartmentCommand>
    {
        public CreateDepartmentValidator()
        {
            RuleFor(command => command.Name)
                .NotEmpty().WithMessage("Department name is required.")
                .Length(2, 100).WithMessage("Department name must be between 2 and 100 characters long.");
        }
    }
  
}
