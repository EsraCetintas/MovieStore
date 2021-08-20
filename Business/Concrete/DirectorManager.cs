using Business.Abstract;
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
    public class DirectorManager : IDirectorService
    {
        IDirectorDal _directorDal;

        public DirectorManager(IDirectorDal directorDal)
        {
            _directorDal = directorDal;
        }

        public IResult Add(Director director)
        {
            _directorDal.Add(director);
            return new SuccessResult();
        }

        public IResult Delete(Director director)
        {
            _directorDal.Delete(director);
            return new SuccessResult();
        }

        public IDataResult<List<Director>> GetAll()
        {
            return new SuccessDataResult<List<Director>>(_directorDal.GetAll());
        }

        public IDataResult<Director> GetById(int id)
        {
            return new SuccessDataResult<Director>(_directorDal.GetById(d => d.DirectorId == id));
        }

        public IResult Update(Director director)
        {
            _directorDal.Update(director);
            return new SuccessResult();
        }
    }
}
