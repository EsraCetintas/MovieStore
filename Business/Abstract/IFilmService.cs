using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IFilmService
    {
        List<Film> GetAll();
        Film GetById(int id);
        void Add(Film film);
        void Delete(Film film);
        void Update(Film film);
        List<FilmDetailDto> GetFilmDetails();
    }
}
