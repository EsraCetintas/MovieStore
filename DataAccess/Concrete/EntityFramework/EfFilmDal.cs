using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFilmDal : EfEntityRepositoryBase<Film, MovieStoreContext>, IFilmDal
    {
        public List<FilmDetailDto> GetFilmDetails()
        {
            using(MovieStoreContext context=new MovieStoreContext())
            {
                var result = from p in context.Films
                             join t in context.FilmTypes
                             on p.FilmTypeId equals t.FilmTypeId
                             join d in context.Directors
                             on p.DirectorId equals d.DirectorId
                             select new FilmDetailDto
                             {
                                 FilmId = p.FilmId,
                                 FilmName = p.FilmName,
                                 Price = p.Price,
                                 TypeName = t.TypeName,
                                 DirectorName = d.DirectorName,
                                 DirectorSurname = d.DirectorSurname

                             };
                return result.ToList();
            }
        }
    }
}
