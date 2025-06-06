using FluentValidation;
using WebApplicationTest1.dto;

namespace WebApplicationTest1.validator
{
    public class DepartmentValidator : AbstractValidator<DepartmentDto>
    {
        public DepartmentValidator() 
        { 
            RuleFor(d => d.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(2, 50).WithMessage("Name must be between 2 and 50 characters long.");
        }
    }
}
