using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
   public class OrderDetailDto:IDto
    {
        public int FilmId { get; set; }
        public int CustomerId { get; set; }
        public string FilmName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Price { get; set; }
    }
}
