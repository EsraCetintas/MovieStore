using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   public class DirectorValidator: AbstractValidator<Director>
    {
        public DirectorValidator()
        {
            RuleFor(d => d.DirectorName).NotEmpty();
            RuleFor(d => d.DirectorSurname).NotEmpty();
            RuleFor(d => d.DirectorType).NotEmpty();
        }
    }
}
