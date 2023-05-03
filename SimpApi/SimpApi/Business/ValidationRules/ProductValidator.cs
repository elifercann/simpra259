using FluentValidation;
using SimpApi.Models;

namespace SimpApi.Business.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Invalid name");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Invalid email");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Invalid email");
            RuleFor(x => x.Stock).InclusiveBetween( 0, 50).WithMessage("stock must be between 0 and 50");
            RuleFor(x => x.Price).InclusiveBetween( 0.0,100.0).WithMessage("price must be between 0 and 100.0");
        }
    }
}
