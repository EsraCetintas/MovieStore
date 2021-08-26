using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FilmTypeManager : IFilmTypeService
    {
        IFilmTypeDal _filmTypeDal;

        public FilmTypeManager(IFilmTypeDal filmTypeDal)
        {
            _filmTypeDal = filmTypeDal;
        }

        [ValidationAspect(typeof(FilmTypeValidator))]
        public IResult Add(FilmType filmType)
        {
            _filmTypeDal.Add(filmType);
            return new SuccessResult();
        }

        public IResult Delete(FilmType filmType)
        {
            _filmTypeDal.Delete(filmType);
            return new SuccessResult();
        }

        public IDataResult<List<FilmType>> GetAll()
        {
            return new SuccessDataResult<List<FilmType>>(_filmTypeDal.GetAll());
        }

        public IDataResult<FilmType> GetById(int id)
        {
            return new SuccessDataResult<FilmType>(_filmTypeDal.GetById(f=>f.FilmTypeId==id));
        }

        [ValidationAspect(typeof(FilmTypeValidator))]
        public IResult Update(FilmType filmType)
        {
            _filmTypeDal.Update(filmType);
            return new SuccessResult();
        }
    }
}
