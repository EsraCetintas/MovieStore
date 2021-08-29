using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, MovieStoreContext>, IOrderDal
    {
        public List<OrderDetailDto> GetOrderDetails(Expression<Func<OrderDetailDto, bool>> filter = null)
        {
           using(MovieStoreContext context = new MovieStoreContext())
            {
                var result = from p in context.Films
                             join o in context.Orders
                            on p.FilmId equals o.FilmId
                             join c in context.Customers
                             on o.CustomerId equals c.CustomerId
                             select new OrderDetailDto
                             {
                                 FilmId = p.FilmId,
                                 FilmName = p.FilmName,
                                 Price = p.Price,
                                 CustomerId = c.CustomerId,
                                 CustomerName = c.CustomerName,
                                 CustomerSurname = c.CustomerSurname,
                                 OrderDate = o.OrderDate
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
