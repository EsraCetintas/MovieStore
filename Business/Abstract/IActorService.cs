using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IActorService
    {
        List<Actor> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        void Delete(Actor actor);
        void Update(Actor actor);
    }
}
