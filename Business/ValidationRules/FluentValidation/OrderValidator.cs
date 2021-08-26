using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   public class OrderValidator: AbstractValidator<Order>
    {
        public OrderValiadator()
        {
            RuleFor(o=>o.CustomerId).GreaterThan(0);
            RuleFor(o=>o.FilmId).GreaterThan(0);
            RuleFor(o => o.OrderDate).NotEmpty();
            RuleFor(o => o.Price).GreaterThan(0);
        }
    }
}
