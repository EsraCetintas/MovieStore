using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Business;
using Core.Entities;
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
        IActorService _actorService;

        public DirectorManager(IDirectorDal directorDal, IActorService actorService)
        {
            _directorDal = directorDal;
            _actorService = actorService;
        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(DirectorValidator))]
        [CacheRemoveAspect("IDirectorService.Get")]
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

        [CacheAspect]
        public IDataResult<List<Director>> GetAll()
        {
            return new SuccessDataResult<List<Director>>(_directorDal.GetAll());
        }

        public IDataResult<Director> GetById(int id)
        {
            return new SuccessDataResult<Director>(_directorDal.GetById(d => d.DirectorId == id));
        }
        [SecuredOperation("admin")]
        [ValidationAspect(typeof(DirectorValidator))]
        [CacheRemoveAspect("IDirectorService.Get")]
        public IResult Update(Director director)
        {
            _directorDal.Update(director);
            return new SuccessResult();
        }

    }
}
