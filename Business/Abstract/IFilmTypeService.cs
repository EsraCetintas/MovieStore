using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IFilmTypeService
    {
        IDataResult<List<FilmType>> GetAll();
        IDataResult<FilmType> GetById(int id);
        IResult Add(FilmType filmType);
        IResult Delete(FilmType filmType);
        IResult Update(FilmType filmType);
    }
}
