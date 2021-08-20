using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IDirectorService
    {
        IDataResult<List<Director>> GetAll();
        IDataResult<Director> GetById(int id);
        IResult Add(Director director);
        IResult Delete(Director director);
        IResult Update(Director director);
    }
}
