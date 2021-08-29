using Entities.Concrete;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
   public interface IOrderDal : IEntityRepository<Order>
    {
        List<OrderDetailDto> GetOrderDetails(Expression<Func<OrderDetailDto, bool>> filter = null);
    }
}
