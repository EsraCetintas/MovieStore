using Business.Abstract;
using Business.BusinessAspect.Autofac;
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
    public class ActorManager : IActorService
    {
        IActorDal _actorDal;
        public ActorManager(IActorDal actorDal)
        {
            _actorDal = actorDal;
        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(ActorValidator))]
        public IResult Add(Actor actor)
        {
            _actorDal.Add(actor);
            return new SuccessResult();
        }

        public IResult Delete(Actor actor)
        {
            _actorDal.Delete(actor);
            return new SuccessResult();
        }

        public IDataResult<List<Actor>> GetAll()
        {
            return new  SuccessDataResult<List<Actor>>( _actorDal.GetAll());
        }

        public IDataResult<Actor> GetById(int id)
        {
            return new SuccessDataResult<Actor>(_actorDal.GetById(a => a.ActorId == id));
        }

        [ValidationAspect(typeof(ActorValidator))]
        public IResult Update(Actor actor)
        {
            _actorDal.Update(actor);
            return new SuccessResult();
        }
    }
}
