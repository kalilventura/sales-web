using FluentValidation;

namespace SalesWeb.DTO.Validators
{
    public class DepartmentDTOValidator : AbstractValidator<DepartmentDTO>
    {
        public DepartmentDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is not null");
            RuleFor(x => x.Name).NotNull().WithMessage("Name is not null");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Length of name must be 3 characters");
        }
    }
}
