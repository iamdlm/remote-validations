using ContosoUniversity.Models;
using FluentValidation;
using FluentValidation.Internal;
using FluentValidation.Results;
using System;

namespace ContosoUniversity.Validators
{
    public class InstructorValidator : AbstractValidator<Instructor>
    {
        public InstructorValidator()
        {
            RuleFor(i => i.LastName).NotNull().Length(1, 50);
            RuleFor(i => i.FirstMidName).NotNull().Length(1, 50);
            // HireDate should not be null nor in the future.
            RuleFor(i => i.HireDate).NotNull().LessThan(DateTime.UtcNow);
        }
    }
}
