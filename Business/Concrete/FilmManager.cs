using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FilmManager : IFilmService
    {
        IFilmDal _filmDal;

        public FilmManager(IFilmDal filmDal)
        {
            _filmDal = filmDal;
        }

        public IResult Add(Film film)
        {
            _filmDal.Add(film);
            return new SuccessResult();
        }

        public IResult Delete(Film film)
        {
            _filmDal.Delete(film);
            return new SuccessResult();
        }

        public IDataResult<List<Film>> GetAll()
        {
            return new SuccessDataResult<List<Film>>(_filmDal.GetAll());
        }

        public IDataResult<Film> GetById(int id)
        {
            return new SuccessDataResult<Film>(_filmDal.GetById(f => f.DirectorId == id));
        }

        public IDataResult<List<FilmDetailDto>> GetFilmDetails()
        {
            return new SuccessDataResult<List<FilmDetailDto>>(_filmDal.GetFilmDetails());
        }

        public IResult Update(Film film)
        {
            _filmDal.Update(film);
            return new SuccessResult();
        }
    }
}
