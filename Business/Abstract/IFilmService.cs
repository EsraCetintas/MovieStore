using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IFilmService
    {
        IDataResult<List<Film>> GetAll();
        IDataResult<Film> GetById(int id);
        IResult Add(Film film);
        IResult Delete(Film film);
        IResult Update(Film film);
        IDataResult<List<FilmDetailDto>> GetFilmDetails();
    }
}
