using Core.Utilities.Results;
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
        IDataResult<List<Actor>> GetAll();
        IDataResult<Actor> GetById(int id);
        IResult Add(Actor actor);
        IResult Delete(Actor actor);
        IResult Update(Actor actor);
    }
}
