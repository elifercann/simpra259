using FluentValidation;
using SimpApi.Models;

namespace SimpApi.Business.ValidationRules
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Invalid email");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Invalid name");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Invalid email");
            RuleFor(x => x.Phone).MinimumLength(11).WithMessage("You must enter at least 11 characters");
            RuleFor(x => x.Phone).MaximumLength(11).WithMessage("You must enter a maximum of 11 characters");
        }
    }
}
