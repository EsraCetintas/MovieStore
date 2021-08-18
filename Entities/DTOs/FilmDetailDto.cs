using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
   public class FilmDetailDto:IDto
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public string TypeName { get; set; }
        public string DirectorName { get; set; }
        public string DirectorSurname { get; set; }
        public decimal Price { get; set; }
    }
}
