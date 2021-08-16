using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Actor:IEntity
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public string ActorSurname { get; set; }

    }
}
