using FluentValidation;
using System;

namespace SalesWeb.DTO.Validators
{
    public class SellerDtoValidator : AbstractValidator<SellerDto>
    {
        public SellerDtoValidator()
        {
            #region [ NAME ]
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is empty");
            RuleFor(x => x.Name).NotNull().WithMessage("Name is null");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Length must be 3 characters");
            #endregion

            #region [ EMAIL ]
            RuleFor(x => x.Email).EmailAddress().WithMessage("Invalid Email");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is empty");
            RuleFor(x => x.Email).NotNull().WithMessage("Email is null");
            #endregion

            #region [ BIRTH DATE ]
            RuleFor(x => x.BirthDate).NotNull().WithMessage("Birth Date is empty");
            RuleFor(x => x.BirthDate).NotEmpty().WithMessage("Birth Date is null");
            RuleFor(x => x.BirthDate).LessThanOrEqualTo(DateTime.MinValue).WithMessage("Birth Date is invalid");
            #endregion

            #region [ BASE SALARY ]
            RuleFor(x => x.BaseSalary).NotNull().WithMessage("Salary is null");
            RuleFor(x => x.BaseSalary).NotEmpty().WithMessage("Salary is empty");
            RuleFor(x => x.BaseSalary).LessThanOrEqualTo(decimal.Zero).WithMessage("Salary is invalid");
            #endregion

            #region [ DEPARTMENT ID ]
            RuleFor(x => x.DepartmentId).NotEmpty().WithMessage("Department is empty");
            RuleFor(x => x.DepartmentId).NotNull().WithMessage("Department is null");
            RuleFor(x => x.DepartmentId).LessThanOrEqualTo(0).WithMessage("Department invalid");
            #endregion
        }
    }
}
