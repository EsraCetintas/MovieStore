﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Order:IEntity
    {
        public int OrderId { get; set; }
        public int FilmId { get; set; }
        public int CustomerId { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
