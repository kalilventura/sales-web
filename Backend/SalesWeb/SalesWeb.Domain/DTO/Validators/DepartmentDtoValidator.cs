using FluentValidation;

namespace SalesWeb.Domain.DTO.Validators
{
    public class DepartmentDtoValidator : AbstractValidator<DepartmentDto>
    {
        public DepartmentDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is not null");
            RuleFor(x => x.Name).NotNull().WithMessage("Name is not null");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Length of name must be 3 characters");
        }
    }
}
