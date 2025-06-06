using FluentValidation;
using WebApplicationTest1.dto;

namespace WebApplicationTest1.validator
{
    public class EmployeeValidator : AbstractValidator<EmployeeDto>
    {
        public EmployeeValidator() { 
            RuleFor(e => e.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(2, 50).WithMessage("Name must be between 2 and 50 characters long.");
            RuleFor(e => e.Age)
                .InclusiveBetween(18, 65).WithMessage("Age must be between 18 and 65.");
            RuleFor(e => e.DepartmentId)
                .GreaterThan(0).WithMessage("DepartmentId must be greater than 0.")
                .WithMessage("DepartmentId is required.");
        }
    }
}
