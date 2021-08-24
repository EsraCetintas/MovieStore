using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Film:IEntity
    {
        public int FilmId { get; set; }
        public int DirectorId { get; set; }
        public int FilmTypeId { get; set; }
        public string FilmName { get; set; }
        public int FilmYear { get; set; }
        public decimal Price { get; set; }
        public bool DirectorType { get; set; }
    }
}
