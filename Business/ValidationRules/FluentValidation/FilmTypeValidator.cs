using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   public class FilmTypeValidator: AbstractValidator<FilmType>
    {
        public FilmTypeValidator()
        {
            RuleFor(f=>f.TypeName).NotEmpty();
        }
    }
}
