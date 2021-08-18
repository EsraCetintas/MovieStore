using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
  public class FilmType:IEntity
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
    }
}
