using Business.Abstract;
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

        public void Add(Actor actor)
        {
            _actorDal.Add(actor);
        }

        public void Delete(Actor actor)
        {
            _actorDal.Delete(actor);
        }

        public List<Actor> GetAll()
        {
            return _actorDal.GetAll();
        }

        public Actor GetById(int id)
        {
            return _actorDal.GetById(a => a.ActorId == id);
        }

        public void Update(Actor actor)
        {
            _actorDal.Update(actor);
        }
    }
}
