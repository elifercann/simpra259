using FluentValidation;
using SimpApi.Models;

namespace SimpApi.Business.ValidationRules
{
    public class StudentValidator:AbstractValidator<Student>
    {
        public StudentValidator()
        {
            //bunlar tek satırda yazılabilir ama solid de s harfine uymamız lazım o yüzden ayrı ayrı yazmak daha mantıklı ve kullanışlı
            RuleFor(x => x.Email).NotEmpty().WithMessage("Invalid mail ");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Invalid mail ");
            RuleFor(x => x.Phone).MaximumLength(11).WithMessage("Phone number can be up to 11 characters");
            RuleFor(x => x.Phone).MinimumLength(11).WithMessage("Phone number can be up to 11 characters");
        }
    }
}
